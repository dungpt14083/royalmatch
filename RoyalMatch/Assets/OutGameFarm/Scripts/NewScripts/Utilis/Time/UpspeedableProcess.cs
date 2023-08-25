using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UpspeedableProcess : ICanSerialize
{
    public delegate void SpedUpEventHandler(UpspeedableProcess process);

    public delegate void CompletedEventHandler(UpspeedableProcess process);

    public delegate void TimeScaleChangedEventHandler(double timeScale);

    public delegate void DelayChangedEventHandler(UpspeedableProcess process, double delay);

    public event SpedUpEventHandler SpeedUpEvent;
    public event CompletedEventHandler CompletedEvent;
    public event TimeScaleChangedEventHandler TimeScaleChangedEvent;
    public event DelayChangedEventHandler DelayChangedEvent;

    private void FireSpeedUpEvent()
    {
        if (this.SpeedUpEvent != null)
        {
            this.SpeedUpEvent(this);
        }
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

    private void FireDelayChangedEvent(double delay)
    {
        if (this.DelayChangedEvent != null)
        {
            this.DelayChangedEvent(this, delay);
        }
    }


    #region NEW RefACTORING

    //public IslandFarmProperties IslandFarmProperties { get; private set; }
    //public IslandFarmBalance IslandFarmBalance { get; private set; }


    public GeneralProperties GeneralProperties { get; private set; }


    public double RemainingTimeSeconds
    {
        get { return _delayedAction.RemainingTimeSeconds; }
    }

    public double TotalTimeSeconds
    {
        get { return _delayedAction.TotalTimeSeconds; }
    }

    public TimeKeeper TimeKeeper { get; private set; }


    private DelayedAction _delayedAction;
    private double _timeStep;
    private Drain _gemsDrain;


    private double CalculateTimeStep()
    {
        long amount = GeneralProperties.GetSpeedupProperties(TotalTimeSeconds).Cost.Amount;
        return TotalTimeSeconds / (double)amount;
    }

    public CustomYieldInstruction WaitForProcessSeconds(double seconds)
    {
        return _delayedAction.WaitForProcessSeconds(seconds);
    }

    public void SetTimeScale(double timeScale)
    {
        _delayedAction.SetTimeScale(timeScale);
        FireTimeScaleChangeEvent(timeScale);
    }

    public void RescheduleWithDelay(double delay)
    {
        _delayedAction.RescheduleWithDelay(delay);
        FireDelayChangedEvent(delay);
    }

    public void CancelAction()
    {
        _delayedAction.CompletedEvent -= OnDelayedActionCompleted;
        _delayedAction.CancelAction();
    }

    public void CompleteAction()
    {
        _delayedAction.CompletedEvent -= OnDelayedActionCompleted;
        _delayedAction.CompleteAction();
        FireSpeedUpEvent();
    }

    private void OnDelayedActionCompleted(DelayedAction delayedAction)
    {
        delayedAction.CompletedEvent -= OnDelayedActionCompleted;
        FireCompletedEvent();
    }

    #region saveand load

    protected StorageDictionary _storage;

    public UpspeedableProcess(IslandFarmProperties islandFarmProperties,
        TimeKeeper timeKeeper,
        double delay,
        double timeScale, float upspeedCostMultiplier, Action action, Drain drain, GeneralBalance generalBalance,
        GeneralProperties generalProperties)
    {
        GeneralProperties = generalProperties;
        //IslandFarmBalance = IslandFarmBalance;
        TimeKeeper = timeKeeper;
        _gemsDrain = drain;
        _delayedAction = new DelayedAction(timeKeeper, delay, timeScale, false, action);
        _delayedAction.CompletedEvent += OnDelayedActionCompleted;
        _timeStep = CalculateTimeStep();
    }

    public UpspeedableProcess(IslandFarmProperties islandFarmProperties, TimeKeeper timeKeeper,
        double delay, double timeScale, float upspeedCostMultiplier, Action action, GeneralProperties generalProperties)
    {
        GeneralProperties = generalProperties;
        TimeKeeper = timeKeeper;
        _delayedAction = new DelayedAction(timeKeeper, delay, timeScale, false, action);
        _delayedAction.CompletedEvent += OnDelayedActionCompleted;
        //_timeStep = CalculateTimeStep();
    }

    public UpspeedableProcess(StorageDictionary storage)
    {
        _storage = storage;
        _delayedAction = new DelayedAction(_storage.GetStorageDict("DelayedAction"));
        _gemsDrain = (Drain)_storage.Get("GemsDrain", (int)_gemsDrain);
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("DelayedAction", _delayedAction);
        _storage.Set("GemsDrain", (int)_gemsDrain);
        return _storage;
    }

    public void ResolveDependencies(GameData game, IsLandInfo isLandInfo, Action completeAction)
    {
        GeneralProperties = game.GeneralProperties;
        //IslandFarmBalance = game.GeneralBalance;
        TimeKeeper = game.Time;
        _delayedAction.ResolveDependencies(game.Time, false, completeAction);
        _delayedAction.CompletedEvent += OnDelayedActionCompleted;
        _timeStep = CalculateTimeStep();
    }

    #endregion

    #endregion
}