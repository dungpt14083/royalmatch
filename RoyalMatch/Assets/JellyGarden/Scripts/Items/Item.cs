using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;
using Random = UnityEngine.Random;

//types of items

public class Item : MonoBehaviour
{
    public SpriteRenderer sprRenderer;
    public Square square;
    //is that item dragging
    public bool dragThis;
    public Vector3 mousePos;
    public Vector3 deltaPos;
    public Vector3 switchDirection;
    public ItemStatus itemStatus;
    [SerializeField]
    private string mesTest;
    public BombDestroy bombDestroy;
    public bool boost;
    public Vector2 moveDirection;
    public BoxCollider2D boxCollider;
    //1.6
    // Use this for initialization
    void Start()
    {
        if (boxCollider == null) boxCollider = GetComponent<BoxCollider2D>();
    }
    public void Init(Vector3 pos)
    {
        transform.position = pos;
        gameObject.name += $"_{GetInstanceID()}";
        mesTest = "";
        itemStatus = ItemStatus.Idle;
        bombDestroy = null;
    }
    public void SetMes(string mes)
    {
        mesTest += $"_{mes}";
    }
    public void SetItemStatus(ItemStatus status, string mes)
    {
        itemStatus = status;
        SetMes(mes);
    }
    void ResetDrag()
    {
        dragThis = false;
        switchDirection = Vector3.zero;
        if(itemStatus == ItemStatus.Draging) SetItemStatus(ItemStatus.Idle, "ResetDrag");
    }
    public virtual ItemsTypes GetItemType()
    {
        return ItemsTypes.NONE;
    }
    void Update()
    {
        if (dragThis)
        {
            deltaPos = mousePos - GetMousePosition();
            if (switchDirection == Vector3.zero)
            {
                SwitchDirection(deltaPos);
            }
        }
    }
    public bool IsCanSwitch()
    {
        if (itemStatus != ItemStatus.Idle) return false;
        return true;
    }
    public void SwitchDirection(Vector3 delta)
    {
        
        deltaPos = delta;
        if (!IsCanSwitch())
        {
            ResetDrag();
            return;
        }
        SetItemStatus(ItemStatus.Draging, "SwitchDirection");
        if (Vector3.Magnitude(deltaPos) > 0.1f)
        {
            if (Mathf.Abs(deltaPos.x) > Mathf.Abs(deltaPos.y) && deltaPos.x > 0)
                switchDirection.x = 1;
            else if (Mathf.Abs(deltaPos.x) > Mathf.Abs(deltaPos.y) && deltaPos.x < 0)
                switchDirection.x = -1;
            else if (Mathf.Abs(deltaPos.x) < Mathf.Abs(deltaPos.y) && deltaPos.y > 0)
                switchDirection.y = 1;
            else if (Mathf.Abs(deltaPos.x) < Mathf.Abs(deltaPos.y) && deltaPos.y < 0)
                switchDirection.y = -1;
            Square neighborSquare = null;
            if (switchDirection.x > 0)
            {
                neighborSquare = square.GetNeighborLeft();
            }
            else if (switchDirection.x < 0)
            {
                neighborSquare = square.GetNeighborRight();
            }
            else if (switchDirection.y > 0)
            {
                neighborSquare = square.GetNeighborBottom();
            }
            else if (switchDirection.y < 0)
            {
                neighborSquare = square.GetNeighborTop();
            }
            if (neighborSquare != null && square != null)
                StartCoroutine(Switching(neighborSquare));
            else
                ResetDrag();
        }
        else
        {
            SetItemStatus(ItemStatus.Idle, "SwitchDirection222222");
        }
    }

