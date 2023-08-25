using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(fileName = "CharacterAnimationComponent", menuName = "Scriptable Objects/CharacterAnimationComponent")]
public class CharacterAnimationComponent : ScriptableObject, ISerializationCallbackReceiver
{
    [Header("Speaking")] [SerializeField] private List<AnimationInfoCollection> SpeakingAnimationInfoList;

    [Header("Listening")] [SerializeField] private List<AnimationInfoCollection> ListeningAnimationInfoList;

    [Header("Regular")] [SerializeField] private List<AnimationInfoCollection> AnimationInfoList;

    //CÁC BIẾN LƯU TẠM ĐỂ ĐỠ PHẢI TRUY XUẤT NHIỀU QUÁ ĐƯỢC LƯU RA DICTIONAY CACHE LẠI R:::
    //MẤY CÁI LIST NÀY MỤC ĐÍCH ĐỂ CHO VIC SINH RA RANDOM CLIP 
    private Dictionary<string, AnimationInfo[]> _speakingAnimationInfoListCache;

    private Dictionary<string, AnimationInfo[]> _listeningAnimationInfoListCache;

    private Dictionary<string, AnimationInfo[]> _animationInfoListCache;

    private Dictionary<string, AnimationClip> _animationCacheList;

    private Dictionary<string, AudioClip> _soundCacheList;

    private bool _isDummy;

    public void Init()
    {
        // Khởi tạo các cache và dịch vụ liên quan
        _speakingAnimationInfoListCache = CreateAnimationInfoListCache(SpeakingAnimationInfoList);
        _listeningAnimationInfoListCache = CreateAnimationInfoListCache(ListeningAnimationInfoList);
        _animationInfoListCache = CreateAnimationInfoListCache(AnimationInfoList);
        _animationCacheList = CreateAnimationCacheList();
        _soundCacheList = CreateSoundCacheList();
    }

    private Dictionary<string, AnimationClip> CreateAnimationCacheList()
    {
        Dictionary<string, AnimationClip> cache = new Dictionary<string, AnimationClip>();
        foreach (var kvp in _speakingAnimationInfoListCache)
        {
            AnimationInfo[] animationInfos = kvp.Value;
            // Đưa các AnimationClip từ AnimationInfo vào _animationCacheList
            foreach (var animationInfo in animationInfos)
            {
                if (animationInfo != null && animationInfo.AnimationReference != null)
                {
                    cache[animationInfo.animationName] = animationInfo.AnimationReference;
                }
            }
        }

        // Duyệt qua các AnimationInfo trong _listeningAnimationInfoListCache
        foreach (var kvp in _listeningAnimationInfoListCache)
        {
            AnimationInfo[] animationInfos = kvp.Value;
            // Đưa các AnimationClip từ AnimationInfo vào _animationCacheList
            foreach (var animationInfo in animationInfos)
            {
                if (animationInfo != null && animationInfo.AnimationReference != null)
                {
                    cache[animationInfo.animationName] = animationInfo.AnimationReference;
                }
            }
        }

        // Duyệt qua các AnimationInfo trong _animationInfoListCache
        foreach (var kvp in _animationInfoListCache)
        {
            AnimationInfo[] animationInfos = kvp.Value;

            // Đưa các AnimationClip từ AnimationInfo vào _animationCacheList
            foreach (var animationInfo in animationInfos)
            {
                if (animationInfo != null && animationInfo.AnimationReference != null)
                {
                    cache[animationInfo.animationName] = animationInfo.AnimationReference;
                }
            }
        }

        return cache;
    }

    private Dictionary<string, AudioClip> CreateSoundCacheList()
    {
        Dictionary<string, AudioClip> cache = new Dictionary<string, AudioClip>();
        // Thêm các audio clip vào cache theo nhu cầu
        return cache;
    }

    public void OnAfterDeserialize()
    {
        Init();
    }

    public void OnBeforeSerialize()
    {
        //Init();
    }

    //truyền list muốn truy ập vào tạo dicnary cho toàn bộ và truy cập ở dưới:::
    private Dictionary<string, AnimationInfo[]> CreateAnimationInfoListCache(
        List<AnimationInfoCollection> infoCollections)
    {
        Dictionary<string, AnimationInfo[]> cache = new Dictionary<string, AnimationInfo[]>();

        foreach (var collection in infoCollections)
        {
            string key = collection.Name;
            cache[key] = collection.AnimationInfos;
        }

        return cache;
    }

    public AnimationInfo GetRandomSpeakingAnimationByKey(string key)
    {
        AnimationInfo[] animations;
        if (_speakingAnimationInfoListCache.TryGetValue(key, out animations))
        {
            int index = Random.Range(0, animations.Length);
            return animations[index];
        }

        return null;
    }

    public AnimationInfo GetRandomListeningAnimationByKey(string key)
    {
        AnimationInfo[] animations;
        if (_listeningAnimationInfoListCache.TryGetValue(key, out animations))
        {
            int index = Random.Range(0, animations.Length);
            return animations[index];
        }

        return null;
    }

    public AnimationInfo GetRandomAnimationByKey(string key)
    {
        AnimationInfo[] animations;
        if (_animationInfoListCache.TryGetValue(key, out animations))
        {
            int index = Random.Range(0, animations.Length);
            return animations[index];
        }

        return null;
    }

    public AnimationInfo GetAnimationFromDictionary(Dictionary<string, AnimationInfo[]> animationDictionary, string key)
    {
        AnimationInfo[] animations;
        if (animationDictionary.TryGetValue(key, out animations))
        {
            int index = Random.Range(0, animations.Length);
            return animations[index];
        }

        return null;
    }

    public AnimationInfo[] GetAnimationListByKey(string key)
    {
        AnimationInfo[] animations;
        if (_animationInfoListCache.TryGetValue(key, out animations))
        {
            return animations;
        }

        return null;
    }

    public bool IsPlayingByType(string key, string clipName)
    {
        // Thực hiện kiểm tra logic phát animation clip (nếu cần)
        return false;
    }

    public void SetIsDummy(bool isDummy)
    {
        _isDummy = isDummy;
    }

    public AnimationClip GetCharacterAnimationClip(string label)
    {
        AnimationClip clip;
        if (_animationCacheList.TryGetValue(label, out clip))
        {
            return clip;
        }

        // Nếu không tìm thấy trong cache, lấy từ các nguồn khác (nếu cần)

        return null;
    }

    public AudioClip GetCharacterAnimationSound(string label)
    {
        AudioClip sound;
        if (_soundCacheList.TryGetValue(label, out sound))
        {
            return sound;
        }

        // Nếu không tìm thấy trong cache, lấy từ các nguồn khác (nếu cần)

        return null;
    }
}