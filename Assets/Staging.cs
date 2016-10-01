using UnityEngine;
using System.Collections;

public class Staging : MonoBehaviour {

    public float progress;

	// Use this for initialization
	void Start () {
        progress = 0;
 	}
	
    // 0-30 college
    // 30-60 intern
    // 60-90 engineer
    // 90-120 senior engineer
    // 120-150 vice president
    // 150-180 CEO

	// Update is called once per frame
	void Update () {
        progress += Time.deltaTime;
        gameObject.transform.position = new Vector3(-7.45f, (float)(-4.65 + (progress / 180 * 9.3)), 0);
	}
}
