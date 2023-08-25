using System;

public class TimedAction
{
    public readonly double Time;

    public readonly Action Action;

    private readonly Timeline _timeline;

    public double RemainingTime
    {
        get
        {
            return _timeline.RemainingTime(this);
        }
    }

    public bool HasRemainingTime
    {
        get
        {
            return RemainingTime >= 0.0;
        }
    }

    public TimedAction(Timeline timeline, Action action, double time)
    {
        Time = time;
        Action = action;
        _timeline = timeline;
    }

    public void Cancel()
    {
        _timeline.Cancel(this);
    }
}
