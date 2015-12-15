using UnityEngine;
using System.Collections;

public class FloorGenerator : MonoBehaviour {
	public Transform prefab;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			for(int j=0;j<10;j++)
			{
				Transform obj = (Transform) Instantiate(prefab, new Vector3(-4.5f+i,-1,-4.5f+j), Quaternion.identity);
				obj.tag = "Grass";
				obj.parent = this.gameObject.transform;
			}
		}
	}
}
