using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public string enemyType;
	public enum Direction {
		Up,
		Down
	}
	public Direction dir;

	void Awake()
	{
		tag = "Enemy";
	}

	void Update()
	{
		if (dir == Direction.Down)
		{
			transform.Translate (Vector3.down * 0.1f);
		}
		else
		{
			transform.Translate (Vector3.up * 0.1f);
		}
	}
}
