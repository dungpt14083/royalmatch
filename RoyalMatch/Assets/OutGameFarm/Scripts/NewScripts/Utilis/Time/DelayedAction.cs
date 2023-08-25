using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelayedAction : ICanSerialize
{
    public delegate void CompletedEventHandler(DelayedAction delayedAction);

    public delegate void TimeScaleChangedEventHandler(double timeScale);

    public delegate void DelayChangedEventHandler(double delayInSeconds);

    private TimedAction _timedAction;

    private Action _completeAction;

    private double _delayInSeconds;

    private bool _isRealTime;

    public bool HasRemainingTime
    {
        get { return RemainingTimeSeconds > 0.0; }
    }

    public double RemainingTimeSeconds
    {
        get
        {
            if (_timedAction != null && _timedAction.HasRemainingTime)
            {
                return _timedAction.RemainingTime * TimeScale;
            }

            return 0.0;
        }
    }

    public float CompletionPercentage
    {
        get { return Mathf.Clamp01(1f - (float)(RemainingTimeSeconds / _delayInSeconds)); }
    }

    public double TotalTimeSeconds
    {
        get { return _delayInSeconds; }
    }

    public double RemainingRealTimeSeconds
    {
        get
        {
            if (_isRealTime)
            {
                return RemainingTimeSeconds;
            }

            return RemainingTimeSeconds / (double)TimeKeeper.TimeScale;
        }
    }

    public bool IsRunning
    {
        get { return _timedAction != null; }
    }

    public TimeKeeper TimeKeeper { get; private set; }

    public double TimeScale { get; private set; }


    public event CompletedEventHandler CompletedEvent;
    public event TimeScaleChangedEventHandler TimeScaleChangedEvent;
    public event DelayChangedEventHandler DelayChangedEvent;


    public DelayedAction(TimeKeeper timeKeeper, double delayInSeconds, double timeScale, bool realTime, Action action)
    {
        if (timeScale <= 0.0)
        {
            Debug.LogError("Timescale must be greater then 0. Will use epsilon.");
            timeScale = 1.0;
        }

        TimeKeeper = timeKeeper;
        _completeAction = action;
        _delayInSeconds = delayInSeconds;
        _isRealTime = realTime;
        TimeScale = timeScale;
        CreateTimedAction(_delayInSeconds);
    }

    private void FireCompletedEvent()
    {
        if (this.CompletedEvent != null)
        {
            this.CompletedEvent(this);
        }
    }

    private void FireTimeScaleChangeEvent(double timeScale)
    {
        if (this.TimeScaleChangedEvent != null)
        {
            this.TimeScaleChangedEvent(timeScale);
        }
    }

    private void FireDelayChangedEvent(double delayInSeconds)
    {
        if (this.DelayChangedEvent != null)
        {
            this.DelayChangedEvent(delayInSeconds);
        }
    }

    public override string ToString()
    {
        string text = "unknown";
        text = _completeAction.Method.DeclaringType.FullName;
        return "[Delay=" + _delayInSeconds + ",TimeScale=" + TimeScale + ",RealTime?=" + _isRealTime + ",Action=" +
               text + "]";
    }

    public void CompleteAction()
    {
        if (_timedAction != null)
        {
            _timedAction.Cancel();
            ActionCallback();
        }
    }

    public void CancelAction()
    {
        if (_timedAction != null)
        {
            _timedAction.Cancel();
            _timedAction = null;
        }
    }

    public void SetTimeScale(double timeScale)
    {
        if (timeScale <= 0.0)
        {
            Debug.LogError("Timescale must be greater then 0. Will use epsilon.");
            return;
        }

        if (_timedAction != null)
        {
            double delayInSeconds = _timedAction.RemainingTime * TimeScale;
            _timedAction.Cancel();
            TimeScale = timeScale;
            CreateTimedAction(delayInSeconds);
        }
        else
        {
            TimeScale = timeScale;
        }

        FireTimeScaleChangeEvent(timeScale);
    }

    public void RescheduleWithDelay(double delayInSeconds)
    {
        if (_timedAction != null)
        {
            _timedAction.Cancel();
        }

        _delayInSeconds = delayInSeconds;
        CreateTimedAction(_delayInSeconds);
        FireDelayChangedEvent(_delayInSeconds);
    }

    public CustomYieldInstruction WaitForProcessSeconds(double seconds)
    {
        double startTime = TimeKeeper.Time;
        return new WaitUntil(() => TimeKeeper.Time > startTime + seconds / TimeScale);
    }

    private void ActionCallback()
    {
        _timedAction = null;
        _completeAction();
        FireCompletedEvent();
    }

    private void CreateTimedAction(double delayInSeconds)
    {
        if (_isRealTime)
        {
            _timedAction = TimeKeeper.RealTimeAction(ActionCallback, delayInSeconds / TimeScale);
        }
        else
        {
            _timedAction = TimeKeeper.GameAction(ActionCallback, delayInSeconds / TimeScale);
        }
    }

    #region SAVE AND LOAD ::

    private StorageDictionary _storage;

    public DelayedAction(StorageDictionary storage)
    {
        _storage = storage;
        _delayInSeconds = _storage.Get("Delay", double.Epsilon);
        TimeScale = _storage.Get("TimeScale", 1.0);
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("Delay", _delayInSeconds);
        _storage.Set("TimeScale", TimeScale);
        if (_timedAction == null)
        {
            _storage.Remove("CompletionTime");
        }
        else
        {
            _storage.Set("CompletionTime", RemainingTimeSeconds);
        }

        return _storage;
    }

    public void ResolveDependencies(TimeKeeper time, bool realTime, Action completeAction)
    {
        TimeKeeper = time;
        _isRealTime = realTime;
        _completeAction = completeAction;
        if (_storage.Contains("CompletionTime"))
        {
            CreateTimedAction(_storage.Get("CompletionTime", 0.0));
        }
    }

    #endregion
}