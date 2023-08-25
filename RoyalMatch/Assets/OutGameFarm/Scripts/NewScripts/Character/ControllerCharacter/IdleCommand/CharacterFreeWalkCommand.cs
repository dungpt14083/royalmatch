using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFreeWalkCommand : CutSceneCommand
{
    private CharacterManagerView _characterManager;
    private Vector3 _destination;
    private Character _character;


    public override void OnCreate()
    {
        _characterManager = CharacterManagerView.Instance;
        _destination = ExtensionUtils.GetVector3Parameter(CommandInfo.Parameters, "position");
        _character =
            _characterManager.GetCharacter(ExtensionUtils.GetIntParameter(CommandInfo.Parameters, "characterId"));
    }

    public void SetDestination(Vector3 destination, Action onComplete)
    {
        _character.SetDestination(destination, onComplete);
    }

    //Chỉ khi di chuyển xong với complete command ::nhưng do lô tạo lệnh chưa được kiểm soát vị trí có thể i tới nên sẽ sinh lỗi tạm thời xử lí ở đây
    //ĐẦU TIÊN LÀ KIỂM SOÁT VỊ TRÍ K HỢP LỆ 
    private void OnAgentMoveCompleted()
    {
        this.Complete();
    }

    //khi skip howajc cancel command thì sẽ cancesl destination//thì bọn cancel này phi invoke sự kiện agentmovecompleted về?????thì mi kết thúc command này
    public override void OnSkip()
    {
        _character.CancelDestination();
    }

    public override void OnCancel()
    {
        _character.CancelDestination();
    }


    public override void Execute()
    {
        Transform characterTransform = _character.transform;
        bool shouldDisplayText = this.ShouldDisplayText();

        //ExecuteInstant();

        //NẾU NHƯ MÀ PATH TỚI K CÓ VÀ ĐƯỢC DUYỆT BÊN MAINCHARACTERCLOCKTRACKER RỒI THÌ CHỈ CẦN CHẠY WRAP
        UnityEngine.AI.NavMeshPath navMeshPath = new UnityEngine.AI.NavMeshPath();
        if (NavMeshPathExtensions.AssignPath(navMeshPath, characterTransform.position,
                _destination))
        {
            float pathLength = NavMeshPathExtensions.GetPathLength(navMeshPath);
            //Khoảng cách lớn thì tốc biến
            if (pathLength > 10.0f)
            {
                ExecuteInstant();
            }
            else
            {
                SetDestination(_destination, OnAgentMoveCompleted);
                return;
            }
            //Complete();
        }
        
        
        //NẾU NHƯ MÀ PATH TỚI K CÓ VÀ ĐƯỢC DUYỆT BÊN MAINCHARACTERCLOCKTRACKER RỒI THÌ CHỈ CẦN CHẠY WRAP
        ExecuteInstant();

        
        //ĐÃ KIỂM SOÁT NAVIGATION BỞI NẾU CANCEL ỞI HÀNH ĐỘNG KHÁC LÀ CANCEL RỒI
        //CÒN COMPLETE KHI MÀ SETDESSTINATION ĐỂ NÓ TỰ CHẠY TỚI :: ĐIỀU KIỆN TẠO PATH PHẢI HỢP LỆ NÊN K LO LÀ SẼ BỊ CHƯA TdI dÍCH
        //Complete();
    }

    //NẾU THỰC THI NGAY TỨC THF THÌ SẼ SETPOSSITION//đang k xài
    public override void ExecuteInstant()
    {
        _character.SetPosition(_destination);
        Complete();
    }


    //SỐ LAAFN BẤM QUÁ NHIỀU THÌ SẼ SHOW TEXT RẰNG NÊN BẤM CHẬM LẠI:::
    private bool ShouldDisplayText()
    {
        // if(this._character._showingSpeechBalloonWithText == true)
        // {
        //     return true;
        // }
        // if(this._pressCount > 5)
        // {
        //     return true;
        // }

        return false;
    }
}