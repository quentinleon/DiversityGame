using UnityEngine;
using System.Collections;

public class Staging : MonoBehaviour {

    public float progress;
    public EnemySpawner manSpawn;
    public EnemySpawner enemySpawn;
    //public GameObject baby;

	// Use this for initialization
	void Start () {
        progress = 0;
        manSpawn.gameObject.SetActive(false);
    }
	
    // 0-30 college
    // 30-60 intern
    // 60-90 engineer
    // 90-120 senior engineer
    // 120-150 vice president
    // 150-180 CEO

	// Update is called once per frame
	void Update () {
        progress += Time.deltaTime * 3;
        gameObject.transform.position = new Vector3(-7.45f, (float)(-4.65 + (progress / 180 * 9.3)), 0);
        if (progress > 30) {
            if (!manSpawn.gameObject.activeSelf) {
                manSpawn.gameObject.SetActive(true);
            }
        }
        if (progress > 60) {
            enemySpawn.spawnInterval = 2;
        }
        if (progress > 90) {
            enemySpawn.spawnInterval = 1.7f;
        }
        if (progress > 120) {
            enemySpawn.spawnInterval = 1.5f;
        }
        if (progress > 150) {
            //spawnBaby
        }

    }
}
