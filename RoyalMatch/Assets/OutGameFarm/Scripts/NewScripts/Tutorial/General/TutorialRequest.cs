using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialRequest
{
    private const string TutorialTypeKey = "TutorialType";

    private const string TutorialDataKey = "TutorialData";

    public TutorialType TutorialType { get; private set; }

    //Từng tutorial sẽ có data riêng data đi kèm với request mở tutorial tạm bỏ qua::
    public ITutorialData TutorialData { get; private set; }

    public TutorialRequest(TutorialType tutorialType)
    {
        TutorialType = tutorialType;
    }

    public TutorialRequest(TutorialType tutorialType, ITutorialData tutorialData)
    {
        TutorialType = tutorialType;
        TutorialData = tutorialData;
    }
}