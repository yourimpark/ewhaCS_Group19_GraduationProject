using UnityEngine;
using System.Collections;

public class BlockAsset : MonoBehaviour {
	
	public static BlockAsset instance;
	
	// Use this for initialization
	void Start () {
		
		instance = this; 
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate(Vector3.up * 5.0f);
	}
	
}
