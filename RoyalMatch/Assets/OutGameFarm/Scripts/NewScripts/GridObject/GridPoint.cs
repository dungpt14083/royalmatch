using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GridPoint
{
    public readonly float U;

    public readonly float V;

    public GridPoint Normalized
    {
        get
        {
            float num = Mathf.Sqrt(U * U + V * V) + 5E-05f;
            return new GridPoint(U / num, V / num);
        }
    }

    public GridPoint(float u, float v)
    {
        this = default(GridPoint);
        U = u;
        V = v;
    }

    public GridPoint(Vector2 point)
        : this(point.x, point.y)
    {
    }

    public GridPoint(GridIndex index)
        : this(index.U, index.V)
    {
    }

    public static GridPoint Lerp(GridPoint a, GridPoint b, float t)
    {
        return new GridPoint(Mathf.Lerp(a.U, b.U, t), Mathf.Lerp(a.V, b.V, t));
    }

    public static GridPoint operator -(GridPoint left, GridPoint right)
    {
        return new GridPoint(left.U - right.U, left.V - right.V);
    }

    public static GridPoint operator +(GridPoint left, GridPoint right)
    {
        return new GridPoint(left.U + right.U, left.V + right.V);
    }

    public static GridPoint operator +(GridPoint left, GridIndex right)
    {
        return new GridPoint(left.U + (float)right.U, left.V + (float)right.V);
    }

    public static GridPoint operator +(GridIndex left, GridPoint right)
    {
        return right + left;
    }

    public static GridPoint operator *(GridPoint left, float right)
    {
        return new GridPoint(left.U * right, left.V * right);
    }

    public static GridPoint operator *(float right, GridPoint left)
    {
        return left * right;
    }

    public static GridPoint operator /(GridPoint left, float right)
    {
        return new GridPoint(left.U / right, left.V / right);
    }

    public float DistanceTo(GridPoint other)
    {
        return Mathf.Sqrt((U - other.U) * (U - other.U) + (V - other.V) * (V - other.V));
    }

    public override string ToString()
    {
        return string.Format("({0}, {1})", U, V);
    }
}
