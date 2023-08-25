using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using Object = UnityEngine.Object;

public static class ExtensionUtils
{
    #region invoke

    private static Dictionary<Action, IEnumerator> _invokeMethods = new Dictionary<Action, IEnumerator>();

    public static void Invoke(this MonoBehaviour monoBehaviour, Action action, float time, bool realtime = false)
    {
        IEnumerator enumerator = InvokeCoroutine(action, time, realtime);
        if (_invokeMethods.ContainsKey(action))
        {
            Debug.LogWarningFormat(
                "[ActionInvoker] Overriding enumerator for action '{0}'. Are you using an anonymous delegate?",
                GetMethodName(action));
            _invokeMethods[action] = enumerator;
        }
        else
        {
            _invokeMethods.Add(action, enumerator);
        }

        monoBehaviour.StartCoroutine(enumerator);
    }

    private static string GetMethodName(Action action)
    {
        return "unknown";
    }

    private static IEnumerator InvokeCoroutine(Action action, float time, bool realtime)
    {
        if (realtime)
        {
            yield return new WaitForSecondsRealtime(time);
        }
        else
        {
            yield return new WaitForSeconds(time);
        }

        if (_invokeMethods.ContainsKey(action))
        {
            _invokeMethods.Remove(action);
            action();
        }
    }

    public static void CancelInvoke(this MonoBehaviour monoBehaviour, Action action)
    {
        if (_invokeMethods.ContainsKey(action))
        {
            monoBehaviour.StopCoroutine(_invokeMethods[action]);
            _invokeMethods.Remove(action);
        }
    }

    public static bool IsInvoking(this MonoBehaviour monoBehaviour, Action action)
    {
        return _invokeMethods.ContainsKey(action);
    }

    #endregion


    public static bool Contains(this Direction dirs, Direction dir)
    {
        return (dirs & dir) != 0;
    }

    public static T InstantiatePrefab<T>(this T prefab, Component parent = null) where T : MonoBehaviour
    {
        GameObject gameObject = Object.Instantiate(prefab.gameObject);
        if (parent != null)
        {
            gameObject.transform.SetParent(parent.transform, false);
        }

        return gameObject.GetComponent<T>();
    }

    public static string ToCurrencyName(this CurrencyType currency)
    {
        return currency.ToString().ToLowerInvariant();
    }

    #region ENUMEXTENSION

    public static List<U> CastAll<T, U>(this List<T> list, Func<T, U> converter)
    {
        List<U> list2 = new List<U>();
        int i = 0;
        for (int count = list.Count; i < count; i++)
        {
            U item = converter(list[i]);
            list2.Add(item);
        }

        return list2;
    }

    #endregion


    #region FlipTranform

    public static void FlipScaleX(this Transform transform)
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    public static void AbsScaleX(this Transform transform)
    {
        Vector3 localScale = transform.localScale;
        localScale.x = Mathf.Abs(localScale.x);
        transform.localScale = localScale;
    }

    public static void SetAnchoredPositionY(this RectTransform rect, float y)
    {
        Vector2 anchoredPosition = rect.anchoredPosition;
        anchoredPosition.y = y;
        rect.anchoredPosition = anchoredPosition;
    }

    #endregion


    #region TODOCUTSCENE

    public static string GetParameterInfoFormat(this Vector3 v)
    {
        string format = "{0}_{1}_{2}";
        string result = string.Format(format, v.x, v.y, v.z);
        return result;
    }


    public static UnityEngine.Vector3 ParseParameterInfoVector3(this string parameterString)
    {
        string[] values = parameterString.Split('_');
        if (values.Length != 3)
        {
            //Debug.LogError("Invalid parameter string for Vector3 parsing: " + parameterString);
            return UnityEngine.Vector3.zero;
        }

        float x, y, z;
        if (!float.TryParse(values[0], out x) || !float.TryParse(values[1], out y) || !float.TryParse(values[2], out z))
        {
            //Debug.LogError("Failed to parse Vector3 from parameter string: " + parameterString);
            return UnityEngine.Vector3.zero;
        }

        return new UnityEngine.Vector3(x, y, z);
    }


