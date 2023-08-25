using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ĐƯỢC ĐẶT TRONG SCENE MUỐN LOAD SẼ XỬ LÍ CÁC REQUEST LOAD SCENE
public class SceneLoader : MonoBehaviour
{
    private Coroutine _waitRoutine;

    //TRONG NÀY SE CÓ DATA CHO VIỆC LOAD SCENE ĐÓ CỤ THỂ LÀ DATA FARMISLANDDATAA CHẲNG HẠN
    private SceneRequest _dataToLoad;

    //LOAD SCENE VỚI REQUEST CHẠY LOAD
    public void LoadScene(SceneRequest data)
    {
        //NẾU ĐANG KHÔNG CÓ REQUEST NÀO TRƯỚC ĐÓ THÌ CHẠY NTN
        if (_waitRoutine == null)
        {
            _dataToLoad = data;
            _waitRoutine = StartCoroutine(WaitForLoader());
            return;
        }
        //NẾU CÓ THÌ SẼ DEBUG LOAG RA LÀ ĐANG CHỜ LOAD...NCH DEBUG THÔI
    }
    
    //GỌI TỚI LOADER Ở NGOÀI 1 SCENE PHỤ??
    private IEnumerator WaitForLoader()
    {
        while (Loader.IsLoading)
        {
            yield return null;
        }
        OnStartLoading();
        Loader.LoadScene(_dataToLoad);
    }
    
    protected virtual void OnStartLoading()
    {
    }
    
    
}
