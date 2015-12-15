using UnityEngine;
using System.Collections;

public class Align_button : MonoBehaviour {
	public GameObject main_cam;
	//public GameObject kirin;

	Vector3 point_O=new Vector3(0,1,-10);
	Quaternion rot=Quaternion.Euler (25,315,0);

	void Start(){

	}

	public void OnMouseDown(){

			Debug.Log ("Button push");
			//kirin.transform.Rotate (Vector3.up*5.0f);
			//kirin.transform.position = point_O;
			
			main_cam.transform.position = point_O;
			main_cam.transform.localEulerAngles = new Vector3 (25, 315, 0);

		}


}
