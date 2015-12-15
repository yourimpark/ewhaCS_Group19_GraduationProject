using UnityEngine;
using System.Collections; 

public class CoinAsset : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		transform.Rotate(Vector3.up * 5.0f);

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;  
		if (Input.GetMouseButtonDown (0)) {
			if (Physics.Raycast (ray, out hit)) {
				//print(hit.collider.transform.parent.gameObject);
				if(hit.collider.transform.parent.gameObject == this.gameObject)
				{
					//print ("asd");
					int num = this.gameObject.GetComponentInParent<ControllerETC>().GetCubeCount();
					GameObject.Find ("_Manager").GetComponent<GoldManager>().IncreaseCurrentMoney(num*10);
					this.gameObject.SetActive (false);
					//print ("gettingCoin:"+cube_count*appearTime);
					this.transform.GetComponentInParent<ControllerETC>().get_coin = true;
				}
			}
		}

	}

}
