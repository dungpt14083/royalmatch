using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GatherableContextStatusPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI AmountText;
    [SerializeField] private Button WorkButton;
    [SerializeField] private CanvasGroup CanvasGroup;
    [SerializeField] private RectTransform TutorialPoint;

    private IEnergyConsumer _consumer;
    private Transform _pivot;
    private bool _activeState;
    private bool _fullyShown;

    private void Start()
    {
        WorkButton.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        //liên quan 


        if (_consumer == null) return;
        //ACTIVE NẾU ĐANG MỜ MỜ THÌ HIỆN LÊN ĐÃ.CÒN NẾU SÁNG RỒI THÌ MỚI ẨN VÀ SELECTNEWMAINPANEL LÊN Ở ĐÂY CHƯA THÁY NÓI GÌ TỚI VỤ LỊC VÀO BUILDING CHẠY
        if (!_activeState)
        {
            GatherableContextManager.Instance.SetActivePanel(this);
            return;
        }

        //Check currency ở đây::
        var energy = InventoryManagerView.Instance.GeneralBalance.GetValue(CurrencyType.energy);
        if (energy < 1 /*|| energy < _consumer.GetEnergyCost()*/)
        {
            //thông báo k đủ tiền hiện lên cho người chơi vào để chơi puzzle:::
            //NotEnoughEnergyPopup.Data val_8 = null;
            //this._popupManager.Show(popupData:  482426880);
            //Debug.LogError("Khong du nang luong de xai");
            PopupManagerView.Instance.PopupManager.RequestPopup(new NotEnoughEnergyPopupRequest());
        }
        else
        {
            this._consumer.SetInCollectQueue(true);
            GatherableContextManager.Instance.HidePanel(this);
            GatherableContextManager.Instance.SelectNewMainPanel();
        }
    }

    public int GetEnergyCost()
    {
        return _consumer.GetEnergyCost();
    }

    //Chạy update cái ui này ở trên đầu::::
    //cái này nó tự động ở màn thì show k thì thôi nó position từ ngoài lên màn hình???hơi lạ
    private void Update()
    {
        if (_pivot!=null)
        {
            Vector3 screenPoint = Camera.main.WorldToScreenPoint(_pivot.position);
            Vector3 position = new Vector3(screenPoint.x, screenPoint.y, 0f);
            transform.position = position;
        }
    }


    
    
    
    
    
    
    
    //chạy ẩn animation scale và...cho thằng này:::
    public void PlayHideAnimation()
    {
        DG.Tweening.ShortcutExtensions.DOKill(target: transform, complete: false);
        DG.Tweening.ShortcutExtensions.DOScale(target: transform, endValue: Vector3.zero, duration: 0.2f)
            .From(new Vector3())
            .OnComplete(OnHideAnimationComplete);
    }

    private void OnHideAnimationComplete()
    {
        _consumer.ActivePanel = null;
        _consumer = null;
        _pivot = null;
        // Đặt trạng thái hoàn toàn hiển thị về 0 (ẩn)
        _fullyShown = false;
        gameObject.SetActive(false);
        // Báo cho GatherableContextManager biết rằng hoạt hình đã kết thúc
        GatherableContextManager.Instance.HideCompleted();
    }


    //Active là true hay false và oncompleted là actinon cho sự kiện gì?
    public void Show(IEnergyConsumer consumer, bool active, Action onComplete,Transform pivot)
    {
        if (consumer != _consumer)
        {
            _consumer = consumer;
        }

        consumer.ActivePanel = this;
        _pivot = pivot;
        
        UnityEngine.Vector3 position;
        //vị trí ban đầu???
        if (consumer != null)
        {
            //position = consumer.transform.position;
            //UnityEngine.Mesh mesh = consumer.GetComponent<MeshFilter>()?.sharedMesh;
            //UnityEngine.Bounds bounds = mesh != null ? mesh.bounds : consumer.GetComponentInChildren<Renderer>().bounds;
            //UnityEngine.Vector3 max = bounds.max;
            //float yOffset = max.y * 0.5f;
            //position.y += yOffset;
        }
        else
        {
            // Nếu không có người tiêu thụ năng lượng (consumer), sử dụng điểm hướng dẫn của panel
            //position = TutorialPoint.position;
        }

        this.SetState(active: active);
        this.gameObject.SetActive(true);
        this.AmountText.text = consumer.GetEnergyCost().ToString();
        DG.Tweening.ShortcutExtensions.DOKill(this.transform);
        UnityEngine.Vector3 localScale = this.transform.localScale;
        DG.Tweening.ShortcutExtensions.DOScale(this.transform, localScale.x, localScale.y).From(0.5f)
            .OnComplete(() => onComplete?.Invoke());
    }

    //Active này k phải gameobject.acvtive mà là được chọn và các cái lân cận các cái lân cận thì nhỏ hơn và mờ hơn::::
    public void SetState(bool active)
    {
        this._activeState = active;
        if (_activeState)
        {
            CanvasGroup.alpha = 1;
            this.transform.SetAsLastSibling();
            transform.localScale = Vector3.one;
            return;
        }

        this.CanvasGroup.alpha = 0.5F;
        transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
    }
}