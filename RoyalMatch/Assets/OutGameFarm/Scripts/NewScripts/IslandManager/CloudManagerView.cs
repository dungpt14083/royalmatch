using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using EasyButtons;
using UnityEngine;
using UnityEngine.Serialization;

public class CloudManagerView : MonoBehaviour
{
    //Clound
    [SerializeField] private Cloud cloudPrefab;
    [SerializeField] private Cloud cloud2Prefab;
    [SerializeField] private Cloud cloud3Prefab;
    [SerializeField] private TileAccessManagerView tileAccessManagerView;
    [SerializeField] private TileManagerView tileManagerView;

    private Dictionary<Vector2Int, Cloud> _activeClouds;
    private Dictionary<Vector2Int, Cloud> _activeCoverClouds;

    private TileManager TileManager { get; set; }

    public void Init(IsLandInfo isLandInfo)
    {
        _activeClouds = new Dictionary<Vector2Int, Cloud>();
        _activeCoverClouds = new Dictionary<Vector2Int, Cloud>();
        TileManager = isLandInfo.TileManager;
        tileAccessManagerView.TileAccessStatusChangeEvent += OnTileAccessStatusChange;
        Executors.Instance.StartCoroutine(DelayFrame());
    }

    private IEnumerator DelayFrame()
    {
        yield return new WaitForSeconds(1f);
        UpdateClouds(true);
    }

    private void OnDestroy()
    {
        tileAccessManagerView.TileAccessStatusChangeEvent -= OnTileAccessStatusChange;
    }

    private void OnTileAccessStatusChange()
    {
        UpdateClouds(false);
    }

    [Button]
    //Duyệt qua toàn bộ block block
    public void UpdateClouds(bool enableCreate)
    {
        //TRƯỚC KHI ĐÓ DUYỆT QUA DICTINAY CỦA TILEACESSSTATUS VÀ TỪ ĐÓ SẼ K STATUS BWAFNG 0 TỨC là TRẠNG THÁI BẰNG 0 NOT VISUABLE  HOẶC K BLOCK THÌ REMOVE:::
        //ACESSABLE???THÌ REMOVE MÂY::::
        //TẠO MÂY 
        
        
        //Duyệt qua list access kia để remove list cuar thang tileacesesmanager::
        var tmpReachedTiles = tileAccessManagerView.ReachedTiles;
        if (tmpReachedTiles != null)
        {
            foreach (var tmp in tmpReachedTiles)
            {
                if (_activeClouds.ContainsKey(tmp))
                {
                    RemoveCloud(tmp);
                }
            }
        }

        if (!enableCreate) return;
        _activeClouds.Clear();

        //Tạo mây cho bọn ở trên núi với blockedtiles:::: và tạo cho bọn activetile khi vào game:::
        //Tạo mây cho bọn block bởi núi
        var tmpBlock = TileManager.BlockedTiles.Where(pair => pair.Value == 1);
        foreach (var tmp in tmpBlock)
        {
            if (!_activeClouds.ContainsKey(tmp.Key) && !tmpReachedTiles.Contains(tmp.Key))
            {
                var tmpCloud = CreateCloud(tmp.Key);
                tmpCloud.SetVisible(true);
                //Đăng kí mây vào tilemanager để không ai theo tác được ở trong đặt nhà::
            }
        }

        //Tạo mây cho hết bọn active trước khi chúng được tạo rech chừa reach ra tạo các khu vực trống khsac
        var tmpAvailableTiles = TileManager.AvailableTiles;
        foreach (var tmpAvailable in tmpAvailableTiles)
        {
            if (!_activeClouds.ContainsKey(tmpAvailable) && !tmpReachedTiles.Contains(tmpAvailable))
            {
                var tmpCloud = CreateCloud(tmpAvailable);
                tmpCloud.SetVisible(true);
            }
        }


        if (enableCreate)
        {
            //CreateCoverClouds();
            //CreateEdgeCoverClouds();
        }
    }


    //RemoveClound khỏi vị trí pos
    private void RemoveCloud(Vector2Int pos)
    {
        Cloud cloudValue = this._activeClouds[pos];
        TileManager.UnRegisterAvailableTileCloud(cloudValue);
        cloudValue.FadeOut();
        _activeClouds.Remove(pos);
        //Đưa ra khỏi tilemanager ::
    }


