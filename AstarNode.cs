using UnityEngine;
using System.Collections;

public class AstarNode :MonoBehaviour {


	public string matrix;
	public int x,z,F,G,H;
	// 노드의 x,z값을 저장하고 key값과 같이 노드들을 구별하기 위해 matrix라는 스트링을 만든다
	// F = G + 2 * H
	// G : 지나온 거리 
	// H : 남은 거리
	// 가중치를 다르게 해야지 길을 찾는다	
	
}
