using UnityEngine;
using System.Collections;

public class GetMoneyManager : MonoBehaviour {
	public GameObject[] obj;
	// Use this for initialization
	void Start () {
		obj = GameObject.FindGameObjectsWithTag("Purchased");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
