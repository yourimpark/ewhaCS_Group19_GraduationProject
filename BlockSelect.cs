using UnityEngine;
using System.Collections;

public class BlockSelect : MonoBehaviour {
	public Material currentMaterial;
	public Color currentButtonColor;
	// Use this for initialization
	void Start () {
		
	}
	
	public void ChangeBlockMaterial()
	{
		currentMaterial.color = currentButtonColor;
	}
}
