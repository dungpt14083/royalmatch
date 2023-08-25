using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GridArea 
{
    //Index của nó 
    public readonly GridIndex Index;

    //Size của nó là bn
    public readonly GridSize Size;

    public GridPoint Center
    {
        get
        {
            float num = Index.U;
            GridSize size = Size;
            float u = num + (float)size.U * 0.5f;
            float num2 = Index.V;
            GridSize size2 = Size;
            return new GridPoint(u, num2 + (float)size2.V * 0.5f);
        }
    }

    public GridPoint Top
    {
        get
        {
            int u = Index.U;
            GridSize size = Size;
            float u2 = u + size.U;
            int v = Index.V;
            GridSize size2 = Size;
            return new GridPoint(u2, v + size2.V);
        }
    }

    public GridArea(GridIndex index, GridSize size)
    {
        Index = index;
        Size = size;
    }

    //CÁC TIỆN ÍCH CHO VIC XÉT AREA NẰM TRONG NÀO NÀO BLA BLA:::

    #region AREA UTILITIS::

    //TRUYỀN UI VÀO CHECK CÁI NÀY NĂM TRONG ĐƯỜNG BAO AREA NÀY KHÔNG
    public bool IsWithinBounds(int u, int v, GridSize size)
    {
        return IsWithinBounds(u, v, size.U, size.V);
    }

    public bool IsWithinBounds(int u, int v)
    {
        return IsWithinBounds(u, v, 1, 1);
    }

    public bool IsWithinBounds(GridIndex index)
    {
        return !index.IsInvalid && IsWithinBounds(index.U, index.V);
    }

    public bool IsWithinBounds(GridPoint point)
    {
        return IsWithinBounds(new GridIndex(point));
    }

    public bool IsWithinBounds(GridIndex index, GridSize size)
    {
        return !index.IsInvalid && IsWithinBounds(index.U, index.V, size.U, size.V);
    }

    public bool IsWithinBounds(GridArea tile)
    {
        return IsWithinBounds(tile.Index, tile.Size);
    }

    public bool IsWithinBounds(int u, int v, int w, int h)
    {
        int result;
        if (u >= Index.U && v >= Index.V)
        {
            int num = u + w;
            int u2 = Index.U;
            GridSize size = Size;
            if (num <= u2 + size.U)
            {
                int num2 = v + h;
                int v2 = Index.V;
                GridSize size2 = Size;
                result = ((num2 <= v2 + size2.V) ? 1 : 0);
                return (byte)result != 0;
            }
        }

        result = 0;
        return (byte)result != 0;
    }


    //CÁI NÀY CHECK CÓ ĐÈ LÊN HAY KHÔNG K
    public bool IsOverlapping(int u, int v)
    {
        return IsOverlapping(u, v, 1, 1);
    }

    public bool IsOverlapping(GridIndex index)
    {
        return !index.IsInvalid && IsOverlapping(index.U, index.V);
    }

    public bool IsOverlapping(GridPoint point)
    {
        return IsOverlapping(new GridIndex(point));
    }

    public bool IsOverlapping(GridArea tile)
    {
        int u = tile.Index.U;
        int v = tile.Index.V;
        GridSize size = tile.Size;
        int u2 = size.U;
        GridSize size2 = tile.Size;
        return IsOverlapping(u, v, u2, size2.V);
    }

    public override int GetHashCode()
    {
        int hashCode = Index.GetHashCode();
        GridSize size = Size;
        return hashCode + size.GetHashCode();
    }

    public bool IsOverlapping(int u, int v, int w, int h)
    {
        int num;
        if (Index.U <= u + w)
        {
            int u2 = Index.U;
            GridSize size = Size;
            num = ((u <= u2 + size.U) ? 1 : 0);
        }
        else
        {
            num = 0;
        }

        bool flag = (byte)num != 0;
        int num2;
        if (Index.V <= v + h)
        {
            int v2 = Index.V;
            GridSize size2 = Size;
            num2 = ((v <= v2 + size2.V) ? 1 : 0);
        }
        else
        {
            num2 = 0;
        }

        bool flag2 = (byte)num2 != 0;
        return flag && flag2;
    }

    public override bool Equals(object obj)
    {
        if (obj is GridArea)
        {
            GridArea gridArea = (GridArea)obj;
            int result;
            if (gridArea.Index.Equals(Index))
            {
                GridSize size = gridArea.Size;
                result = (size.Equals(Size) ? 1 : 0);
            }
            else
            {
                result = 0;
            }

            return (byte)result != 0;
        }

        return base.Equals(obj);
    }

    public override string ToString()
    {
        string arg = Index.ToString();
        GridSize size = Size;
        return string.Format("({0};{1})", arg, size.ToString());
    }

    #endregion

    #region SAVE AND LOAD:::
    
   
    
    

    #endregion
}