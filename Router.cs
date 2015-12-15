using UnityEngine;
using System.Collections;

public class Router : MonoBehaviour {

	public void Goto_Main()
	{
		Application.LoadLevel ("Main");
	}

	public void Goto_BlockShop()
	{
		Application.LoadLevel ("BlockShop");
	}
	
	public void Goto_Editor()
	{
		Application.LoadLevel ("attach");
	}

	public void GoToTalentScene()
	{
		Application.LoadLevel ("TalentScene");
	}
}