    IEnumerator Switching(Square neighborSquare)
    {
        Item switchItem = neighborSquare.item;
        itemStatus = ItemStatus.Draging;
        if (switchDirection != Vector3.zero && dragThis && switchItem != null && switchItem.IsCanSwitch())
        {
            bool backMove = false;
            switchItem.SetItemStatus(ItemStatus.Draging, "Switching");
            float startTime = Time.time;
            Vector3 startPos = transform.position;
            
            float speed = 5;
            float distCovered = 0;
            while (distCovered < 1)
            {
                distCovered = (Time.time - startTime) * speed;
                transform.position = Vector3.Lerp(startPos, neighborSquare.transform.position + Vector3.back * 0.3f, distCovered);
                switchItem.transform.position = Vector3.Lerp(neighborSquare.transform.position + Vector3.back * 0.2f, startPos, distCovered);
                yield return new WaitForFixedUpdate();
            }
            LevelManager.Instance.SquareSetItem(square, switchItem);
            LevelManager.Instance.SquareSetItem(neighborSquare, this);
            //square.SetItem(switchItem);
            //neighborSquare.SetItem(this);
            if(square == null)
            {
                Debug.Log($"{gameObject.name} 111111111111111 square == null");
            }
            //switchItem.square = square;
            //this.square = neighborSquare;
            if(this is ActionItem && switchItem is ActionItem)
            {
                backMove = false;
                this.SetItemStatus(ItemStatus.Idle, "Switching");
                switchItem.SetItemStatus(ItemStatus.Idle, "Switching");
                LevelManager.Instance.SwitchItemAction((ActionItem)this, (ActionItem)switchItem);

            }else if(this is ActionItem || switchItem is ActionItem)
            {
                Debug.Log($"{gameObject.name} 222222222222222 square == null");
                backMove = false;
                this.SetItemStatus(ItemStatus.Idle, "Switching");
                switchItem.SetItemStatus(ItemStatus.Idle, "Switching");
                if (this is ActionItem)
                {
                    if (this is BombItem) (this as BombItem).SetItemNew(switchItem);
                    //LevelManager.Instance.SquareSetItem(this.square, null);
                    LevelManager.Instance.CheckMatches(switchItem.square);
                    ((ActionItem)this).Use();
                }
                else if (switchItem is ActionItem)
                {
                    if (switchItem is BombItem) (switchItem as BombItem).SetItemNew(this);
                    //LevelManager.Instance.SquareSetItem(switchItem.square, null);
                    LevelManager.Instance.CheckMatches(this.square);
                    ((ActionItem)switchItem).Use();
                }
            }
            else
            {
                var check1 = LevelManager.Instance.CheckMatches(this);
                var check2 = LevelManager.Instance.CheckMatches(switchItem);
                if (!check1 && !check2) backMove = true;
            }
            
            startTime = Time.time;
            distCovered = 0;
            while (distCovered < 1 && backMove)
            {
                distCovered = (Time.time - startTime) * speed;
                transform.position = Vector3.Lerp(neighborSquare.transform.position + Vector3.back * 0.3f, startPos, distCovered);
                switchItem.transform.position = Vector3.Lerp(startPos, neighborSquare.transform.position + Vector3.back * 0.2f, distCovered);
                yield return new WaitForFixedUpdate();
            }

            if (backMove)
            {
                var square1 = this.square;
                var square2 = switchItem.square;
                LevelManager.Instance.SquareSetItem(square1, switchItem);
                LevelManager.Instance.SquareSetItem(square2, this);
                //square1.SetItem(switchItem);
                //square2.SetItem(this);
                this.ResetDrag();
                //neighborSquare.item =  this;
                //square.item = switchItem;
                //switchItem.square = square;
                //this.square = neighborSquare;
                //LevelManager.Instance.DragBlocked = false;
                //StartCoroutine(AI.THIS.CheckPossibleCombines());//2.1.5 prevents early move
            }
            else
            {
                LevelManager.Instance.targetController.MoveItem();
            }
            switchItem.ResetDrag();
        }
        ResetDrag();
    }
    Vector3 GetDeltaPositionFromSquare(Square sq, Vector3 delta)
    {
        Vector3 newPos = (sq.transform.position - delta) + Vector3.back * 0.3f;
        newPos.x = Mathf.Clamp(newPos.x, sq.GetNeighborLeft(true).transform.position.x, sq.GetNeighborRight(true).transform.position.x);
        newPos.y = Mathf.Clamp(newPos.y, sq.GetNeighborBottom(true).transform.position.y, sq.GetNeighborTop(true).transform.position.y);
        return newPos;
    }


    public Vector3 GetMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void StartFalling()
    {
        transform.DOMove(square.transform.position, 10).SetEase(Ease.Linear).SetSpeedBased(true).OnComplete(()=> {
            if (itemStatus == ItemStatus.Creating || itemStatus == ItemStatus.Moving || itemStatus == ItemStatus.Idle)
            {
                transform.position = square.transform.position/* + Vector3.back * 0.2f*/;
                LevelManager.Instance.CheckFalling(this);
            }
        }); ;
    }

