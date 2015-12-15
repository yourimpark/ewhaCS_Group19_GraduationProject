using UnityEngine;
using System.Collections;

public class PurchaseScript : MonoBehaviour {

	Transform activatedModel;
	//public GameObject purchased;
	Main_SaveAndLoad mainsave;

	void Start()
	{
		mainsave = GetComponent<Main_SaveAndLoad> ();
	}

	public void RememberCurrent()
	{
		activatedModel = GameObject.Find ("_Manager").GetComponent<ModelMovementInMain>().movingModels;
		if (activatedModel == null) {
			//activatedModel = 
		}
	}
	//call after 
	public void SetModelPurchased()
	{
		activatedModel.gameObject.tag = "Purchased";
		Transform g_transform = activatedModel.transform;
		//activatedModel.SetParent (purchased.transform, true);
		mainsave.SavePurchasedModel (activatedModel.name,g_transform);
	}


}