    public static Vector3 GetVector3Parameter(List<ParameterInfo> parameters, string name)
    {
        string tmpString = GetParameter(parameters, name);
        Vector3 tmpValueVector3 = ParseVector3(tmpString);
        return tmpValueVector3;
    }

    //DÀNH CHO MOBILE
    // public static Vector3 ParseVector3ForMobile(string vectorString)
    // {
    //     string[] values = vectorString.Split('_');
    //
    //     if (values.Length != 3)
    //     {
    //         
    //         Debug.LogError("KHONG PHẢI CHIỀU DÀI 3"+values.ToString()+"xx"+values.Length);
    //         return new Vector3(0, 0, 0);
    //     }
    //
    //     int xInt = 0, yInt = 0, zInt = 0;
    //
    //     if (!int.TryParse(values[0].Replace(".", ""), out xInt) ||
    //         !int.TryParse(values[1].Replace(".", ""), out yInt) ||
    //         !int.TryParse(values[2].Replace(".", ""), out zInt))
    //     {
    //         Debug.LogError("vào trường hợp lỗi "+vectorString);
    //     }
    //
    //     float x = (float)xInt / 100f;
    //     float y = (float)yInt / 100f;
    //     float z = (float)zInt / 100f;
    //
    //     Debug.LogError("thành công"+(new Vector3(x, y, z)).ToString());
    //     return new Vector3(x, y, z);
    // }

    //DÀNH CHO PC
    public static Vector3 ParseVector3(string vectorString)
    {
        string[] values = vectorString.Split('_');

        if (values.Length != 3)
        {
            Debug.LogError("Lỗi vị trí di chuyển");
        }

        float x = 0f, y = 0f, z = 0f;

        if (!float.TryParse(values[0], out x) ||
            !float.TryParse(values[1], out y) ||
            !float.TryParse(values[2], out z))
        {
            Debug.LogError("Lỗi vị trí di chuyển");
        }

        return new Vector3(x, y, z);
    }


    public static int GetIntParameter(List<ParameterInfo> parameters, string name)
    {
        string tmp = GetParameter(parameters, name);
        return Int32.Parse(tmp);
    }

    public static string GetParameter(List<ParameterInfo> parameters, string name)
    {
        foreach (ParameterInfo parameter in parameters)
        {
            if (parameter.Name == name)
            {
                return parameter.Value.ToString();
            }
        }

        return "";
    }


    public static string GetParameterVector2IntFormat(this GridIndex v)
    {
        string format = "{0}, {1}";
        string result = string.Format(format, v.U, v.V);
        return result;
    }

    public static Vector2Int GetVector2IntParameter(List<ParameterInfo> parameters, string name)
    {
        string tmpString = GetParameter(parameters, name);
        Vector2Int tmpValueVector2 = ParseVector2Int(tmpString);
        return tmpValueVector2;
    }

    public static Vector2Int ParseVector2Int(string vectorString)
    {
        string[] values = vectorString.Split(',');

        if (values.Length != 2)
        {
            throw new FormatException("Invalid Vector3 format");
        }

        int x, y;

        if (!int.TryParse(values[0], out x) ||
            !int.TryParse(values[1], out y))
        {
            throw new FormatException("Invalid Vector3 format");
        }

        return new Vector2Int(x, y);
    }

    #endregion


    #region LISTEXTENSION

    public static T Dequeue<T>(this IList<T> list)
    {
        if (list.Count == 0)
        {
            return default(T);
        }

        T item = list[0];
        list.RemoveAt(0);
        return item;
    }


    public static T Pop<T>(this IList<T> list)
    {
        if (list == null || list.Count == 0)
        {
            throw new InvalidOperationException("List is empty.");
        }

        int lastIndex = list.Count - 1;
        T item = list[lastIndex];
        list.RemoveAt(lastIndex);
        return item;
    }

    #endregion
}

public static class NavMeshPathExtensions
{
    public static float InvalidPathLength;
    private static Vector3[] _corners;

