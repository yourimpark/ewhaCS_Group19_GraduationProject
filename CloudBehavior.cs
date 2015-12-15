using UnityEngine;
using System.Collections;

public class CloudBehavior : MonoBehaviour {
	public float speed = 4.0f;

	// Update is called once per frame
	void Update () {
			Vector3 temp = transform.position;
			temp.x -= speed *Time.deltaTime;
			transform.position = temp;
	}
		
	void OnBecameInvisible()
	{
		Destroy (this.gameObject);
	}
}
