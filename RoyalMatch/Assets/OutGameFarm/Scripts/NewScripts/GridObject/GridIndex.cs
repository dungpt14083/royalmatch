using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridIndex : IEquatable<GridIndex>, ICanSerialize
{
    private const string UKey = "U";
    private const string VKey = "V";

    public static GridIndex Invalid
    {
        get { return new GridIndex(-1, -1); }
    }

    public int U { get; private set; }

    public int V { get; private set; }

    public bool IsInvalid
    {
        get { return U < 0 || V < 0; }
    }

    public GridIndex(int u, int v)
    {
        U = u;
        V = v;
    }

    public GridIndex(GridIndex index)
    {
        U = index.U;
        V = index.V;
    }

    public GridIndex(GridPoint point)
    {
        U = Mathf.FloorToInt(point.U);
        V = Mathf.FloorToInt(point.V);
    }

    public override string ToString()
    {
        return string.Format("({0}, {1})", U, V);
    }

    public override int GetHashCode()
    {
        return U + 1000 * V;
    }

    public override bool Equals(object obj)
    {
        if (obj is GridIndex)
        {
            return Equals((GridIndex)obj);
        }

        return base.Equals(obj);
    }

    public bool Equals(GridIndex other)
    {
        return other != null && other.U == U && other.V == V;
    }

    public GridIndex GetNeighbor(Direction direction)
    {
        int num = (direction.Contains(Direction.NW) ? 1 : (direction.Contains(Direction.SE) ? (-1) : 0));
        int num2 = (direction.Contains(Direction.NE) ? 1 : (direction.Contains(Direction.SW) ? (-1) : 0));
        return new GridIndex(U + num, V + num2);
    }

    public bool IsNeighbor(GridIndex other)
    {
        return other != null && ((U + 1 == other.U && V == other.V) || (U == other.U && V + 1 == other.V) ||
                                 (U - 1 == other.U && V == other.V) || (U == other.U && V - 1 == other.V));
    }

    #region SAVE AND LOAD DATA

    private StorageDictionary _storage;

    public GridIndex(StorageDictionary storage)
    {
        _storage = storage;
        GridIndex invalid = Invalid;
        U = _storage.Get("U", invalid.U);
        V = _storage.Get("V", invalid.V);
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("U", U);
        _storage.Set("V", V);
        return _storage;
    }

    #endregion
}