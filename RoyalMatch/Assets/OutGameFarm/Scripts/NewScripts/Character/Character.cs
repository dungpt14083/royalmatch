using System;
using System.Collections;
using System.Collections.Generic;
using Animancer;
using DG.Tweening;
using EasyButtons;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Character : MonoBehaviour
{
    [SerializeField] public NavMeshAgent unityNavMeshAgent;
    [SerializeField] public CharacterAgentController agentController;
    [SerializeField] private NamedAnimancerComponent animComponent;
    [SerializeField] public CharacterAnimationComponent CharacterAnimationComponent;
    [SerializeField] private Transform neckTransform;
    [SerializeField] private Transform animationItemParent;
    [SerializeField] private Transform handTransform;

    //CHO VIỆC NÓ LÀ AI TRONG HỘI THOẠI LÀ PHẢI OR TRÁI+
    public int characterId;
    private int _adventureId;

    private string _idleState = "IdleCharacter";
    private string _moveClipName = "RunCharacter";

    public CharacterInfo CharacterInfo;
    public UserCharacterPositionData CharacterData;

    private Action _onDestinationReached;
    private bool _isWarping;
    private Vector3 _rawDestination;
    private float _moveTime;
    private AnimancerState _currentState;


    public virtual void Start()
    {
        agentController.Init();
        //Tạm fake cái này lên:::
        CharacterManagerView.Instance.SetCharacter(characterId, this);
    }

    public void ResetCharacter()
    {
        this.CancelDestination();
        AnimancerState tmpAnimancerState = PlayIdle();
    }

    //khi vào game sẽ init 
    public void Init(CharacterInfo characterInfo, UserCharacterPositionData data)
    {
        this.CharacterInfo = characterInfo;
        this.CharacterData = data;
        this.CheckIdleState();
    }

    public AnimancerState PlayIdle()
    {
        AnimationInfo animationInfo = CharacterAnimationComponent.GetRandomAnimationByKey(_idleState);
        //AnimationClip animationClip = CharacterAnimationComponent.GetCharacterAnimationClip(CharacterAnimationComponent.SpeakingAnimationInfoList);
        if (animationInfo != null && animationInfo.AnimationReference != null)
        {
            AnimancerState stateAnimation = animComponent.Play(animationInfo.AnimationReference);
            return stateAnimation;
        }

        return null;
    }

    private float GetRemainingDistance()
    {
        return NavMeshAgentExtensions.GetRemainingDistance(unityNavMeshAgent);
    }

    public void CheckIdleState()
    {
        if (this.CharacterData.idleState != null)
        {
            _idleState = this.CharacterData.idleState;
        }

        AnimancerState tmpState = this.PlayIdle();
    }

    public void SetIdleState(string idleState)
    {
        _idleState = idleState;
        Animancer.AnimancerState tmpState = PlayIdle();
    }

    public void SetMoveClipName(string moveClipName)
    {
        this._moveClipName = moveClipName;
    }

    public void SetMoveSpeed(float speed)
    {
        this.unityNavMeshAgent.speed = speed;
    }

    public float GetMoveSpeed()
    {
        if (this.unityNavMeshAgent != null)
        {
            return this.unityNavMeshAgent.speed;
        }

        return this.unityNavMeshAgent.speed;
    }

    //Đây là wrap:::
    public void SetPosition(UnityEngine.Vector3 position)
    {
        unityNavMeshAgent.Warp(position);
        //this.unityNavMeshAgent.nextPosition = position;
        //CancelDestination();
    }

    public Tween FadeIn()
    {
        return null;
    }

    public Tween FadeOut(Action onComplete = null)
    {
        return null;
    }

    public Tween RotateTo(float rotation)
    {
        Tween rotateTween = transform.DORotate(new Vector3(0f, rotation, 0f), 1f);
        return rotateTween;
    }

    public void SetRotation(float rotation)
    {
        Vector3 rotationAxis = Vector3.up;
        Quaternion quaternion = Quaternion.AngleAxis(rotation, rotationAxis);
        transform.rotation = quaternion;
    }

    public Tween LookAt(Vector3 target)
    {
        Vector3 direction = target - transform.position;
        direction.y = 0f;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        Tween rotationTween = transform.DORotateQuaternion(targetRotation, 1f);
        return rotationTween;
    }

    public AnimancerState PlayMove(string clipName)
    {
        AnimationInfo animationInfo = this.CharacterAnimationComponent.GetRandomAnimationByKey(clipName);
        if (animationInfo == null || animationInfo.AnimationReference == null) return null;
        AnimancerState animancerState = this.animComponent.Play(animationInfo.AnimationReference);
        return animancerState;
    }

    public AnimancerState Play(string clipName)
    {
        AnimationInfo animationInfo = this.CharacterAnimationComponent.GetRandomAnimationByKey(clipName);
        if (animationInfo == null || animationInfo.AnimationReference == null) return null;
        AnimancerState animancerState = this.animComponent.Play(animationInfo.AnimationReference);
        return animancerState;
    }

    public AnimancerState PlayClip(AnimationClip clip)
    {
        if (clip == null) return null;
        AnimancerState animancerState = this.animComponent.Play(clip);
        //this.AnimancerComponent.Time = null;
        return animancerState;
    }


    //DÀNH CHO BỌN SAU::
    public bool IsPlayingByType(string type)
    {
        var tmpState = animComponent.States.Current;
        if (tmpState == null) return false;
        //liên quan cùng tên aniamtion đi còn cái khác tính sau
        return tmpState.Clip.name == type;
    }

    //SỰ KIỆN KHI TẠO XONG NHÂN VẬT THÌ SẼ SET VỊ TRÍ VÀ GÓC XOAY:::
    private void OnCharacterCreationFinished(bool unusedBool)
    {
        //Khả nwang là nhân vật chính thì bỏ qua
        if (this.characterId == 1)
        {
            return;
        }

        this.SetPosition(CharacterData.position);
        this.SetRotation(UnityEngine.Random.Range(90, 180));
    }

    public bool CanWalkToDestination(UnityEngine.Vector3 destination)
    {
        UnityEngine.AI.NavMeshPath path = new UnityEngine.AI.NavMeshPath();
        bool pathFound = NavMeshPathExtensions.AssignPath(path, this.transform.position, destination, 0);

        if (!pathFound || path.status == UnityEngine.AI.NavMeshPathStatus.PathComplete)
        {
            return false;
        }

        return true;
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause == false)
        {
            return;
        }

        UpdatePositionData();
    }

    private void UpdatePositionData()
    {
        //GỌI VÀO ĐẨY DATA DIRTY VÀO CHARACTER VÀ TỪ ĐÓ SẼ GỌI TỚI QUẢN LÍ DATA LƯU 1 CÁI
        CharacterData.position = transform.position;
    }

    public AnimationClip GetCharacterAnimationClip(string label)
    {
        return CharacterAnimationComponent.GetCharacterAnimationClip(label);
    }

    private bool _wasMoving = false;

    public void RotateToMovementDirection(Vector3 speed)
    {
        if (speed.sqrMagnitude > 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(speed);
            transform.rotation = targetRotation;
        }
    }

    //KHI ĐÃ ĐẠT ĐƯỢC ĐÍCH thì invoke sự kện callback
    private void DestinationReached()
    {
        if (_onDestinationReached == null) return;
        //this.unityNavMeshAgent.speed = 0;
        this.unityNavMeshAgent.ResetPath();
        //this.unityNavMeshAgent.isStopped = true;
        _isWarping = false;
        _currentState = PlayIdle();
        _onDestinationReached.Invoke();
    }

    //Trong character update chạy và check đến đích chưa::
    //NẾU NÓ K TỚI ĐÍCH THÌ BỊ THẰNG KHÁC HỦY LỆNH KHI XÀI LỆNH KHSAC:::
    private void CheckDestinationReached()
    {
        if (this.unityNavMeshAgent.pathPending || _onDestinationReached == null || unityNavMeshAgent.isStopped)
        {
            //Debug.LogError("Rơi vào trường hợp navigtion stop+ PATH ĐANGpending");
            return;
        }


        Vector3 currentPosition = this.transform.position;
        Vector3 destination = _rawDestination;
        currentPosition.y = 0;
        destination.y = 0;
        float distanceToDestination = Vector3.Distance(currentPosition, destination);
        //Debug.LogError("distance"+distanceToDestination.ToString());
        float stoppingDistance = this.unityNavMeshAgent.stoppingDistance;

        // Debug.LogError("Current Position: " + currentPosition.ToString() + ", Destination: " + destination.ToString() +
        //                ", Distance: " + distanceToDestination.ToString());

        //tức là thời điểm xét nó cmnr tới điểm dng rồi nên nó invoke dừng cmnr game luôn::
        if (distanceToDestination <= 0.5f)
        {
            //Debug.LogError("Destination???????");
            this.DestinationReached();
        }
    }


    public void SetDestination(Vector3 destination, Action onDestinationReached, float warpInsteadOfWalkDistance = 15)
    {
        _onDestinationReached = null;
        unityNavMeshAgent.isStopped = true;
        //unityNavMeshAgent.speed = 0f;
        unityNavMeshAgent.ResetPath();
        _onDestinationReached = onDestinationReached;
        destination.y = 0;
        _rawDestination = destination;
        if (warpInsteadOfWalkDistance > 0f)
        {
            var tmp = unityNavMeshAgent.transform.position;
            tmp.y = 0;
            float distanceToDestination = Vector3.Distance(unityNavMeshAgent.transform.position, destination);
            if (distanceToDestination > warpInsteadOfWalkDistance)
            {
                unityNavMeshAgent.Warp(destination);
                _isWarping = true;
                //unityNavMeshAgent.isStopped = false;
                CheckDestinationReached();
            }
            else
            {
                _isWarping = false;
                unityNavMeshAgent.SetDestination(destination);
                //unityNavMeshAgent.isStopped = false;
                _currentState = PlayMove(_moveClipName);
                CheckDestinationReached();
            }
        }
        //enabled = true;
    }

    //Cancel command là cancel việc di chuyển navigation 
    //cancel thì k cần phát ondesstination làm gì vì nó t 
    public void CancelDestination()
    {
        //Debug.LogError("da cancel move trong này");
        _moveTime = 0f;
        //unityNavMeshAgent.speed = 0f;
        _onDestinationReached = null;
        if (unityNavMeshAgent.isActiveAndEnabled)
        {
            unityNavMeshAgent.ResetPath();
            //unityNavMeshAgent.isStopped = true;
        }

        _isWarping = false;
        _currentState = PlayIdle();
        //enabled = false;
    }


    private void Update()
    {
        if (_showingSpeechBalloon)
        {
            Vector3 tmpP = GetSpeechBalloonPosition(_isSpeakingRight);
            var canvasP = Camera.main.WorldToScreenPoint(this.transform.position);
            SpeechBalloonManager.Instance.UpdatePosition(canvasP);
        }


        if (this.unityNavMeshAgent.isActiveAndEnabled != false)
        {
            if (this.unityNavMeshAgent.isOnNavMesh == false)
            {
                return;
            }
        }

        if (unityNavMeshAgent.isStopped || unityNavMeshAgent.pathPending || !unityNavMeshAgent.hasPath ||
            _onDestinationReached == null)
            return;

        var tmpSpeed = unityNavMeshAgent.velocity;
        RotateToMovementDirection(tmpSpeed);

        CheckDestinationReached();

        if (!_showingSpeechBalloonWithText) return;
        UnityEngine.Vector3 tmpPosition = GetSpeechBalloonPosition(_isSpeakingRight);
        var canvasPosition = Camera.main.WorldToScreenPoint(this.transform.position);
        this._speechBalloonWithText.UpdatePosition(canvasPosition);
        
        
        
        
        
    }

    
    
    
    
    
    
    
    
    #region CHO VIỆC SPEECH NÓI CHUYỆN:::NÓ SẼ DỰA VO SPEECH VÀ ẤY SPEED

    [SerializeField] private AnimationClip singleSpeak;

    private SpeechBalloonWithText _speechBalloonWithText;
    private bool _showingSpeechBalloon = false;
    private bool _showingSpeechBalloonWithText;
    private SpeechBalloonWithTextData _speechBalloonWithTextData;


    #region SHOW BALLOOON WITH TEXT:::TRUYỀN THAY VÌ DIALOGUE CUỘC HỘI THOẠI THÌ TRUYỀN THẲNG VÀO TRONG NÀY :::

    //NGHE SỰ KIỆN SHOWSPEECHBALLONWITH TEXT VỚI DATA Ở TRONG Ể MÀ XÀI
    //TRONG NÀY CÓ DATA CHATER TEXT VÀ NGAY LẬP TỨC???
    public void OnShowSpeechBalloonWithText(SpeechBalloonWithTextData data)
    {
        if (data.character != this.characterId)
        {
            return;
        }

        _speechBalloonWithTextData = data;
        //TRUE NGAY LẬP TỨC THÌ SẼ CHẠY
        if (data.isImmediate)
        {
            float eulerAnglesY = this.transform.rotation.eulerAngles.y;
            CheckSpeechBalloonWithTextImmediate(data.text, eulerAnglesY);
        }
        //CÁI NÀY CÓ TRƯỜNG HỢP THỰC HIỆN SAU CHỜ QUEUE QUẢN LÍ CỦA MAP TÍNH sau:::
    }

    //TRUYỀN TEXT VÀO TRONG V GÓC XOAY ĐỂ NCH::
    //LẤ ANIMATION CLIP
    private void CheckSpeechBalloonWithTextImmediate(string text, float rotation)
    {
        Vector3 balloonPosition = GetSpeechBalloonPosition(isRight: true);


        //VỊ TRÍ TỪ NHÂN VẬT RA NGOÀI MÀN HÌNH CỦA NGƯỜI CHƠI ĐỂ SHOW LÊN TEXT
        var canvasP = Camera.main.WorldToScreenPoint(this.transform.position);

        AnimationInfo[] listAnimationClip =
            this.CharacterAnimationComponent.GetAnimationListByKey(key: CharacterAnimationKeys.Idle);
        AnimationClip clip = this.CharacterAnimationComponent.GetCharacterAnimationClip("");
        if (animComponent.IsPlayingClip(clip)) return;

        //ĐANG KHÔNG TRONG TÍNH TOÁN PATH THÌ SẼ 
        if (!unityNavMeshAgent.pathPending)
        {
            bool isPlaying = this.animComponent.IsPlaying();
            if (isPlaying)
            {
                //XOAY VÀ TRẢ CALLBACK SAU ĐÓ
                var tween = RotateTo(rotation);
                tween.onComplete += () => ShowSpeechBalloonWithText(canvasP, IsLookingRight(), text);
            }
        }

        ShowSpeechBalloonWithText(canvasP, IsLookingRight(), text);
    }

    public void ShowSpeechBalloonWithText(Vector3 screenPosition, bool isRight, string text)
    {
        if (_speechBalloonWithText == null)
        {
            _speechBalloonWithText = SpeechBalloonWithTextManager.Instance.GetSpeechBalloonWithText();
        }

        _speechBalloonWithText.ShowSpeechBalloonWithText(screenPosition, isRight, text, characterId);
    }

    //Kia là chơi ngay lập tức còn đây là đưa vào MAPACTIONQUEUE???


    //SỰ KIỆN ẨN BALLOONTEXT HIDE
    private void OnSpeechBalloonWithTextHide(SpeechBalloonWithTextData data)
    {
        if (!this.gameObject.activeInHierarchy) return;
        if (data.character != characterId) return;
        _speechBalloonWithText.HideImmediate();
        _speechBalloonWithText = null;
        if (!unityNavMeshAgent.isStopped) return;
        if ((this.IsPlayingByType(_idleState)) == false)
        {
            return;
        }

        PlayIdle();
    }

    //ẤN NGAY LAP TỨC::
    public void HideSpeechBalloonWithTextImmediate()
    {
        if (_speechBalloonWithText == null) return;
        //ẤN SPEECHBALLONWITHTEXT NGAY LẬP TỨC
        _speechBalloonWithText.HideImmediate();
        _speechBalloonWithText = null;
        _showingSpeechBalloonWithText = false;

        //NẾU NHƯ MÀ ISTOPPED THÌ MỚI CHẠY TIẾP  K THÌ DỪNG Ở ĐÂY
        if (!unityNavMeshAgent.isStopped) return;

        //NẾU DỪNG RỒI THÌ CHẠY IDLE::
        var currentState = this.animComponent.States.Current;
        var currentAnimationClip = currentState.Clip;

        //NẾU SINGLESPEED NÓI MỘT MÌNH
        if (currentAnimationClip != singleSpeak) return;
        PlayIdle();
    }

    #endregion


    #region HIDE SPEECHBALLOONHIDE KHÔNG CÓ TEXT //DATA CỦA NÓ CHỈ CÓ CHARACTER ID

    private bool _isSpeakingRight;

    private void OnSpeechBalloonHide(SpeechBalloonSpeakerChangedData data)
    {
        if (!_showingSpeechBalloon) return;
        if (this.characterId == data.character) return;
        this._showingSpeechBalloon = false;
        if (this.unityNavMeshAgent.isStopped == false) return;
        PlayIdle();
    }

    public void OnSpeechStarted(SpeechStartData data)
    {
        SpeechInfo speechInfo;
        DialogueInfo dialogueInfo;
        if (!this.gameObject.activeInHierarchy) return;
        if (data.DialogueInfo == null) return;
        dialogueInfo = data.DialogueInfo;
        if (data.SpeechIndex >= dialogueInfo.Speeches.Count) return;
        speechInfo = data.DialogueInfo.Speeches[data.SpeechIndex];

        if (unityNavMeshAgent.isStopped && !_showingSpeechBalloon) return;


        if (IsListeningCharacter(speechInfo))
        {
            var animKey = GetSpeechAnimKey(speechInfo, IsLeftCharacterOfSpeech(speechInfo));
            PlayListen(animKey);
            return;
        }

        if (IsSpeakingCharacter(speechInfo))
        {
            _isSpeakingRight = IsRightCharacterOfSpeech(speechInfo);
            Vector3 balloonPosition = GetSpeechBalloonPosition(_isSpeakingRight);
            PlaySpeak(speechInfo);
            var canvasPosition = Camera.main.WorldToScreenPoint(this.transform.position);
            SpeechBalloonManager.Instance.ShowSpeechBalloon(canvasPosition, _isSpeakingRight, characterId);
            this._showingSpeechBalloon = true;
            return;
        }

        // if (!this.unityNavMeshAgent.isStopped) return;
        // if (!dialogueInfo.DidCharacterSpokenBefore(characterId: this.characterId, speechIndex: data.SpeechIndex))
        // {
        //     return;
        // }

        //PlayIdle();
    }


    private bool IsLeftCharacterOfSpeech(SpeechInfo speechInfo)
    {
        return speechInfo.leftCharacterId == characterId;
    }

    private bool IsRightCharacterOfSpeech(SpeechInfo speechInfo)
    {
        return speechInfo.rightCharacterId == characterId;
    }

    private bool IsSpeakingCharacter(SpeechInfo speechInfo)
    {
        return (speechInfo.rightSpeaking && speechInfo.rightCharacterId == characterId) ||
               (!speechInfo.rightSpeaking && speechInfo.leftCharacterId == characterId);
    }

    private bool IsListeningCharacter(SpeechInfo speechInfo)
    {
        return (speechInfo.rightCharacterId == characterId && !speechInfo.rightSpeaking) ||
               (speechInfo.leftCharacterId == characterId && speechInfo.rightSpeaking);
    }

    private string GetSpeechAnimKey(SpeechInfo speechInfo, bool isLeftCharacter)
    {
        return isLeftCharacter ? speechInfo.leftCharacterAnimationKey : speechInfo.rightCharacterAnimationKey;
    }

    private bool HasSpeechAnimKey(SpeechInfo speechInfo, bool isLeftCharacter)
    {
        return isLeftCharacter
            ? string.IsNullOrEmpty(speechInfo.leftCharacterAnimationKey) && speechInfo.HasLeftCharacter()
            : string.IsNullOrEmpty(speechInfo.rightCharacterAnimationKey) && speechInfo.HasRightCharacter();
    }


    //CHƠI NÓI CHUYỆN THÌ NẾU KHÔNG CÓ NGƯỜI NGHE THÌ SẼ NÓI MỘT MÌNH K THÌ NÓI LẶP???
    public void PlaySpeak(SpeechInfo speechInfo)
    {
        // if (_showingSpeechBalloon)
        // {
        //     return;
        // }

        // if (!unityNavMeshAgent.isStopped)
        // {
        //     return;
        // }


        if ((speechInfo.rightSpeaking && !speechInfo.HasLeftCharacter()) ||
            (!speechInfo.rightSpeaking && !speechInfo.HasRightCharacter()))
        {
            PlaySingleSpeak();
        }
        else
        {
            PlaySpeakLoop(speechInfo);
        }
    }

    public void PlaySingleSpeak()
    {
        // if (_showingSpeechBalloon)
        // {
        //     return;
        // }
        //
        // if (!unityNavMeshAgent.isStopped)
        // {
        //     return;
        // }

        AnimationInfo tmpAnimationInfo =
            CharacterAnimationComponent.GetRandomAnimationByKey(key: CharacterAnimationKeys.SingleSpeak);
        if (tmpAnimationInfo == null || tmpAnimationInfo.AnimationReference == null) return;
        var animationClip = tmpAnimationInfo.AnimationReference;
        AnimancerState tmpState = animComponent.Play(animationClip);
    }

    //CHẠY NÓI CHUYỆN VỚI VIỆC LẶP ĐI LẶP LẠI?
    public void PlaySpeakLoop(SpeechInfo speechInfo)
    {
        // if (this.unityNavMeshAgent.isStopped == false)
        // {
        //     return;
        // }

        string animKey = GetSpeechAnimKey(speechInfo, !_isSpeakingRight);
        AnimationInfo animationInfo = this.CharacterAnimationComponent.GetRandomSpeakingAnimationByKey(animKey);
        if (animationInfo == null || animationInfo.AnimationReference == null) return;
        var animationClip = animationInfo.AnimationReference;
        AnimancerState state = animComponent.Play(animationClip);
        //ĐOẠN NAY NGHE SỰ KIỆN CỦA THẰNG KẾT THỨC ANIMATION CLIP RỒI CHẠY TIẾP À???
    }


    public void PlayListen(string clipName)
    {
        AnimationInfo animationInfo = this.CharacterAnimationComponent.GetRandomListeningAnimationByKey(clipName);
        if (animationInfo == null || animationInfo.AnimationReference == null) return;
        if ((this.animComponent.IsPlayingClip(animationInfo.AnimationReference)) != false)
        {
            return;
        }

        AnimancerState state = animComponent.Play(animationInfo.AnimationReference);
    }


    private Vector3 GetSpeechBalloonPosition(bool isRight = true)
    {
        return this.transform.position;
    }

    public bool IsLookingRight()
    {
        Vector3 eulerAngles = this.transform.rotation.eulerAngles;
        if (eulerAngles.y < 180)
        {
            return false;
        }

        return true;
    }

    public void OnDialogueFinish(DialogueInfo dialogueInfo)
    {
        if (!this.gameObject.activeInHierarchy) return;

        var tmpSpeeches = dialogueInfo.Speeches;
        for (int i = 0; i < tmpSpeeches.Count; i++)
        {
            if (tmpSpeeches[i].leftCharacterId != this.characterId &&
                tmpSpeeches[i].leftCharacterId != this.characterId)
                continue;
            if (!unityNavMeshAgent.isStopped) return;
            PlayIdle();
            break;
        }

        SpeechBalloonManager.Instance.HideSpeechBalloon();
    }

    #endregion


    #region TEST SHOW SPEECHBALLOON:::

    private void DebugShowSpeechBalloonWithText()
    {
        // UnityEngine.Vector3 val_1 = GetSpeechBalloonPosition(isRight:  true);
        // UnityEngine.Vector3 val_5 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = FarmMatch.Map.MapScene.Name.m_firstChar, y = val_2, z = val_3});
        // this.ShowSpeechBalloonWithText(screenPosition:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}, isRight:  this.IsLookingRight(), text:  "HEEEELP MEEE!!!");
    }

    private void DebugShowSpeechBalloon()
    {
        // UnityEngine.Vector3 val_1 = GetSpeechBalloonPosition(isRight:  true);
        // UnityEngine.Vector3 val_5 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = FarmMatch.Map.MapScene.Name.m_firstChar, y = val_2, z = val_3});
        // this._speechBalloonService.ShowSpeechBalloon(position:  new UnityEngine.Vector3(), isRight:  true, characterId:  this.CharacterId);
        // this._showingSpeechBalloon = true;
    }

    #endregion


    #region NGHE SỰ KIỆN ĐỂ CHẠY SHOW NÀY TỪ ĐÂU ĐÓ PHÁT RA::::

    private void OnEnable()
    {
        CutSceneSignals.SpeechStartSignal.AddListener(OnSpeechStarted);
        CutSceneSignals.DialogueFinishSignal.AddListener(OnDialogueFinish);
        CutSceneSignals.SpeechBalloonSpeakerChanged.AddListener(OnSpeechBalloonHide);
    }

    private void OnDisable()
    {
        if (_speechBalloonWithText != null)
        {
            this._speechBalloonWithText.HideImmediate();
        }

        _speechBalloonWithText = null;
        PlayIdle();

        CutSceneSignals.SpeechStartSignal.RemoveListener(OnSpeechStarted);
        CutSceneSignals.DialogueFinishSignal.RemoveListener(OnDialogueFinish);
        CutSceneSignals.SpeechBalloonSpeakerChanged.RemoveListener(OnSpeechBalloonHide);
    }

    #endregion


    #region ABILITYSHOW TEXT KHI TỰ ẤN VÀO CHÍNH MÌNH SHOWW LỜI LOẠI RANDOM

    //KHI MÀ ẤN XUỐNG NHỀU LẦN NÓ SẼ PHÁT RA KHI ẤN VÀO CHÍNH NÓ NÓ LẤY LỜI THOẠI RANDOM ĐỂ SHOW LÊN
    public virtual void OnMouseUpAsButton()
    {
    }

    #endregion

    #endregion
}