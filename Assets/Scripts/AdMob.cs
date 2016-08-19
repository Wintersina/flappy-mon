using UnityEngine;
using System.Collections;
using admob;

public class AdMob : MonoBehaviour {

	public static AdMob Instance{ set; get; }

	public string bannerId= "ca-app-pub-7820479853095722/3214882293";
	// Use this for initialization
	void Start () {

		Instance = this;
		DontDestroyOnLoad (gameObject);
		#if UNITY_EDITOR
		#elif UNITY_ANDROID
		Admob.Instance().initAdmob(bannerId, "ca-app-pub-7820479853095722/3214882293");
		Admob.Instance().setTesting(true);
        displayAdds();
		#endif

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void displayAdds(){
		#if UNITY_EDITOR
		#elif UNITY_ANDROID
		Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.BOTTOM_CENTER, 0);
		#endif
	
	}
}
