using UnityEngine;
using System.Collections;

public class MouseNavi : MonoBehaviour {
	float speed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Translate
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");
		
		Vector3 delta = this.transform.right * horizontal;
		delta += this.transform.up * vertical;
		
		delta = delta.normalized * speed;
		
		//Debug.Log(delta);
		
		this.transform.position += delta;
	}
}
