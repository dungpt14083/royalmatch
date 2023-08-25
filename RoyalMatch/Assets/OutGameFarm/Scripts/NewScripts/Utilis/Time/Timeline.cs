using System;
using Priority_Queue;
using UnityEngine;

//DÒNG THỜI GIAN CÓ 2 LOẠI LÀ LOẠI 
public class Timeline
{
    private SimplePriorityQueue<TimedAction, double> _queue;

    private float _timeScale;

    private double _time;

    public double Time
    {
        get { return _time; }
    }

    public float TimeScale
    {
        get { return _timeScale; }
        set
        {
            if (value < 0f)
            {
                throw new ArgumentException("TimeScale must be a positive number.");
            }

            _timeScale = value;
        }
    }

    public bool HasActions
    {
        get { return _queue.Count > 0; }
    }
    
    public int Count
    {
        get { return _queue.Count; }
    }

    public double TimeNext
    {
        get
        {
            if (_queue.Count > 0 && _timeScale > 0f)
            {
                return (_queue.First.Time - _time) / (double)_timeScale;
            }

            return double.MaxValue;
        }
    }

    public Timeline()
    {
        _queue = new SimplePriorityQueue<TimedAction, double>();
        _timeScale = 1f;
        _time = 0.0;
    }

    public void AddTime(double deltaSeconds)
    {
        _time += deltaSeconds * (double)_timeScale;
        if (_queue.Count > 0 && _queue.First.Time < _time)
        {
            _time = _queue.First.Time;
        }
    }

    public void ExecuteNext()
    {
        if (_queue.Count > 0)
        {
            TimedAction timedAction = _queue.Dequeue();
            _time = timedAction.Time;
            timedAction.Action();
        }
    }

    public TimedAction Schedule(Action action, double delay)
    {
        if (delay < 0.0)
        {
            throw new ArgumentException("delay must be a positive number.");
        }

        TimedAction timedAction = new TimedAction(this, action, _time + delay);
        _queue.Enqueue(timedAction, timedAction.Time);
        return timedAction;
    }

    public bool Cancel(TimedAction action)
    {
        if (_queue.Contains(action))
        {
            _queue.Remove(action);
            return true;
        }

        return false;
    }

    public double RemainingTime(TimedAction action)
    {
        return action.Time - _time;
    }

    public CustomYieldInstruction YieldFor(double delay)
    {
        double time = _time + delay;
        return new WaitUntil(() => _time > time);
    }
}