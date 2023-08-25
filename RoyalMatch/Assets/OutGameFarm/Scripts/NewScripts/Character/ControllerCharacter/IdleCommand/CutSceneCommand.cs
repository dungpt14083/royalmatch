using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Command này có thể tạo bằng thủ công lệnh:::chỉ cần truyền cutscene và info vào:::
//EXCUTE KHÁC EXECUTE INSTANE Ở CHỖ SAU :::MỘT CÁI EXCUTEINSTANCE SẼ CHẠY HÀM COMPLETE LUÔN CÒN CÁI KIA THÌ CHỜ ĐẾN KHI XONG MS CHẠY HÀM COMPLETE
public abstract class CutSceneCommand
{
    protected CutScene cutScene;
    public CutsceneCommandInfo CommandInfo;

    public static CutSceneCommand CreateCommand(CutScene cutscene, CutsceneCommandInfo info)
    {
        string typeName = info.Name;
        Type type = Type.GetType(typeName);

        if (type == null)
        {
            typeName = info.Name + "Command";
            type = Type.GetType(typeName);
        }

        CutSceneCommand command = (CutSceneCommand)Activator.CreateInstance(type);
        command.Set(cutscene, info);
        return command;
    }

    public CutSceneCommand()
    {
    }

    public CutSceneCommand(CutsceneCommandInfo commandInfo)
    {
        this.CommandInfo = commandInfo;
    }

    private void Set(CutScene cutscene, CutsceneCommandInfo info)
    {
        this.cutScene = cutscene;
        this.CommandInfo = info;
    }

    public virtual void OnCreate()
    {
    }

    public void Execute(bool instant)
    {
        if (instant)
        {
            ExecuteInstant();
        }
        else
        {
            Execute();
        }
    }

    public bool IsAllRequirementsCompleted(HashSet<int> completedCommands)
    {
        if (this.CommandInfo.PreviousCommands == null) return true;
        List<int> previousCommands = this.CommandInfo.PreviousCommands;

        foreach (int commandId in previousCommands)
        {
            if (!completedCommands.Contains(commandId))
            {
                return false;
            }
        }

        return true;
    }

    public abstract void Execute();
    public abstract void ExecuteInstant();
    public abstract void OnSkip();

    public virtual void OnDiscard()
    {
    }

    public abstract void OnCancel();

    protected void Complete()
    {
        cutScene.CompleteCommand(this);
    }
}