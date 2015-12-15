using UnityEngine;
using System.Collections;

public class Outliner : MonoBehaviour {
	public LineRenderer lineRenderer;

	// Use this for initialization
	void Start () {
		lineRenderer.SetColors(Color.red, Color.red);
		lineRenderer.SetWidth(1f, 1f);
		lineRenderer.SetVertexCount(25);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
