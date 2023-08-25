using System;
using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using Priority_Queue;
using UnityEngine;

public class TutorialDirector : ICanSerialize
{
    public delegate void TutorialStartedEventHandler(TutorialFarm tutorial);

    public delegate void TutorialEndedEventHandler(TutorialFarm tutorial);

    public delegate void TutorialFinishedEventHandler(TutorialFarm tutorial);

    public delegate void TutorialResetEventHandler(TutorialFarm tutorial);

    public delegate void FinishedAllTutorialsEventHandler();

    private const string FinishedTutorialsKey = "FinishedTutorials";

    private const string CurrentTutorialTypeKey = "CurrentTutorialType";

    private const string CurrentTutorialKey = "CurrentTutorial";

    private const string TutorialQueueKey = "TutorialQueue";

    public event TutorialStartedEventHandler TutorialStartedEvent;
    public event TutorialEndedEventHandler TutorialEndedEvent;
    public event TutorialFinishedEventHandler TutorialFinishedEvent;
    public event TutorialResetEventHandler TutorialResetEvent;
    public event FinishedAllTutorialsEventHandler FinishedAllTutorialsEvent;

    private GameData _game;

    //list tutorial đã tắt rồi đã xong rồi// để cho chắc và bên nhiệm vụ cũng có cái này::
    private List<TutorialType> _finishedTutorials = new List<TutorialType>();

    //loại Current là loại ntn
    private TutorialType _currentTutorialType;

    //CÁC REQUEST TRONG QUÊU ĐƯỢC SẮP XẾP TRÌNH TỰ KHI HẾT TUTORIAL NÀY LẬP TỨC KÍCH HOẠT TUTORIAL KHÁC NGAY::
    private SimplePriorityQueue<TutorialRequest, int> _tutorialQueue = new SimplePriorityQueue<TutorialRequest, int>();

    //LIST TUTORIAL CÒN LẠI VỚI DATA CỦA NÓ DẠNG LÕI CỦA NÓ CHẠY
    private Dictionary<TutorialType, TutorialFarm> _remainingTutorials = new Dictionary<TutorialType, TutorialFarm>();

    public PopupManager PopupManager { get; private set; }
    public CameraOperator CameraOperator { get; private set; }

    public TutorialFarm CurrentTutorial
    {
        get
        {
            TutorialFarm value;
            if (!_remainingTutorials.TryGetValue(_currentTutorialType, out value))
            {
                return null;
            }

            return value;
        }
    }

    public bool HasActiveTutorial
    {
        get { return _currentTutorialType != TutorialType.None; }
    }

    private void FireTutorialStartedEvent(TutorialFarm tutorial)
    {
        if (this.TutorialStartedEvent != null)
        {
            this.TutorialStartedEvent(tutorial);
        }
    }

    private void FireTutorialEndedEvent(TutorialFarm tutorial)
    {
        if (this.TutorialEndedEvent != null)
        {
            this.TutorialEndedEvent(tutorial);
        }
    }

    private void FireTutorialFinishedEvent(TutorialFarm tutorial)
    {
        if (this.TutorialFinishedEvent != null)
        {
            this.TutorialFinishedEvent(tutorial);
        }
    }

    private void FireTutorialResetEvent(TutorialFarm tutorial)
    {
        if (this.TutorialResetEvent != null)
        {
            this.TutorialResetEvent(tutorial);
        }
    }

    private void FireFinishedAllTutorialsEvent()
    {
        if (this.FinishedAllTutorialsEvent != null)
        {
            this.FinishedAllTutorialsEvent();
        }
    }

    public TutorialDirector(GameData game)
    {
        _game = game;
        PopupManager = _game.PopupManager;
        CameraOperator = null; //_game.IsLandInfo.CameraOperator;

        //TRONG NÀY RẤT QUAN TRỌNG SẼ TỪ ĐÂY MÀ SẼ NGHE SỰ KIỆN MISSION INVOKE ĐỂ CHẠY TUTORIAL

        //Điền hết tutorial vào đây đây là tạo trước instance để nó tự động nếu không thì chả cần làm ntn 
        FillRemainingTutorials();
    }

