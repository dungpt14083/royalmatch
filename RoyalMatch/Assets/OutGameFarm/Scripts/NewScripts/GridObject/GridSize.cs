using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GridSize
{
    public readonly int U;

    public readonly int V;

    public static GridSize One
    {
        get { return new GridSize(1, 1); }
    }

    public static GridSize Zero
    {
        get { return new GridSize(0, 0); }
    }

    public bool IsInvalid
    {
        get { return U < 0 || V < 0; }
    }

    public GridPoint Half
    {
        get { return new GridPoint((float)U * 0.5f, (float)V * 0.5f); }
    }

    public long Magnitude
    {
        get { return U * V; }
    }

    public GridSize(int u, int v)
    {
        this = default(GridSize);
        U = u;
        V = v;
    }

    public GridSize(GridSize size)
        : this(size.U, size.V)
    {
    }

    public override int GetHashCode()
    {
        return U + 1000 * V;
    }

    public override bool Equals(object obj)
    {
        if (obj is GridSize)
        {
            GridSize gridSize = (GridSize)obj;
            return gridSize.U == U && gridSize.V == V;
        }

        return base.Equals(obj);
    }

    public override string ToString()
    {
        return string.Format("({0}x{1})", U, V);
    }
}