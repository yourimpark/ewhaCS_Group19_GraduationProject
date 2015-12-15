using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic; 

[System.Serializable] 
public class BlockInfo{

	public string model_name;
	public int useCount;
	public int talent;

	public Vector3[] block_position;
	public Color[] block_color;

	public BlockInfo()
	{
	}

	public BlockInfo(string name, int count, int newTalent, Vector3[] pos, Color[] colors)
	{
		model_name = name;
		useCount = count;
		talent = newTalent;
		block_position = pos;
		block_color = colors;
	}
}
