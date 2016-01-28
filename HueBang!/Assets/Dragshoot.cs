using UnityEngine;
using System.Collections;

public class Dragshoot : MonoBehaviour {

	private double charge = 0;
	private bool click = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonUp (0)) {
			charge = Input.mousePosition.y;
			click = false;
		}
	
	}


	void OnMouseDrag(){
		if (!click) {
			if (Input.GetMouseButtonDown (0)) {
				charge = Input.mousePosition.y;
				click = true;
			}
		}

		Vector3 objectPointInScreen = Camera.main.WorldToScreenPoint (this.transform.position);
		Vector3 mousePointInScreen = new Vector3 (Input.mousePosition.x,
			                             Input.mousePosition.y,
			                             objectPointInScreen.z);
		Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint (mousePointInScreen);
		mousePointInWorld.z = this.transform.position.z;
		//this.transform.localScale.y = mousePointInWorld;

	}


}