    //MỚI VÀO GAME THÌ THỬ CHẠY TUTORIAL ở bên gamescnefarmmanager gọi:::
    public void TryStartingATutorial()
    {
        if (_currentTutorialType != 0)
        {
            return;
        }

        TutorialRequest first;

        //xem trong queue có tutorial nào k từ đó sẽ :::
        if (_tutorialQueue.TryFirst(out first))
        {
            if (ShouldStartTutorial(first))
            {
                first = _tutorialQueue.Dequeue();
                StartTutorial(first);
            }

            return;
        }

        //nếu không thì sẽ invoke list tutorial...
        // using (Dictionary<TutorialType, TutorialFarm>.Enumerator enumerator = _remainingTutorials.GetEnumerator())
        // {
        //     while (enumerator.MoveNext() && !TryStartingTutorial(enumerator.Current.Key))
        //     {
        //         //break;
        //     }
        // }
    }

    public bool TryStartingTutorial(TutorialType tutorialType)
    {
        return TryStartingTutorial(new TutorialRequest(tutorialType));
    }

    public bool TryStartingTutorial(TutorialRequest tutorialRequest)
    {
        if (_tutorialQueue.Count == 0 && ShouldStartTutorial(tutorialRequest))
        {
            StartTutorial(tutorialRequest);
            return true;
        }

        return false;
    }

    public void StartTutorial(TutorialRequest tutorialRequest)
    {
        if (tutorialRequest == null)
        {
            Debug.LogWarning("Cannot start Tutorial because the request is null.");
        }
        else if (_currentTutorialType != 0)
        {
            Debug.LogWarningFormat("Cannot start Tutorial '{0}' because Tutorial '{1}' is the current active tutorial.",
                tutorialRequest.TutorialType, _currentTutorialType);
        }
        else if (IsFinished(tutorialRequest.TutorialType))
        {
            Debug.LogWarningFormat("Cannot start Tutorial '{0}' because it is already finished.",
                tutorialRequest.TutorialType);
        }
        else
        {
            _currentTutorialType = tutorialRequest.TutorialType;
            TutorialFarm currentTutorial = CurrentTutorial;
            currentTutorial.StartTutorial(tutorialRequest.TutorialData);
            FireTutorialStartedEvent(currentTutorial);
        }
    }


    public bool IsFinished(TutorialType tutorial)
    {
        return _finishedTutorials.Contains(tutorial);
    }


    public bool ShouldStartTutorial(TutorialRequest tutorialRequest)
    {
        if (tutorialRequest == null || _currentTutorialType != 0 || tutorialRequest.TutorialType == TutorialType.None ||
            IsFinished(tutorialRequest.TutorialType))
        {
            return false;
        }

        return _remainingTutorials[tutorialRequest.TutorialType].ShouldStartTutorial(tutorialRequest.TutorialData);
    }

    public void FinishCurrentTutorial(bool markAsFinished = true)
    {
        if (_currentTutorialType == TutorialType.None)
        {
            Debug.LogWarningFormat("There is no active tutorial.");
        }
        else
        {
            FinishTutorial(_currentTutorialType, markAsFinished);
        }
    }

    public void FinishTutorial(TutorialType tutorialType, bool markAsFinished = true)
    {
        if (IsFinished(tutorialType))
        {
            Debug.LogWarningFormat("Tutorial '{0}' is already finished.", tutorialType);
        }
        else
        {
            FinishTutorial(_remainingTutorials[tutorialType]);
        }
    }

    //KẾT THÚC GIỮA CHỪNG khi skip và hoàn thành cái này ::
    public void FinishTutorial(TutorialFarm tutorial, bool markAsFinished = true)
    {
        if (IsFinished(tutorial.Type))
        {
            Debug.LogWarningFormat("Tutorial '{0}' is already finished.", tutorial.Type);
            return;
        }

        tutorial.EndTutorial();
        if (tutorial == CurrentTutorial)
        {
            _currentTutorialType = TutorialType.None;
        }

        //Đánh dấu là đã hoàn thành true thì sẽ nận còn k thì phát sự kiện mwajc định là true
        if (markAsFinished)
        {
            _remainingTutorials.Remove(tutorial.Type);
            _finishedTutorials.Add(tutorial.Type);
            FireTutorialFinishedEvent(tutorial);
        }
        else
        {
            FireTutorialEndedEvent(tutorial);
        }
    }

