using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Data base local về commandinfo chư thông tin
//CHO VIEC chứa PARAM MÀ THÔI:::
[Serializable]
public class CutsceneCommandInfo 
{
    public int CommandId;

    public string Name;

    public List<int> PreviousCommands;

    public List<ParameterInfo> Parameters;

    [Obsolete] public bool Parallel;

    public CutsceneCommandInfo()
    {
        PreviousCommands = new List<int>();
    }

    public CutsceneCommandInfo(List<ParameterInfo> parameters, string name)
    {
        PreviousCommands = new List<int>();
        Parameters = parameters;
        Name = name;
    }

    public CutsceneCommandInfo Clone()
    {
        var clonedCommand = new CutsceneCommandInfo();
        clonedCommand.Name = this.Name;
        clonedCommand.CommandId = this.CommandId;
        clonedCommand.PreviousCommands = new List<int>(this.PreviousCommands);
        clonedCommand.Parameters = new List<ParameterInfo>();

        foreach (var parameter in this.Parameters)
        {
            var clonedParameter = new ParameterInfo(null, null, parameter.GlobalName);
            clonedCommand.Parameters.Add(clonedParameter);
        }

        return clonedCommand;
    }
}