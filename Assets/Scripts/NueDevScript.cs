using UnityEngine;
using System.Collections;

public class NueDevScript : MonoBehaviour {

	private float timer;

	// Use this for initialization
	void Start () {
		timer = 3f;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Application.LoadLevel("mainGame");
		}
	}
}
