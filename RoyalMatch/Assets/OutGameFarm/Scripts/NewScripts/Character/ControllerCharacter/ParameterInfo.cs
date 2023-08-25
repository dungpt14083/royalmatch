using System;

//Sẽ chứa key value tham số mà thôi:::
[Serializable]
public class ParameterInfo
{
    public string Name;

    public string Value;

    public string GlobalName;

    public ParameterInfo()
    {
    }

    public ParameterInfo(string name, string value)
    {
        this.Name = name;
        this.Value = value;
    }

    public ParameterInfo(string name, string value, string globalName)
    {
        this.Name = name;
        this.Value = value;
        this.GlobalName = globalName;
    }
}