    //THÊM PATHCOMPLETE ĐỂ TÍNH TOÁN PATH THÀNH CÔNG THÌ MỚI XÉT CÒN TÍNH TOÁN DỞ DỞ ĐỂ CHẠY THÌ K TÍNH
    //==>>GIẢI QUYẾT ĐƯỢC BUG CHO THẰNG VỊ TRÍ BỊ CHẶN ỞI NAVIGATION:::
    public static bool AssignPath(UnityEngine.AI.NavMeshPath path, Vector3 fromPos, Vector3 toPos, int passableMask = 1)
    {
        fromPos.y = 0;
        toPos.y = 0;
        path.ClearCorners();
        var pathFound = UnityEngine.AI.NavMesh.CalculatePath(fromPos, toPos, NavMesh.AllAreas, path);
        return pathFound && path.status == NavMeshPathStatus.PathComplete;
    }

    public static float GetPathLength(UnityEngine.AI.NavMeshPath path)
    {
        if (path == null)
        {
            return InvalidPathLength;
        }

        int cornerCount = path.GetCornersNonAlloc(_corners);
        if (cornerCount < 2)
        {
            return InvalidPathLength;
        }

        float pathLength = 0f;
        for (int i = 0; i < cornerCount - 1; i++)
        {
            pathLength += Vector3.Distance(_corners[i], _corners[i + 1]);
        }

        return pathLength;
    }

    static NavMeshPathExtensions()
    {
        InvalidPathLength = -1f;
        //_corners = new Vector3[]{};
    }
}

public static class NavMeshAgentExtensions
{
    private static Vector3[] _corners;

    public static float GetRemainingDistance(this UnityEngine.AI.NavMeshAgent navMeshAgent)
    {
        if (navMeshAgent.pathPending)
        {
            return 0f;
        }

        if (navMeshAgent.pathStatus != UnityEngine.AI.NavMeshPathStatus.PathComplete)
        {
            return 0f;
        }

        UnityEngine.AI.NavMeshPath navMeshPath = navMeshAgent.path;

        if (navMeshPath.GetCornersNonAlloc(_corners) == 0)
        {
            return 0f;
        }

        return NavMeshPathExtensions.GetPathLength(navMeshPath);
    }

    static NavMeshAgentExtensions()
    {
        //_corners = new Vector3[NavMeshPathExtensions.MaxCorners];
    }
}

public static class RayCastFromCameraExtensions
{
    public static bool GetHitPlaneFromCamera(out Vector3 hitPosition)
    {
        var tmpCamera = Camera.main;
        if (tmpCamera == null)
        {
            hitPosition = Vector3.zero;
            return false;
        }

        Quaternion rotation = Quaternion.Euler(30f, -45f, 0f);
        Vector3 cameraDirection = rotation * Vector3.forward;
        Vector3 rayStartPosition = tmpCamera.transform.position + cameraDirection * tmpCamera.nearClipPlane;
        Ray ray = new Ray(rayStartPosition, cameraDirection);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            hitPosition = hit.point;
            return true;
        }
        else
        {
            hitPosition = Vector3.zero;
            return false;
        }
    }

    public static bool GetHitPlaneFromPointer(PointerEventData pointerEventData, out Vector3 hitPosition)
    {
        var tmpCamera = Camera.main;
        if (tmpCamera == null)
        {
            hitPosition = Vector3.zero;
            return false;
        }

        Quaternion rotation = Quaternion.Euler(30f, -45f, 0f);
        Vector3 cameraDirection = rotation * Vector3.forward;
        Vector3 rayStartPosition = tmpCamera.transform.position + cameraDirection * tmpCamera.nearClipPlane;
        hitPosition = Vector3.zero;
        return true;
    }

    public static Vector3 GetDistanceTargetCameraPositionFromWorldPosition(Vector3 worldPosition)
    {
        Vector3 hitPosition;
        if (RayCastFromCameraExtensions.GetHitPlaneFromCamera(out hitPosition))
        {
            var distance = worldPosition - hitPosition;
            return distance;
        }

        return hitPosition;
    }
}

public static class ObjectiveTypeExtensions
{
    public static bool IsObjectiveTypeGatherable(ObjectiveType ot)
    {
        return ot >= ObjectiveType.CollectGatherableAny && ot <= ObjectiveType.CollectGatherableType;
    }
}


#region TRADEINFOOOOREQUIREMENT