    IEnumerator FallingCor(Square _square, bool animate)
    {
        //falling = true;
        float startTime = Time.time;
        Vector3 startPos = transform.position;
        float speed = 5f;
        if (LevelManager.Instance.gameStatus == GameState.PreWinAnimations)
            speed = 5f;
        float distance = Vector3.Distance(startPos, _square.transform.position);
        float fracJourney = 0;
        if (distance > 0.5f)
        {
            while (fracJourney < 1)
            {
                if (itemStatus == ItemStatus.Destroyed) break;
                //speed += 0.2f;
                float distCovered = (Time.time - startTime) * speed;
                fracJourney = distCovered / distance;
                transform.position = Vector3.Lerp(startPos, _square.transform.position + Vector3.back * 0.2f, fracJourney);
                yield return new WaitForFixedUpdate();

            }
        }
        if(itemStatus == ItemStatus.Creating || itemStatus == ItemStatus.Moving || itemStatus == ItemStatus.Idle)
        {
            transform.position = _square.transform.position + Vector3.back * 0.2f;
            LevelManager.Instance.CheckFalling(this);
        }
    }
    public void EndFall()
    {
        var statusOld = itemStatus;
        SetItemStatus(ItemStatus.Idle, "EndFall");
        if(statusOld == ItemStatus.Moving && bombDestroy == null) EffectEndFall();
    }
    public void BombSelectDestroy()
    {
        if (itemStatus == ItemStatus.Idle)
        {
            itemStatus = ItemStatus.Destroying;
            bombDestroy.AddItemToSelectedItems(this);
        }
        else
        {
            Debug.Log("BombSelectDestroy itemStatus " + itemStatus);
        }
    }
    public void EffectBombSelectDestroy()
    {
        transform.DOScaleX(0.8f, 0.5f);
        transform.DOScaleY(0.8f, 0.5f);
    }
    public Item GetLeftItem()
    {
        Square sq = square.GetNeighborLeft();
        if (sq != null)
        {
            if (sq.item != null)
                return sq.item;
        }
        return null;
    }
    public Sprite GetTargetIcon()
    {
        return sprRenderer?.sprite;
    }
    public Item GetTopItem()
    {
        Square sq = square.GetNeighborTop();
        if (sq != null)
        {
            if (sq.item != null)
                return sq.item;
        }
        return null;
    }
    #region Destroying

    //public virtual void Package()
    //{
    //    LevelManager.Instance.SquareSetItem(square, null);
    //    LevelManager.Instance.GetItemFallOrGenItem(square);
    //    LevelManager.Instance.DestroyItem(this, true);
    //}
    //public virtual void Propeller()
    //{
    //    LevelManager.Instance.SquareSetItem(square, null);
    //    LevelManager.Instance.GetItemFallOrGenItem(square);
    //    LevelManager.Instance.DestroyItem(this, true);
    //}
    public virtual void ColiderWithObjDestroy()
    {
        //AttackItem();
        LevelManager.Instance.SquareSetItem(square, null);
        var target = LevelManager.Instance.FindTaget(this);
        LevelManager.Instance.DestroyItem(this, target, true);
    }
    public virtual void OnMatchesOrPowerUp(ChangeStateTypes type, int _color = -1)
    {
        if (itemStatus != ItemStatus.Idle) return;
        MatchesOrPowerUpAction();
    }
    public virtual void MatchesOrPowerUpAction()
    {

    }
    public virtual void Click()
    {

    }
    public void DestroyObj(TargetUI targetUI, bool isMoveToTarget)
    {
        boxCollider.enabled = false;
        itemStatus = ItemStatus.Destroyed;
        //Find target 
        
        if (targetUI == null || !isMoveToTarget)
        {
            transform.DOScale(Vector3.zero, 0.5f).OnComplete(() => {
                Debug.Log($"Destroy {name}");
                Destroy(gameObject);
            }
            );
        }
        else
        {
            sprRenderer.sortingOrder = 10;
            float offsetY = 2;
            float offsetX = 0;
            if (transform.position.x > targetUI.transform.position.x)
            {
                offsetX = -2;
            }
            else if (transform.position.x < targetUI.transform.position.x)
            {
                offsetX = 2;
            }
            float posX = transform.position.x + offsetX;
            float posY = transform.position.y - offsetY;
            Vector3 pos = new Vector3(posX, posY, transform.position.z);
            Vector3[] pathMove = new Vector3[] { transform.position, pos, targetUI.transform.position };

            if (GameManagerHeroRecues.instance != null)
            {
                var pinLong = LevelHeroRescues._instance?.FindPinLongByTargetInfo(new TargetInfo { targetType = TargetTypes.CollectItem,itemsType = GetItemType ()});
                if (pinLong != null)
                {
                    pinLong.OffSet(-1);
                }
            }
            transform.DOPath(pathMove, 40, PathType.CatmullRom).SetSpeedBased(true).SetEase(Ease.InSine).OnComplete(() => {
                Debug.Log($"Destroy 222222222 {name}");
                targetUI.OffSet(-1);
                Destroy(gameObject);
            });
        }
    }
    public void EffectDestroy()
    {
        if (itemStatus != ItemStatus.Destroying) itemStatus = ItemStatus.Destroying;

    }
    public void EffectEndFall()
    {
        transform.DOScale(0.8f, 0.25f).OnComplete(()=> {
            transform.DOScale(0.6f, 0.25f);
        });
    }
    public virtual void AttackItem()
    {
        LevelManager.Instance.SquareSetItem(square, null);
        LevelManager.Instance.DelayedCall(0.5f,()=> LevelManager.Instance.GetItemFallOrGenItem(square));
        var target = LevelManager.Instance.FindTaget(this);
        LevelManager.Instance.DestroyItem(this, target,true);
    }
    #endregion

}
public  enum ItemStatus
{
    None,
    Creating,
    Idle,
    Draging,
    Moving,
    Destroying,
    Destroyed
}
[Serializable]
public class StripedItem
{
    public Sprite horizontal;
    public Sprite vertical;
}
