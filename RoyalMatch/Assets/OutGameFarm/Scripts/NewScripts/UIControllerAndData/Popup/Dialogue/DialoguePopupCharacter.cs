using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DialoguePopupCharacter : MonoBehaviour
{
    [SerializeField] private Image characterImage;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private GameObject nameGo;

    [SerializeField] private bool isLeft;
    //[SerializeField] private float RewindSpeed;


    private int _lastShownCharacterId;
    private string _lastShownEmotionIconId;
    private SpeechInfo _speechInfo;


    private void OnEnable()
    {
        CutSceneSignals.SpeechStartSignal.AddListener(OnSpeechStarted);
        CutSceneSignals.DialogueFinishSignal.AddListener(OnDialogueFinished);
    }

    private void OnDisable()
    {
        CutSceneSignals.SpeechStartSignal.RemoveListener(OnSpeechStarted);
        CutSceneSignals.DialogueFinishSignal.RemoveListener(OnDialogueFinished);
    }


    private void OnSpeechStarted(SpeechStartData data)
    {
        var tmpDialogueInfo = data.DialogueInfo;
        _speechInfo = tmpDialogueInfo.Speeches[data.SpeechIndex];

        //NẾU K PHẢI LÀ Ở TRONG CUỘC HỘI THOẠI CÓ TRÁI HOẶC PHẢI THÌ CHÍNH NÓ SẼ ẨN
        if (!IsCurrentCharacter(_speechInfo))
        {
            HideCharacter();
            return;
        }

        ShowCharacter();

        if (isLeft)
        {
            UpdateCharacterVisuals(_speechInfo.leftCharacterId, _speechInfo.leftCharacterPose);
            _lastShownCharacterId = _speechInfo.leftCharacterId;
        }
        else
        {
            _lastShownCharacterId = _speechInfo.rightCharacterId;
            UpdateCharacterVisuals(_speechInfo.rightCharacterId, _speechInfo.rightCharacterPose);
        }


        //NẾU K PHẢI MÌNH ĐANG NÓI THÌ LÀM MỜ ĐI THÔI CHỨ VẪN HIỆN :::
        if (!IsCurrentCharacterSpeaking(_speechInfo))
        {
            FadeCharacters(false);
            return;
        }
        //NẾU LÀ THẰNG NÓI CHUYỆN THÌ SẼ::làm mờ đi
        else
        {
            FadeCharacters(true);
        }

        //CHẠY ANIMATION DIỄN HOẠT DỰ TRÊN POSE BLA BLA
        AnimateCharacter(_speechInfo);
        UpdateBanners(_speechInfo);
    }


    //TƯ THẾ CHARACTER VÀ CHARACTER ID ĐỂ INVOKE VÀO TRONG TẠO VISUAL
    public void UpdateCharacterVisuals(int characterId, string characterPose)
    {
        //LẤY ẢNH TU ASSET ĐẨY VÀO:::
        //characterImage.sprite = null;
        this.nameText.text = CharacterManagerView.Instance.GetNameCharacter(characterId);
    }

    private void FadeCharacters(bool isShow)
    {
        Color tmpColor = new Color(1, 1, 1, 1f);
        if (!isShow)
        {
            tmpColor = new Color(1, 1, 1, 0.6f);
        }

        characterImage.color = tmpColor;
        nameGo.SetActive(false);
        // if (!speech.rightSpeaking)
        // {
        //     if (!isLeft)
        //     {
        //         if (!speech.HasRightCharacter())
        //         {
        //             return;
        //         }
        //         //CHẠY ANIMATION TỚI 
        //         // if(this.ImageRewindable != 0)
        //         // {
        //         //     goto label_4;
        //         // }
        //         //this.ImageRewindable.SetTarget(value:  null, speed:  null);
        //     }
        // }
    }

    private bool IsCurrentCharacter(SpeechInfo speech)
    {
        if (speech.HasLeftCharacter())
        {
            if (this.isLeft == true)
            {
                return true;
            }
        }

        if (speech.HasRightCharacter())
        {
            if (!this.isLeft)
            {
                return true;
            }
        }

        return false;
    }


    private bool IsCurrentCharacterSpeaking(SpeechInfo speech)
    {
        if (!IsCurrentCharacter(speech))
        {
            return false;
        }

        if ((speech.rightSpeaking && isLeft) || (!speech.rightSpeaking && !isLeft))
        {
            return false;
        }

        return true;
    }

    //AI NÓI THÌ MỚI HIỆN TÊN LÊN K THÌ SẼ K HIỆN:::UPDATE TÊN???????KHI NÓI CHUYÊNTHIJI SẼ CHỈ HIỆN TÊN CỦA NGƯỜI NÓI
    public void UpdateBanners(SpeechInfo speech)
    {
        if ((isLeft&&!speech.rightSpeaking)||(!isLeft&& speech.rightSpeaking))
        {
            this.nameGo.SetActive(true);
        }
        else
        {
            this.nameGo.SetActive(false);
        }
    }

    public void HideCharacter()
    {
        characterImage.gameObject.SetActive(false);
        nameGo.SetActive(false);
    }

    public void ShowCharacter(float speed = 1)
    {
        characterImage.gameObject.SetActive(true);
        //nameGo.SetActive(true);
    }

    private void AnimateCharacter(SpeechInfo speech)
    {
        // if (!speech.HasLeftCharacter())
        // {
        //     if (isLeft)
        //     {
        //         this.HideCharacter();
        //         return;
        //     }
        // }
        //
        // if (speech.HasRightCharacter())
        // {
        //     if (!isLeft)
        //     {
        //         this.HideCharacter();
        //         return;
        //     }
        // }
        //
        // this.ShowCharacter();
    }

    public void OnDialogueFinished(DialogueInfo info)
    {
        this.HideCharacter();
    }
}