    //TẠO TRƯỚC INSTNCAE VÀ INIT ĐỂ NÓ TỰ ĐỘNG NHẬN TRIGGER KÍCH HOẠT CSAI NÀY CẦN THIẾT HAY K?
    private void FillRemainingTutorials()
    {
        Array values = Enum.GetValues(typeof(TutorialType));
        int length = values.Length;
        for (int i = 0; i < length; i++)
        {
            TutorialType tutorialType = (TutorialType)values.GetValue(i);
            if (!IsFinished(tutorialType) && !_remainingTutorials.ContainsKey(tutorialType))
            {
                _remainingTutorials.Add(tutorialType, CreateTutorial(tutorialType));
            }
        }
    }

    //Khi vào game thì tạo turtorrial lõi cho bọn kia và add vào list::
    private TutorialFarm CreateTutorial(TutorialType tutorialType)
    {
        switch (tutorialType)
        {
            case TutorialType.None:
                return null;
            case TutorialType.WelcomeTutorial:
                return new WelcomeTutorial(this);
            default:
                Debug.LogWarningFormat("Missing Tutorial creation for '{0}'", tutorialType);
                return null;
        }
    }

    //TẠM THỜI LIÊN QUAN TOI TUTORIAL BỎ QUA

    #region SAVE AND LOAD

    private StorageDictionary _storage;


    public void ResolveDependencies(GameData game /*, Device device*/)
    {
        _game = game;
        // _device = device;
        // PopupManager = _game.PopupManager;
        // CameraOperator = _game.Island.CameraOperator;
        // FillRemainingTutorials();
        // if (_currentTutorialType != 0)
        // {
        //     _remainingTutorials[_currentTutorialType].ResolveDependencies(_game, _device, this);
        // }
        // foreach (TutorialRequest item in _tutorialQueue)
        // {
        //     item.ResolveDependencies(this, _game);
        // }
    }


    public TutorialDirector(StorageDictionary storage)
    {
        _storage = storage;
        _currentTutorialType = (TutorialType)_storage.Get("CurrentTutorialType", 0);
        if (_storage.Contains("CurrentTutorial"))
        {
            //_remainingTutorials.Add(_currentTutorialType, CreateTutorial(_currentTutorialType, _storage.GetStorageDict("CurrentTutorial")));
        }

        List<int> list = _storage.GetList<int>("FinishedTutorials");
        int count = list.Count;
        for (int i = 0; i < count; i++)
        {
            _finishedTutorials.Add((TutorialType)list[i]);
        }
        //List<TutorialRequest> models = _storage.GetModels("TutorialQueue", (StorageDictionary s) => new TutorialRequest(s));
        // count = models.Count;
        // for (int j = 0; j < count; j++)
        // {
        //     TutorialRequest tutorialRequest = models[j];
        //     _tutorialQueue.Enqueue(tutorialRequest, (int)tutorialRequest.TutorialType);
        // }
    }

    //CÁI NÀY TẠM BỎ QUA ĐI LIÊN QUAN TUTORIAL
    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("CurrentTutorialType", (int)_currentTutorialType);
        //_storage.SetOrRemove("CurrentTutorial", CurrentTutorial);
        List<int> list = new List<int>();
        int count = _finishedTutorials.Count;
        for (int i = 0; i < count; i++)
        {
            list.Add((int)_finishedTutorials[i]);
        }

        _storage.Set("FinishedTutorials", list);
        List<TutorialRequest> list2 = new List<TutorialRequest>();
        foreach (TutorialRequest item in _tutorialQueue)
        {
            list2.Add(item);
        }

        //_storage.Set("TutorialQueue", list2);
        return _storage;
    }

    #endregion
}