using UnityEngine;
using System.Collections;

public class Ladder : MonoBehaviour {

	public Transform[] ladderPieces;
	public float lowerBound;
	public float upperBound;

	public void Update()
	{
		foreach (Transform tr in ladderPieces)
		{
			tr.Translate (Vector3.down * 0.05f);
			if (tr.position.y < lowerBound)
			{
				tr.position = new Vector3 (tr.position.x, upperBound);
			}
		}
	}
}
