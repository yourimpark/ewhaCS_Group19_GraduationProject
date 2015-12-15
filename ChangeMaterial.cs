using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {
	public Material[] materials;
	void Start()
	{
		//make material into Material folder
	}
	void changeMaterialColor(int index)
	{
		this.GetComponent<MeshRenderer> ().material = materials[index];
	}

}
