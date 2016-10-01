using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float progress; // game lasts 200 seconds
    public float position; // -1 to 1

    float speed = 3f;

	// Use this for initialization
	void Start () {
        position = 0;
        progress = 0;
	}
	
	// Update is called once per frame
	void Update () {
        progress += Time.deltaTime;
        if(Input.GetKey("a") && position > -1){
            position -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d") && position < 1) {
            position += speed * Time.deltaTime;
        }
        gameObject.transform.position = new Vector3(position * 5, 0, 0);
    }
}
