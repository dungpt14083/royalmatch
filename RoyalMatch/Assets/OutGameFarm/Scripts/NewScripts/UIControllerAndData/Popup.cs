using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//LÕI CỦA TẤT CẢ POPUP:::
public class Popup : MonoBehaviour
{
    //REQUEST HAY NẾU LÀ GAMEONLINE THÌ NÓ LÀ DATA LÕI CỦA POPUP NÀY:::ẤY Ở ĐÂU ĐÓ UER MODEL NHƯNG GAME NÀY K XÀI SINGLETON NÊN LÀ TỰ LẤY TRONG GAME ĐƯỢC TRUYỀN
    protected PopupRequest _request;

    //DADATAA GAME TRONG NÀY CÓ TẤT CẢ
    protected GameData _game;
    protected IsLandInfo _isLandInfo;
    public bool IsOpen { get; protected set; }
    
    protected virtual void OnDestroy()
    {
        IsOpen = false;
        _request = null;
        _game = null;
    }
    
    //BAN ĐẦU VÀO GAME THÌ TRUYỀN VÀO INIT BAN ĐẦU
    public virtual void Init(GameData game,IsLandInfo isLandInfo)
    {
        _game = game;
        _isLandInfo = isLandInfo;
        IsOpen = false;
        base.gameObject.SetActive(false);
    }
    
    //GỌI MỞ BẰNG REQUEST THÌ SẼ....::
    public virtual void Open(PopupRequest request)
    {
        _request = request;
        base.gameObject.SetActive(true);
        IsOpen = true;
    }
    
    public virtual void Close()
    {
        base.gameObject.SetActive(false);
        _request = null;
        IsOpen = false;
    }
    
    //KHI MÀ MUỐN ĐÓNG CÓ THỂ DÙNG VÀO CHẠY NÓ:
    public virtual void OnCloseClicked()
    {
        if (IsOpen)
        {
            _game.PopupManager.ClosePopup(_request);
        }
    }
    
    //CHECK NẾU MÀ ĐANG SHOW VỚI REQUEST NÀY THÌ TRUE CÒN K THÌ FALSE:
    public bool IsShowingRequest(PopupRequest request)
    {
        if (!IsOpen || _request == null || request == null)
        {
            return false;
        }
        return _request == request;
    }
    
    protected T GetRequest<T>() where T : PopupRequest
    {
        return (T)_request;
    }
    
    public virtual void Refresh(PopupRequest request)
    {
        _request = request;
        base.gameObject.SetActive(true);
    }
}