using UnityEngine;
using System.Collections;

public class FloorGenerator_House : MonoBehaviour {
	public Transform prefab;
	// Use this for initialization
	void Awake () {
		for (int i = 0; i < 30; i++) {
			for(int j=0;j<30;j++)
			{
				Transform obj = (Transform) Instantiate(prefab, new Vector3((float)(i-15),0,(float)(j-15)), Quaternion.identity);
				obj.tag = "Grass";
				obj.gameObject.GetComponent<MeshRenderer>().material.color = new Color32(107,64,52,255);
				obj.parent = this.gameObject.transform;
				
			}
		}
	}
}
