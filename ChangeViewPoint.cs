using UnityEngine;
using System.Collections;

public class ChangeViewPoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			Vector3 tmp = this.transform.eulerAngles;
			tmp.y -= 90;
			transform.eulerAngles = tmp;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			Vector3 tmp = this.transform.eulerAngles;
			tmp.y += 90;
			transform.eulerAngles = tmp;
		} else if (Input.GetMouseButtonDown (1)) {
			
		}
	}
}
