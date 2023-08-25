using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    private static Scene _oldScene;
    private static SceneRequest _data;
    private static bool _isLoading;

    public static SceneRequest LastSceneRequest
    {
        get { return _data; }
    }

    public static bool IsLoading
    {
        get { return _isLoading; }
    }

    //khi được mở lên thì sẽ chạy cái này:::
    private void Start()
    {
        StartCoroutine(DoLoadingRoutine(_data));
    }

    //GỌI TỚI LOAD SCENE:::
    public static void LoadScene(SceneRequest data)
    {
        //BO
        if (!_isLoading)
        {
            _isLoading = true;
            _oldScene = SceneManager.GetActiveScene();
            _data = data;
            //LOAD SCENE DẠNG ADDTIVE
            SceneManager.LoadSceneAsync(_data.LoaderSceneName, LoadSceneMode.Additive);
        }
        else
        {
            //NẾU ĐNAG LOAD DING THÌ BỎ QUA VÌ ĐANG LOAD RỒI HCIR NHẬN 1 REQUEST XỬ LÍ
        }
    }

    //CÁC GIAI ĐOẠN LOAD Ở ĐÂY LOAD CÁC THỬ VÀ # CÁC THỨ XỬ LÍ
    private IEnumerator DoLoadingRoutine(SceneRequest data)
    {
        OnStartLoading();
        SetProgress(0f);
        //ANIMATION ĐẦU VÀO CHẠY LOAD SCENE
        yield return StartCoroutine(DoIntroAnimation());

        //UNLOAD SCENE CŨ ĐI TỚI KHI NÓ XONG THÌ  VÀ ASSET K DÙNG ĐI
        AsyncOperation unloadOp3 = SceneManager.UnloadSceneAsync(_oldScene.name);
        while (!unloadOp3.isDone)
        {
            yield return null;
        }

        unloadOp3 = Resources.UnloadUnusedAssets();
        while (!unloadOp3.isDone)
        {
            yield return null;
        }

        #region LOAD RESOURCE SCENE ĐỂ LẤY DATA NGƯỜI CHƠI

        //NẾU KHÔNG CÓ TRỐNG RESOURCESCENENAME TRONG REQUEST  ????
        //LOAD ADDTIVE CÁI SCENE RESOURCE ĐÓ LÊN
        if (!string.IsNullOrEmpty(data.ResourceSceneName))
        {
            AsyncOperation op = SceneManager.LoadSceneAsync(data.ResourceSceneName, LoadSceneMode.Additive);
            while (!op.isDone)
            {
                yield return null;
            }
        }

        //CHẠY COROUTINE CHÔ VIỆC LOADDURRING SCENE SWITCH
        // 1 SỐ REQUEST THÌ TẠO RA DATA CITYISSLAND TỪ SERVER VỀ MỘT SỐ THÌ BLA BLA:::
        StartCoroutine(data.LoadDuringSceneSwitch());
        //sau khi load xong thì sẽ chạy với % với thằng data kia để chạy load và hiển thị process
        while (!data.HasCompleted)
        {
            SetProgress(data.Progress * data.LoadingWeight);
            yield return null;
        }

        //xong load data rồi thì sẽ UNLOAD ĐI
        if (!string.IsNullOrEmpty(data.ResourceSceneName))
        {
            unloadOp3 = SceneManager.UnloadSceneAsync(data.ResourceSceneName);
            while (!unloadOp3.isDone)
            {
                yield return null;
            }
        }

        #endregion


        //TỪ ĐÂY SẼ LOAD SCENE SCENEGAME TRONG REQUEST LÊN VÀ CHẠY % LOAD GAME THẬT::
        //HIỆN SCENE LÊN SCENE GAME CHÍNH
        AsyncOperation loadOp = SceneManager.LoadSceneAsync(data.SceneName, LoadSceneMode.Additive);
        loadOp.allowSceneActivation = false;
        while (loadOp.progress < 0.9f)
        {
            SetProgress(data.LoadingWeight + loadOp.progress * (1f - data.LoadingWeight));
            yield return null;
        }

        loadOp.allowSceneActivation = true;
        while (!loadOp.isDone)
        {
            SetProgress(data.LoadingWeight + loadOp.progress * (1f - data.LoadingWeight));
            yield return null;
        }

        SetProgress(1f);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(data.SceneName));
        yield return StartCoroutine(DoOutroAnimation());
        SceneManager.UnloadSceneAsync(data.LoaderSceneName);
        Resources.UnloadUnusedAssets();
        _isLoading = false;
    }


    protected virtual void OnStartLoading()
    {
    }

    protected virtual void SetProgress(float normalisedProgress)
    {
    }

    protected virtual IEnumerator DoIntroAnimation()
    {
        yield break;
    }

    protected virtual IEnumerator DoOutroAnimation()
    {
        yield break;
    }
}