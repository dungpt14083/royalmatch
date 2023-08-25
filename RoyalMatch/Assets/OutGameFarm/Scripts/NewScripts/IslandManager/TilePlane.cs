using System;
using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class TilePlane : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
    public delegate void TilePlanePressHandler(Vector3 worldClickPosition);

    //Dành cho việc disable building placement và thằng dable ấn và không thể truy cập
    [SerializeField] private bool disableNewBuildingPlacement;
    [SerializeField] private bool disablePress;
    [SerializeField] private bool unreachable;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private BoxCollider collider;
    [SerializeField] private bool testBool;


    public bool showPreview;
    public float stepScale;
    public int tileStep;
    private List<TilePlane> _createdTilePlanes;
    private TilePlane _parentTilePlane;
    private TileManagerView _tileManagerView;
    private bool _canClickPlane = true;


    public void OnPointerClick(PointerEventData eventData)
    {
        if (_canClickPlane)
        {
            //Debug.LogError("CanClickPlane");
            //Qua tilemanager phát sự kiện và nghe ::
            if (TileManagerView.Instance != null)
            {
                //Debug.LogError("CanClick"+eventData.pointerCurrentRaycast.worldPosition);
                TileManagerView.Instance.FireTilePlanePressEvent(eventData.pointerCurrentRaycast.worldPosition);
                //Debug.LogError("Click TOạ độ thế giới "+eventData.pointerCurrentRaycast.worldPosition.ToString());
            }
        }
    }

    private void Awake()
    {
        this.OnAwake();
        GameSignals.EnableClickPlaneWhenShowPreBuilding.AddListener(EnableClickPlane);
    }


    private void OnDestroy()
    {
        GameSignals.EnableClickPlaneWhenShowPreBuilding.RemoveListener(EnableClickPlane);
    }

    private void EnableClickPlane(bool enable)
    {
        _canClickPlane = enable;
    }

    //ẢNH SIZE LÀ SIZE ẢNH LUÔN R
    private void OnAwake()
    {
        StartCoroutine(WaitForTileManagerView());
    }

    private IEnumerator WaitForTileManagerView()
    {
        //Ý LÀ Ô NÀY K THỂ TRUY CẬP THÌ SẼ KHÔNG ĐƯA ĐƯAG KÍ VÀO AVAILABLE LÀ ĐƯỢC:::

        yield return new WaitForSeconds(0.5f);

        Vector3 positionCenterTile = this.transform.position;
        var sizeTile = spriteRenderer.size;
        float left = positionCenterTile.x - (sizeTile.x / 2);
        float bottom = positionCenterTile.z - (sizeTile.y / 2);
        var positionCorner = new Vector3(left, positionCenterTile.y, bottom);

        if (testBool)
        {
            //fOR TEST MÂY
            for (int i = 0; i < sizeTile.x; i++)
            {
                for (int j = 0; j < sizeTile.y; j++)
                {
                    var tmpWorldPosition = positionCorner + new Vector3(i * 1 + 0.5f, 0, j * 1 + 0.5f);
                    TileManagerView.Instance.BlockTileByTilePlane(tmpWorldPosition);
                }
            }
        }

        //BLOCK ĐI NẾU LÀ VỊ TRÍ ỦNEACABLE
        if (unreachable)
        {
            for (int i = 0; i < sizeTile.x; i++)
            {
                for (int j = 0; j < sizeTile.y; j++)
                {
                    var tmpWorldPosition = positionCorner + new Vector3(i * 1 + 0.5f, 0, j * 1 + 0.5f);
                    TileManagerView.Instance.BlockTileByTilePlane(tmpWorldPosition);
                }
            }
        }

        if (unreachable) yield break;

        //Không chạy xuống xét ô khả dụng ở đây nữa:::
        for (int i = 0; i < sizeTile.x; i++)
        {
            for (int j = 0; j < sizeTile.y; j++)
            {
                var tmpWorldPosition = positionCorner + new Vector3(i * 1 + 0.5f, 0, j * 1 + 0.5f);
                TileManagerView.Instance.RegisterAvailableTile(tmpWorldPosition);
            }
        }
    }

    [Button]
    public void TestMay()
    {
        Vector3 positionCenterTile = this.transform.position;
        var sizeTile = spriteRenderer.size;
        float left = positionCenterTile.x - (sizeTile.x / 2);
        float bottom = positionCenterTile.z - (sizeTile.y / 2);
        var positionCorner = new Vector3(left, positionCenterTile.y, bottom);
        for (int i = 0; i < sizeTile.x; i++)
        {
            for (int j = 0; j < sizeTile.y; j++)
            {
                var tmpWorldPosition = positionCorner + new Vector3(i * 1 + 0.5f, 0, j * 1 + 0.5f);
                TileManagerView.Instance.BlockTileByTilePlane(tmpWorldPosition);
            }
        }
    }
}