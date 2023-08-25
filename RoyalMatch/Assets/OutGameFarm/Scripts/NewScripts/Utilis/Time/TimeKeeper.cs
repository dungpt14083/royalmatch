using System;
using UnityEngine;

public class TimeKeeper : ICanSerialize
{
    private Timeline _realTimeline;

    private Timeline _gameTimeline;

    private DateTime _lastAutoTickAt;

    private bool _isAutoTicking;

    private const string LastTickTimeKey = "LastSessionTime";

    private const string TimeScaleKey = "TimeScele";

    #region UTILITYXXXX

    //TimeScale trong game
    public float TimeScale
    {
        get { return _gameTimeline.TimeScale; }
        set { _gameTimeline.TimeScale = value; }
    }

    //Time giá trị double CHỈ CẦN QUAN TÂM VẬY CHO RA 2 GIÁ TR TIME LÀ ĐƯỢC R
    public double Time
    {
        get { return _gameTimeline.Time; }
    }

    //Realtime giá trị Double
    public double RealTime
    {
        get { return _realTimeline.Time; }
    }

    //RealTime tính bằng s cho tới nữa đêm
    public double RealTimeSecondsUntilMidnight
    {
        get
        {
            TimeSpan value = DateTime.Now - DateTime.UtcNow;
            DateTime dateTime = _lastAutoTickAt.Add(value);
            return (dateTime.Date.AddDays(1.0) - dateTime).TotalSeconds;
        }
    }

    #endregion


    public bool Paused { get; private set; }

    public double RemainingDeltaSeconds { get; private set; }

    public TimeKeeper()
    {
        _realTimeline = new Timeline();
        _gameTimeline = new Timeline();
        _lastAutoTickAt = DateTime.UtcNow;
    }

    //chạy tick vs time 2 lần update frame 
    public void Tick(double deltaSeconds)
    {
        int currentTick = 0;
        double previousDelta = deltaSeconds;
        //Check game chút kiểu cái tính toán time có vấn đề
        while (SubTick(ref deltaSeconds))
        {
            currentTick = InfiniteTickCheck(currentTick, previousDelta, deltaSeconds);
            previousDelta = deltaSeconds;
        }
    }

    public void TickGame(double deltaSeconds)
    {
        int currentTick = 0;
        double previousDelta = deltaSeconds;
        while (GameSubTick(ref deltaSeconds))
        {
            currentTick = InfiniteTickCheck(currentTick, previousDelta, deltaSeconds);
            previousDelta = deltaSeconds;
        }
    }

    //GỌI TỪ BÊN UPDATE VÀO ĐỂ MÀ GỌI::
    public void AutoTick()
    {
        if (_isAutoTicking)
        {
            Debug.LogErrorFormat("[TimeKeeper] AutoTick cannot be called while another AutoTick is still Ticking.");
            return;
        }

        _isAutoTicking = true;

        //Lấy time hiện ta và trừ đi time của khung cuối update bao nhiêu s và bỏ vào chạy tick
        DateTime utcNow = DateTime.UtcNow;
        double deltaSeconds = Math.Max(0.0, (utcNow - _lastAutoTickAt).TotalSeconds);
        if (!Paused)
        {
            Tick(deltaSeconds);
        }

        _lastAutoTickAt = utcNow;
        _isAutoTicking = false;
    }

    public void Pause()
    {
        Paused = true;
    }

    public void Unpause()
    {
        Paused = false;
    }

    public TimedAction GameAction(Action action, double delay)
    {
        return _gameTimeline.Schedule(action, Math.Max(0.0, delay));
    }

    public TimedAction RealTimeAction(Action action, double delay)
    {
        return _realTimeline.Schedule(action, Math.Max(0.0, delay));
    }

    public CustomYieldInstruction WaitForGameSeconds(double seconds)
    {
        return _gameTimeline.YieldFor(seconds);
    }

    public CustomYieldInstruction WaitForRealSeconds(double seconds)
    {
        return _realTimeline.YieldFor(seconds);
    }

    private bool GameSubTick(ref double deltaSeconds)
    {
        double timeNext = _gameTimeline.TimeNext;
        if (timeNext <= deltaSeconds)
        {
            RemainingDeltaSeconds = deltaSeconds - timeNext;
            _gameTimeline.ExecuteNext();
            deltaSeconds = RemainingDeltaSeconds;
            return true;
        }

        RemainingDeltaSeconds = 0.0;
        _gameTimeline.AddTime(deltaSeconds);
        deltaSeconds = RemainingDeltaSeconds;
        return false;
    }


    //Truyền time chênh 2 bên để mà sử dụng:::
    private bool SubTick(ref double deltaSeconds)
    {
        double timeNext = _realTimeline.TimeNext;
        double timeNext2 = _gameTimeline.TimeNext;
        //nếu mà time nétx với thằng gametime hưa tới thì có flag dealstecon chênh time remain truyền lại
        if (timeNext2 <= deltaSeconds && timeNext2 < timeNext)
        {
            RemainingDeltaSeconds = deltaSeconds - timeNext2;
            UpdateAutoTickTime(timeNext2);
            _realTimeline.AddTime(timeNext2);
            _gameTimeline.ExecuteNext();
            deltaSeconds = RemainingDeltaSeconds;
            return true;
        }

        //tương tự tới realtime
        if (timeNext <= deltaSeconds)
        {
            RemainingDeltaSeconds = deltaSeconds - timeNext;
            UpdateAutoTickTime(timeNext);
            _gameTimeline.AddTime(timeNext);
            _realTimeline.ExecuteNext();
            deltaSeconds = RemainingDeltaSeconds;
            return true;
        }

        //không vào trường hợp nào kia thì sẽ addtime vào realtime và trả về 0
        RemainingDeltaSeconds = 0.0;
        UpdateAutoTickTime(deltaSeconds);
        _gameTimeline.AddTime(deltaSeconds);
        _realTimeline.AddTime(deltaSeconds);
        deltaSeconds = RemainingDeltaSeconds;
        return false;
    }

    private int InfiniteTickCheck(int currentTick, double previousDelta, double currentDelta)
    {
        if (previousDelta > currentDelta)
        {
            return 0;
        }

        if (currentTick == 20)
        {
            Debug.LogWarning(
                "More than 20 timed actions complated at the same time! If this becomes 50 the game will crash!");
        }
        else if (currentTick > 50)
        {
            throw new Exception(
                "More than 50 timed actions complated at the same time! This is problerly due to an infinite loop!");
        }

        return currentTick + 1;
    }

    private void UpdateAutoTickTime(double deltaSeconds)
    {
        if (_isAutoTicking)
        {
            _lastAutoTickAt = _lastAutoTickAt.AddSeconds(deltaSeconds);
        }
    }

    #region SAVE AND LOAD

    private StorageDictionary _storage;

    //ĐỔ DATA VÀO TRONG GAME:::
    public TimeKeeper(StorageDictionary storage)
    {
        _storage = storage;
        _realTimeline = new Timeline();
        _gameTimeline = new Timeline();
        TimeScale = _storage.Get("TimeScele", 1f);
        _lastAutoTickAt = _storage.GetDateTime("LastSessionTime", DateTime.UtcNow);
    }
    
    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("LastSessionTime", _lastAutoTickAt);
        _storage.Set("TimeScele", TimeScale);
        return _storage;
    }

    #endregion
}