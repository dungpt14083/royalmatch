using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootersController : MonoBehaviour
{
    public BooterUI booterPrefab;
    public BooterHammer booterHammerPrefab;
    public ArowBooter booterArrowPrefab;
    public BooterCannon booterCannonPrefab;
    public Transform parent;
    public Dictionary<BootersType, BooterUI> bootersUI = new Dictionary<BootersType, BooterUI>();
    public BooterBase currentBootersUse;
    public void Init(List<BooterInfo> booterInfos)
    {
        ClearBooter();
        if (booterInfos == null || booterInfos.Count == 0) return;
        foreach(var booterInfo in booterInfos)
        {
            var booterUI = GameObject.Instantiate(booterPrefab, parent);
            booterUI.Init(booterInfo);
            bootersUI[booterInfo.booterType] = booterUI;
        }
    }
    public void ClearBooter() {
        foreach(var booter in bootersUI)
        {
            Destroy(booter.Value.gameObject);
        }
        bootersUI.Clear();
    }
    public void SelectBooter(BootersType bootersType)
    {
        if (currentBootersUse != null) return;
        switch (bootersType)
        {
            case BootersType.Hammer:
                var booterHammer = GameObject.Instantiate(booterHammerPrefab);
                booterHammer.Init(bootersType);
                currentBootersUse = booterHammer;
                break;
            case BootersType.Arrow:
                var booterArrow = GameObject.Instantiate(booterArrowPrefab);
                booterArrow.Init(bootersType);
                currentBootersUse = booterArrow;
                break;
            case BootersType.Cannon:
                var booterCannon = GameObject.Instantiate(booterCannonPrefab);
                booterCannon.Init(bootersType);
                currentBootersUse = booterCannon;
                break;
        }
    }
    public void UseBooter(Square square)
    {
        if(square == null)
        {
            return;
        }
        if (currentBootersUse == null) return;
        var useStatus = currentBootersUse.UseBooter(square);
        if (useStatus && bootersUI.ContainsKey(currentBootersUse.bootersType)) bootersUI[currentBootersUse.bootersType].OffSet(-1);
        currentBootersUse = null;
    }
}
