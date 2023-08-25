using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//NCH THẰNG NÀY SẼ NHẬN CUTSCENEINFO VÀO ĐỂ TẠO CUTSCENE DATA CỦA NÓ TỪ DATA LOCAL::
//Nên mình truyền vào và fake là fake data:::
public class CutScene
{
    //KHÔNG C cái này hcawsc bỏ qua chỉ xét choi idlecommand
    public CutSceneInfo CutsceneInfo;
    public System.Collections.Generic.List<CutSceneCommand> IdleCommands;
    public System.Collections.Generic.List<CutSceneCommand> ActiveCommands;
    public System.Collections.Generic.HashSet<int> CompletedCommands;

    public Action OnComplete;
    private bool _skip;
    private bool _dirty;

    //kIỂM TRA XEM LỆNH NÀY LÀ LỆNH G???//các lệnh đạt requirement để chạy hay k nếu đạt thì mi đưa vo đây
    private static readonly HashSet<int> OnCreateCalledCommands = new HashSet<int>();


    //TRONG NÀY CONTROLLER NHÂN VẬT ĐANG DỂ GLOBALPARAMETER NULL:::
    public CutScene(CutSceneInfo cutsceneInfo, Dictionary<string, string> globalParameters)
    {
        CutsceneInfo = cutsceneInfo;
        IdleCommands = new List<CutSceneCommand>();
        ActiveCommands = new List<CutSceneCommand>();
        CompletedCommands = new HashSet<int>();
        OnComplete = null;
        this._skip = false;
        this._dirty = false;
        OnCreateCalledCommands.Clear();

        //DUYỆT QUA LIST COMMAND Ở TRONG CUTSCENEINFO ĐỂ MÀ TẠO COMMAND THẬT
        foreach (var commandInfo in cutsceneInfo.Commands)
        {
            CutSceneCommand command = CutSceneCommand.CreateCommand(this, commandInfo);
            this.IdleCommands.Add(command);
        }

        CallOnCreates();
        _dirty = true;
    }


    private void CallOnCreates()
    {
        OnCreateCalledCommands.Clear();

        foreach (var command in IdleCommands)
        {
            bool allRequirementsCompleted = command.IsAllRequirementsCompleted(CompletedCommands);
            if (allRequirementsCompleted && !OnCreateCalledCommands.Contains(command.CommandInfo.CommandId))
            {
                command.OnCreate();
                OnCreateCalledCommands.Add(command.CommandInfo.CommandId);
            }
        }
    }

    //kHI BỊ BẨN THÌ GỌI TỚI CHẠY NEXTCOMMANDS?
    public bool Update()
    {
        if (_skip)
        {
            return false;
        }

        //CHECK CÒN CÓ THỂ TIẾP TỤC K CÒN COMMAND CHỜ K 
        if (_dirty == false && ActiveCommands.Count <= 0)
        {
            return false;
        }

        if (_dirty)
        {
            _dirty = false;
            StartNextCommands();
        }

        return true;
    }

    public void StartNextCommands()
    {
        for (int i = IdleCommands.Count - 1; i >= 0; i--)
        {
            var command = IdleCommands[i];
            if (command.IsAllRequirementsCompleted(CompletedCommands))
            {
                IdleCommands.RemoveAt(i);
                ActiveCommands.Add(command);
                if (_skip) break;
                command.Execute();
            }
        }

        _skip = false;
        _dirty = false;
    }

    //csai này bỏ qua tạm k dng vì cutscenemanager chính vs có skip command
    public void Skip()
    {
        _skip = true;
        for (int i = 0; i < ActiveCommands.Count; i++)
        {
            ActiveCommands[i].OnCancel();
            ActiveCommands.Remove(ActiveCommands[i]);
        }
    }

    //cancel toàn bộ cutscene 
    public void Cancel()
    {
        _skip = true;
        for (int i = 0; i < ActiveCommands.Count; i++)
        {
            ActiveCommands[i].OnCancel();
        }
        
        for (int i = 0; i < IdleCommands.Count; i++)
        {
            IdleCommands[i].OnCancel();
        }

        ActiveCommands.Clear();
        IdleCommands.Clear();
    }

    //chỉ khi cái này thì mới chạy neexxt còn cancel là cancel
    public void CompleteCommand(CutSceneCommand cutsceneCommand)
    {
        this._dirty = true;
        ActiveCommands.Remove(cutsceneCommand);
        CompletedCommands.Add(cutsceneCommand.CommandInfo.CommandId);
    }

    public System.Collections.Generic.HashSet<int> GetInvolvedCharacters()
    {
        System.Collections.Generic.HashSet<int> involvedCharacters = new System.Collections.Generic.HashSet<int>();

        foreach (var tmp in OnCreateCalledCommands)
        {
            for (int j = 0; j < IdleCommands.Count; j++)
            {
                if (tmp == IdleCommands[j].CommandInfo.CommandId)
                {
                    int characterId =
                        ExtensionUtils.GetIntParameter(IdleCommands[j].CommandInfo.Parameters, "characterId");
                    if (characterId != -1)
                    {
                        involvedCharacters.Add(characterId);
                    }
                }
            }
        }

        return involvedCharacters;
    }
}