    //Tạo mây dạng 1x1 ô grid:::PHẢI ĐƯA KÍCH THƯỚC GRID VÀ VỊ TRÍ CỦA NÓ VÀO ĐÂY::
    private Cloud CreateCloud(UnityEngine.Vector2Int position)
    {
        var tmp = tileManagerView.GridPointToWorldVector(position);

        Cloud cloudInstance = Instantiate<Cloud>(cloudPrefab, this.transform);

        //FAKE TẠM CHIÊU CAO MÂY
        float tileHeight = 0.2f /*this.tileManagerView.TileHeights[position]*/;
        tmp.y = tileHeight;
        cloudInstance.transform.position = tmp;

        cloudInstance.Init(new GridIndex(position.x, position.y),
            new GridSize(cloudInstance.GridSize.x, cloudInstance.GridSize.y));
        TileManager.RegisterAvailableTileCloud(cloudInstance);

        
        this._activeClouds.Add(position, cloudInstance);
        //this.tileManagerView.RegisterTileElement(cloudInstance);
        return cloudInstance;
    }

    private Cloud GetCloudPrefabOfSize(Vector2Int size)
    {
        var sizeX = size.x;
        if (size.y > size.x)
        {
            sizeX = size.y;
        }

        switch (sizeX)
        {
            case 1:
                return cloudPrefab;
            case 2:
                return cloud2Prefab;
            case 3:
                return cloud3Prefab;
            default:
                return null;
        }
    }

    //Tạo CreateCover Clound với size truyền vào 
    private Cloud CreateCoverCloud(Vector2Int pivotPosition, Vector2Int size, float height)
    {
        HideAllCloudsIn(pivotPosition, size);
        Cloud cloudPrefab = this.GetCloudPrefabOfSize(size);
        Cloud cloudInstance = Instantiate<Cloud>(cloudPrefab, this.transform);
        cloudInstance.transform.position = Vector3Extensions.WithSetY(cloudInstance.transform.position, height);
        this._activeCoverClouds.Add(pivotPosition, cloudInstance);
        return cloudInstance;
    }

    //Ân tất cả cloud trong vùng duyệt từ vị trí start::
    public void HideAllCloudsIn(Vector2Int start, Vector2Int distance)
    {
        int endY = start.y + distance.y;
        for (int y = start.y; y < endY; y++)
        {
            int endX = start.x + distance.x;
            for (int x = start.x; x < endX; x++)
            {
                Vector2Int pos = new Vector2Int(x, y);
                if (_activeClouds.ContainsKey(pos))
                {
                    Cloud cloud = _activeClouds[pos];
                    cloud.SetVisible(false);
                }
            }
        }
    }

    //TÍNH SAU ĐI
    private void CreateEdgeCoverClouds()
    {
        var activeClouds = _activeClouds.Values;
        var enumerator = activeClouds.GetEnumerator();

        // while (enumerator.MoveNext())
        // {
        //     Cloud cloud = enumerator.Current;
        //
        //     if (cloud == null)
        //     {
        //         continue;
        //     }
        //
        //     Vector2Int pivotPosition = cloud.PivotPosition;
        //     int width = cloud.Size.x;
        //     int height = cloud.Size.y;
        //
        //     //Tìm thử vị trí này xem có thể có thằng nếu tong vùng này k có cover thì sẽ????
        //     if (!IsAreaHasSingleCloud(pivotPosition, new Vector2Int(width, height)))
        //     {
        //         continue;
        //     }
        //
        //     int centerX = pivotPosition.x + (width / 2);
        //     int centerY = pivotPosition.y + (height / 2);
        //
        //     if (centerX == 0 || centerY == 0 || centerX == _tileManager.Width - 1 || centerY == _tileManager.Height - 1)
        //     {
        //         CreateCoverCloud(pivotPosition: pivotPosition, new Vector2Int(width, height),
        //             height: cloud.Height);
        //     }
        // }
    }


    // #region SAVEANDLOAD:::DATA::
    //
    // private StorageDictionary _storage;
    //
    // public CloudManager(StorageDictionary storage)
    // {
    //     _storage = storage;
    // }
    //
    // public StorageDictionary Serialize()
    // {
    //     if (_storage == null)
    //     {
    //         _storage = new StorageDictionary();
    //     }
    //
    //     return _storage;
    // }
    //
    // public void ResolveDependencies(GameData game)
    // {
    //     
    // }
    //
    // #endregion
}