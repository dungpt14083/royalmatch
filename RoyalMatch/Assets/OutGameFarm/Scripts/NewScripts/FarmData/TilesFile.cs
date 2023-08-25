using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;

//NƠI CHỨA CÁC THỨ Ở TRONG NHƯ LÀ ISBUILDABLE ĐƯỢC LOAD LÊN TỪ JSON ĐƯỢC XUẤT RA JSON
public class TilesFile
{
    //LÀ KÍCH THƯỚC CỦA NGANG DỌC 80X80
    public int Height { get; private set; }
    public int Width { get; private set; }

    //MẢNG 2 CHIỀU VỊ TRÍ CÓ THỂ BUILD HAY KHÔNG 0 LÀ CÓ THỂ 1 LÀ K THỂ CHẲNG HẠN KẾT HỢP VỚI EXPANDER ĐỂ MÀ CHỖ NÀO CÓ THỂ BUILD
    public bool[,] IsBuildable { get; private set; }
    public bool Initialized { get; set; }
    private DataTile _data;

    public TilesFile(string jsonFileName)
    {
        Initialized = false;
        GetDataTile(jsonFileName);
        if (_data == null) return;
        IsBuildable = _convertJsonIntToBool();
    }

    private void GetDataTile(string jsonFileName)
    {
        LoadFromAsset(jsonFileName);
    }

    private void LoadFromAsset(string fileName)
    {
        TextAsset textAsset = Resources.Load<TextAsset>(fileName);
        if (textAsset == null)
        {
            Debug.LogErrorFormat("Unable to open TextAsset {0}.json.", fileName);
        }
        else
        {
            ParseAsset(textAsset);
            Resources.UnloadAsset(textAsset);
        }
    }

    private void ParseAsset(TextAsset asset)
    {
        DataTile dataTile = JsonConvert.DeserializeObject<DataTile>(asset.text);
        _data = dataTile;
        Initialized = true;
    }

    private Boolean[,] _convertJsonIntToBool()
    {
        bool[,] IsBuildable =
            new bool[_data.IsBuildable.GetLength(0), _data.IsBuildable.GetLength(1)];
        for (int i = 0; i < _data.IsBuildable.GetLength(0); i++)
        {
            for (int j = 0; j < _data.IsBuildable.GetLength(1); j++)
            {
                if (_data.IsBuildable[i, j] == 0)
                {
                    IsBuildable[i, j] = true;
                }
                else
                {
                    IsBuildable[i, j] = false;
                }
            }
        }

        return IsBuildable;
    }

    private bool[,] GetIsBuildable(Dictionary<string, object> json)
    {
        List<object> list = GetList(json, "isBuildable");
        int num = Width * 4;
        int num2 = Height * 4;
        bool[,] array = new bool[num, num2];
        int count = list.Count;
        for (int i = 0; i < count; i++)
        {
            int num3 = i / num;
            int num4 = i % num2;
            array[num3, num4] = (int)(double)list[i] == 1;
        }

        return array;
    }

    private List<object> GetList(Dictionary<string, object> json, string field)
    {
        try
        {
            return (List<object>)json[field];
        }
        catch (KeyNotFoundException)
        {
            throw new FormatException(string.Format("Json file does not contain {0} field!", field));
        }
        catch (InvalidCastException)
        {
            throw new FormatException(string.Format("Json file has unexpected type in {0} field!", field));
        }
    }
}