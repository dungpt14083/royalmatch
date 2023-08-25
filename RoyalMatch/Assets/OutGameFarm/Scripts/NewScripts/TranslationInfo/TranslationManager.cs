using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//SẼ CÓ 1 CÁI LAGUAGE ĐỂ MÀ TỪ ĐÓ CHỌN NGÔN NGŨ CON ĐÂY LÀ NƠI LƯU NGÔN NGỮ
public class TranslationManager : MonoSingleton<TranslationManager>
{
    [SerializeField] private TranslationCollection currentLanguageTranslations;
    public string CurrentLanguage => "English";

    //KHI LOAD GAME LÊN DỰA VÀO THẰNG CURRENTLAGUE LẤY CURRENTTRANLATIONCOLELCTION HIỆN TẠI
    //KHI THAY ĐỔI NGÔN NGỮ NHỚ CẬP NHẬT LÀ ĐC

    //lấy translation và có replacements vào trong nhưng tạm bỏ qua đi
    public string GetTranslation(string key)
    {
        if (TryGetTranslation(key, out string value))
        {
            return value;
        }

        return "";
    }

    public bool TryGetTranslation(string key, out string value)
    {
        if (currentLanguageTranslations.Contains(key))
        {
            value = currentLanguageTranslations.Get(key).Value;
            return true;
        }

        value = "";
        return false;
    }
}