public static class TradeExtensions
{
    //TradeType_1&IdInType_2&Amount_1|.....
    public static List<TradeInfo> ParseTradeInfoList(string tradeInfoListText)
    {
        List<TradeInfo> tradeInfoList = new List<TradeInfo>();
        string[] tradeInfoStrings =
            tradeInfoListText.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string tradeInfoString in tradeInfoStrings)
        {
            TradeInfo tradeInfo = FromKeyValueString(tradeInfoString.Trim());
            tradeInfoList.Add(tradeInfo);
        }

        return tradeInfoList;
    }

    //TradeType_1&IdInType_2&Amount_1|
    public static TradeInfo FromKeyValueString(string keyValueString)
    {
        TradeInfo tradeInfo = new TradeInfo();
        string[] keyValuePairs = keyValueString.Split('&');
        for (int i = 0; i < keyValuePairs.Length; i++)
        {
            string[] keyValue = keyValuePairs[i].Split('_');
            if (keyValue.Length == 2)
            {
                string key = keyValue[0].Trim();
                string value = keyValue[1].Trim();
                if (key == "TradeType")
                {
                    tradeInfo.TradeType = (TradeType)int.Parse(value);
                }
                else if (key == "IdInType")
                {
                    tradeInfo.IdInType = int.Parse(value);
                }
                else if (key == "Amount")
                {
                    tradeInfo.Amount = int.Parse(value);
                }
                // else if (key == "Currencies")
                // {
                //     if (Currencies.TryParse(value, out Currencies currencies))
                //     {
                //         tradeInfo.Currencies = currencies;
                //     }
                // }
            }
        }

        return tradeInfo;
    }

    //RequirementType_1&Value_2|.....
    public static List<RequirementInfo> ParseRequirementInfoList(string requirementInfoText)
    {
        List<RequirementInfo> listRequirementInfos = new List<RequirementInfo>();

        string[] requirementInfoStrings =
            requirementInfoText.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string requirementInfoString in requirementInfoStrings)
        {
            RequirementInfo requirementInfo = FromKeyValueRequirementString(requirementInfoString.Trim());
            listRequirementInfos.Add(requirementInfo);
        }

        return listRequirementInfos;
    }

    //RequirementType_1&Value_2
    public static RequirementInfo FromKeyValueRequirementString(string keyValueString)
    {
        RequirementInfo requirementInfo = new RequirementInfo();

        string[] keyValuePairs = keyValueString.Split('&');
        for (int i = 0; i < keyValuePairs.Length; i++)
        {
            string[] keyValue = keyValuePairs[i].Split('_');
            if (keyValue.Length == 2)
            {
                string key = keyValue[0].Trim();
                string value = keyValue[1].Trim();
                if (key == "RequirementType")
                {
                    requirementInfo.RequirementType = (RequirementType)int.Parse(value);
                }
                else if (key == "Value")
                {
                    requirementInfo.Value = int.Parse(value);
                }
                // else if (key == "Currencies")
                // {
                //     if (Currencies.TryParse(value, out Currencies currencies))
                //     {
                //         requirementInfo.Currencies = currencies;
                //     }
                // }
            }
        }

        return requirementInfo;
    }

    public static TradeInfo ToTradeInfo(this Currency currency)
    {
        TradeInfo tradeInfoCost = new TradeInfo
        {
            TradeType = TradeType.Currency, Amount = (int)currency.Amount,
            IdInType = (int)Currency.GetCurrencyTypeByName(currency.Name)
        };
        return tradeInfoCost;
    }
    
    public static List<TradeInfo> ToTradeInfos(this Currencies currencies)
    {
        List<TradeInfo> results = new List<TradeInfo>();
        if (currencies == null) return results;
        for (int i=0; i < currencies.KeyCount; i++)
        {
            var currency = currencies.GetCurrency(i);
            TradeInfo tradeInfoCost = new TradeInfo { TradeType = TradeType.Currency, Amount = (int)currency.Amount, IdInType = (int)Currency.GetCurrencyTypeByName(currency.Name) };
            results.Add(tradeInfoCost);
        }
        
        return results;
    }
}

#endregion