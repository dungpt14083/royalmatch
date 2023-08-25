using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CHỈ CÓ TÁC DỤNG NHÉT COMMAND VÀO TRONG NÀY::LÀ DATABSE LOCAL
//NHÉT COMMAND VÀ NAME CỦA CUTSCENE VÀO::
[Serializable]
public class CutSceneInfo
{
    public int Id;
    public int UnityId;
    public string Name;
    
    public List<CutsceneCommandInfo> Commands;
    //CUTSCENE MỚI SẼ CHỈ CẦN ĐỂ TRUY XUẤT REQUIRMENT ĐIỀU KIỆN KÍCH HOẠT:::
    public List<RequirementInfo> Requirements;
    
    public static CutSceneInfo CreateInOrder(string name, List<CutsceneCommandInfo> commands)
    {
        CutSceneInfo cutsceneInfo = new CutSceneInfo();
        cutsceneInfo.Name = name;
        cutsceneInfo.Commands = commands;
        return cutsceneInfo;
    }
    
    //tRUYỀN PARAM VÀO LẤY RA LIST NHÂN VẬT LIÊN QUAN TRONG NÀY DUYỆT QUA LIST CUTSCENECOMMAND TÌM NHÂN VẬT TRONG CUTSCENE
    // public HashSet<int> GetInvolvedCharacters(StringStringDictionary characterParams)
    // {
    //     HashSet<int> involvedCharacters = new HashSet<int>();
    //     
    //     if (characterParams != null && characterParams.ContainsKey("-457238176"))
    //     {
    //         string[] paramValues = characterParams["-457238176"].Split(',');
    //         foreach (string paramValue in paramValues)
    //         {
    //             int characterId;
    //             if (int.TryParse(paramValue, out characterId))
    //             {
    //                 involvedCharacters.Add(characterId);
    //             }
    //         }
    //     }
    //     
    //     return involvedCharacters;
    // }
    
    
    
}
