using UnityEngine;
using System.Collections;
using admob;

public class AdMob : MonoBehaviour {



	// Use this for initialization
	void Start () {

		Admob.Instance().initAdmob("admob banner id", "ca-app-pub-7820479853095722/3214882293");
		Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.BOTTOM_CENTER, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
