using UnityEngine;

public class LoginAccount : MonoBehaviour
{
    private static LoginAccount instance;

    private string deviceId;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoginGuest()
    {
        if (PlayerPrefs.HasKey("deviceId"))
        {
             deviceId = PlayerPrefs.GetString("deviceId");
        }
        else
        {
            deviceId = GetDeviceId();
            PlayerPrefs.SetString("deviceId",deviceId);
        }
      
    }
    public string GetDeviceId()
    {
        var id = SystemInfo.deviceUniqueIdentifier;
        return id;
    }
}
