using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BoostIcon : MonoBehaviour
{
	public Text boostCount;
	public BoostType type;
	bool check;

	void OnEnable ()
	{
		if (name != "Main Camera") {
			if (LevelManager.Instance != null) {
				if (LevelManager.Instance.gameStatus == GameState.Map)
					transform.Find ("Indicator/Image/Check").gameObject.SetActive (false);
//				if (!LevelManager.Instance.enableInApps)
//					gameObject.SetActive (false);
			}

		}
	}

	public void OpenBoostShop (BoostType boosType)
	{
		SoundBase.Instance.GetComponent<AudioSource> ().PlayOneShot (SoundBase.Instance.click);
		GameObject.Find ("CanvasGlobal").transform.Find ("BoostShop").gameObject.GetComponent<BoostShop> ().SetBoost (boosType);
	}

	void ShowPlus (bool show)
	{
		transform.Find ("Indicator").Find ("Plus").gameObject.SetActive (show);
	}


	void Update ()
	{
		//if (boostCount != null) {
		//	boostCount.text = "" + PlayerPrefs.GetInt ("" + type);
		//	if (!check) {
		//		if (BoostCount () > 0)
		//			ShowPlus (false);
		//		else
		//			ShowPlus (true);
		//	}
		//}
	}
}
