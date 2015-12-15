using UnityEngine;
using System.Collections;



public class GrassGenerator : MonoBehaviour {
	public Transform prefab;
	public static Vector2[] grassPosition;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			for(int j=0;j<10;j++)
			{
				Instantiate(prefab, new Vector3((i-5)*2 + 1, -1.4f, (j-5)*2 + 1), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
