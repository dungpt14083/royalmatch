using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTile
{
  public int weight;
  public int height;
  public int[,] IsBuildable;

  public DataTile()
  {
  }

  public DataTile(int weight, int height, int[,] isBuildable)
  {
    this.weight = weight;
    this.height = height;
    IsBuildable = isBuildable;
  }
}
