using UnityEngine;

public class PropertiesFile : PropertiesDictionary
{
    public PropertiesFile(string fileName)
    {
        //Resources.Load<TileBase>(text + "white tile")
        //LOAD TỪ LOCAL LÊN VÀ TỪ ĐÓ SẼ LOAD FROMASSET::
        var text = LoadFromAsset(fileName);
        _data = Parser.ParsePropertyFileFormat(text);
        Initialize();
    }

    //LOADFILE.PROPETIES LÀ LOAD LÊN LẤY TEXT
    private string LoadFromAsset(string assetName)
    {
        //var tmp = "Config\\";
        string path = assetName;//+ ".txt";
        TextAsset textAsset = Resources.Load<TextAsset>(path);
        if (textAsset == null)
        {
            Debug.LogErrorFormat("Unable to open TextAsset {0}.properties.", assetName);
            return string.Empty;
        }
        return textAsset.text;
    }
}