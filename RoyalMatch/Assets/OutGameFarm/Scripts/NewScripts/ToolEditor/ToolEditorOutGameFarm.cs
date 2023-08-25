using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

#if UNITY_EDITOR
public class ToolEditorOutGameFarm : EditorWindow
{
    public static Tilemap MainTilemap;
    private static ToolEditorOutGameFarm _toolEditorOutGameFarm;

    [MenuItem("Game Farm/ToolEditorOutGameFarm")]
    public static void Init()
    {
        _toolEditorOutGameFarm = (ToolEditorOutGameFarm)EditorWindow.GetWindow(typeof(ToolEditorOutGameFarm));
        _toolEditorOutGameFarm.Show();
    }

    private void OnGUI()
    {
        //ánh xạ MainTileMap trên scene vào tool editor 
        MainTilemap = (Tilemap)EditorGUILayout.ObjectField("Main Tilemap", MainTilemap, typeof(Tilemap), true);

        if (GUILayout.Button("Save Tiles"))
        {
            WriteTiles();
        }
    }

    void OnInspectorUpdate()
    {
        Repaint();
    }

    #region WirteTiles

    private void WriteTiles()
    {
        // var tmp = new int[20, 20];
        // for (int i = 0; i < tmp.GetLength(0); i++)
        // {
        //     for (int j = 0; j < tmp.GetLength(1); j++)
        //     {
        //         Vector3Int pos = new Vector3Int(i, j, 0);
        //         TileBase tile = MainTilemap.GetTile(pos);
        //         if (tile != null /*&& tile == TileBase[TileType.White]*/)
        //         {
        //             tmp[i, j] = 0;
        //         }
        //         else
        //         {
        //             tmp[i, j] = 1;
        //         }
        //     }
        // }

        var tmpVar = MainTilemap.cellBounds;
        // var heightMinTmp = tmpVar.min.x;
        var heightMaxTmp = tmpVar.max.x;
        // var widthMinTmp = tmpVar.min.y;
        var widthMaxTmp = tmpVar.max.y;
        var tmpMinArray = heightMaxTmp - 0;
        var tmpMaxArray = widthMaxTmp - 0;
        var tmp = new int[tmpMinArray >= 0 ? tmpMinArray : 0, tmpMaxArray >= 0 ? tmpMaxArray : 0];
        for (int x = 0; x < heightMaxTmp; x++)
        {
            for (int y = 0; y < widthMaxTmp; y++)
            {
                Vector3Int tilePosition = new Vector3Int(x, y, 0);
                TileBase tile = MainTilemap.GetTile(tilePosition);
                if (tile != null)
                {
                    tmp[x, y] = 0;
                }
                else
                {
                    tmp[x, y] = 1;
                }
            }
        }

        DataTile data = new DataTile(widthMaxTmp, heightMaxTmp, tmp);
        SaveData(data);
    }

    private static void SaveData(DataTile tmp)
    {
        string json = JsonConvert.SerializeObject(tmp);
        string folderPath = Path.Combine(Application.dataPath, "OutGameFarm/Resources");
        string filePath = Path.Combine(folderPath, "tiles1.json");
        File.WriteAllText(filePath, json);
    }

    #endregion
}
#endif