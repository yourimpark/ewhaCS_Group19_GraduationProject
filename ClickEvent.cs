using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickEvent : MonoBehaviour {
	private int color_index;
	GameObject sample_block;
	// Use this for initialization
	void Start () {
		sample_block = GameObject.Find ("Sample_Cube");
		GetComponent<Button>().onClick.AddListener(() => Sample_Show ());
	}

	
	void Sample_Show()
	{
		sample_block.GetComponent<MeshRenderer> ().material.color = this.GetComponent<Image> ().color;
		GameObject.Find ("_Manager").GetComponent<StoreManager>().current_index = color_index;
	}
	
	public void SetColorIndex(int i)
	{
		color_index = i;
	}
	public int GetColorIndex()
	{
		return color_index;
	}
}
