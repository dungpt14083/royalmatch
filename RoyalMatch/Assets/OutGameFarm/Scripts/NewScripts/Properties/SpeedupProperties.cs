using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedupProperties : EntityProperties
{
    private const string CostKey = "cost";

    private const string MinTimeRemainingSecondsKey = "minTimeRemainingSeconds";

    private const string MaxTimeRemainingSecondsKey = "maxTimeRemainingSeconds";

    public Currency Cost { get; private set; }

    public float MinTimeRemainingSeconds { get; private set; }

    public float MaxTimeRemainingSeconds { get; private set; }

    public SpeedupProperties(PropertiesDictionary propsDict, string key)
        : base(propsDict, key)
    {
        Currency result;
        if (Currency.TryParse(GetProperty("cost", string.Empty), out result))
        {
            Cost = result;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.cost'", key);
        }

        MinTimeRemainingSeconds = GetProperty("minTimeRemainingSeconds", 0f);
        MaxTimeRemainingSeconds = GetProperty("maxTimeRemainingSeconds", 0f);
    }

    public bool InRange(double seconds)
    {
        return seconds >= (double)MinTimeRemainingSeconds && seconds < (double)MaxTimeRemainingSeconds;
    }
}