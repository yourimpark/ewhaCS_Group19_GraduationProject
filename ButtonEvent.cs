using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour {
	public GameObject events;
	public Button houseSelect;
	public Button settleButton;
	/*
	public void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space) && houseSelect.interactable == false) {
			Destroy (GameObject.Find ("ModelSettle 1(Clone)"));

			houseSelect.interactable = true;
		}

	}*/
	public void HouseGenerate()
	{
		//GameObject newObj = (GameObject)Instantiate(events, new Vector3(0,0,0), Quaternion.identity);
		//settleButton.posX
		houseSelect.interactable = false;

	}
}