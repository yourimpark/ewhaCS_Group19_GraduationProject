using UnityEngine;
using System.Collections;

public class CloudGenerator : MonoBehaviour {

	public GameObject[] cloud_prefab = new GameObject[4];	

	void GenerateCloud()
	{
		int i = Random.Range (0, 3);
		int rand_speed = Random.Range (3, 6);
		int pos_z = Random.Range (-100, 50);
		int pos_y = Random.Range (40, 70);
		GameObject cloud = (GameObject)Instantiate (cloud_prefab [i], new Vector3 (70, pos_y, pos_z),Quaternion.identity);
		cloud.GetComponent<CloudBehavior> ().speed = rand_speed;
		cloud.transform.SetParent (this.gameObject.transform);
		StartCoroutine (DestroyTime (cloud));
	}
	IEnumerator DestroyTime(GameObject obj)
	{
		yield return new WaitForSeconds (40);
		Destroy (obj);
	}
	void Start()
	{
		InvokeRepeating ("GenerateCloud", 0, 10);
	}
	
}
