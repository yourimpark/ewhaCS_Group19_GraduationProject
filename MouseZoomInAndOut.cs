using UnityEngine;
using System.Collections;

public class MouseZoomInAndOut : MonoBehaviour {
	const int orthographicSizeMin = 1;
	const int orthographicSizeMax = 50;
	void LateUpdate () 
	{
		if(Input.GetAxis ("Mouse ScrollWheel")<0){
			Camera.main.orthographicSize++;
		}
		if (Input.GetAxis ("Mouse ScrollWheel")>0) {
			Camera.main.orthographicSize--;
		}
		Camera.main.orthographicSize = Mathf.Clamp (Camera.main.orthographicSize, orthographicSizeMin, orthographicSizeMax);
	}
}
