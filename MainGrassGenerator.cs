using UnityEngine;
using System.Collections;



/******************************************************************************************  
 ****************************************         *********************************** 
 ******************************************************************************************/
public class MainGrassGenerator : MonoBehaviour {

	public Transform prefab;
	public Transform dirt_prefab;
	public int blockSize;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < blockSize; i++) {
			for(int j=0;j<blockSize;j++)
			{
				Transform obj = (Transform) Instantiate(prefab, new Vector3(i-50,0,j-50), Quaternion.identity);
				obj.parent = this.gameObject.transform;
				Transform dirt = (Transform) Instantiate(dirt_prefab, new Vector3(i-50,-1.5f,j-50), Quaternion.identity);
				dirt.parent = this.gameObject.transform;
			}
		}
	}
}
