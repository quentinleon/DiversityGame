using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
	public GameObject[] enemies;
	public float spawnXRange;
	public float spawnY;
	public float spawnInterval;

	void Start()
	{
		StartCoroutine ("SpawnEnemyLoop");
	}

	void Update()
	{
		
	}

	private IEnumerator SpawnEnemyLoop()
	{
		while (true)
		{
			// spawn random enemy
			SpawnEnemy (Random.Range(0, enemies.Length));
			yield return new WaitForSeconds (spawnInterval);
		}
	}

	private void SpawnEnemy(int index)
	{
		GameObject o = Instantiate (enemies [index]);
		o.transform.position = new Vector2 (Random.Range (-spawnXRange, spawnXRange), spawnY);
	}
}

