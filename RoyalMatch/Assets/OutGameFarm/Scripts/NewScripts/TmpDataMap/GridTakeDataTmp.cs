using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

//LƯU Ý ĐIỂM TÂM HỆ GRID PHẢI LÀ DƯỚI CÙNG CỦA HỆ NẰM Ở GÓC DƯỚI CÙNG
public class GridTakeDataTmp : MonoBehaviour
{
    #region Singleton

    //CHI dung nay tranh sigleton tao new instance xung dot
    public static GridTakeDataTmp Instance;
    public bool Initialized { get; set; }

    #endregion


    public bool[,] IsBuildable { get; private set; }


    public void Start()
    {
        Initialized = false;
        Instance = this;
        //Executors.Instance.StartCoroutine(Initialize());
    }


    // public IEnumerator Initialize()
    // {
    //     //yield return new WaitUntil(() => GridBuildingSystem.Instance != null);
    //     //yield return new WaitUntil(() => GridBuildingSystem.Instance.Initialized);
    //     //Initialized = true;
    //     //IsBuildable = GridBuildingSystem.CheckTrueFalse();
    // }
}