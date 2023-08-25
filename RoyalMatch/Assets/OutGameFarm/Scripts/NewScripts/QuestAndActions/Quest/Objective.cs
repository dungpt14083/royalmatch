using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MỤC TIÊU ???CHO TASK:::V ID CHO NÓ ID ĐỂ ĐI TỚI CÒN VALUE THÌ Ở NGOÀI KIA
[Serializable]
public class Objective
{
    public ObjectiveType ObjectiveType;
    public int IdInType;

    public Objective(ObjectiveType objectiveType, int idInType)
    {
        this.ObjectiveType = objectiveType;
        this.IdInType = idInType;
    }
}