using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float position; // -1 to 1

    float speed = 3f;

	// Use this for initialization
	void Start () {
        position = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey("a") && position > -1){
            position -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d") && position < 1) {
            position += speed * Time.deltaTime;
        }
        gameObject.transform.position = new Vector3(position * 3, 0, 0);
    }
}
