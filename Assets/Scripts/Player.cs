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
<<<<<<< HEAD:Assets/Player.cs
        if(Input.GetKey("a") && position > -1){
            position -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d") && position < 1) {
            position += speed * Time.deltaTime;
        }
        gameObject.transform.position = new Vector3(position * 3, 0, 0);
=======
        progress += Time.deltaTime;
		int vx = (int)Input.GetAxisRaw ("Horizontal");
		position += speed * vx * Time.deltaTime;
		gameObject.transform.position = Vector3.ClampMagnitude(new Vector3(position * 3, 0, 0), 3);
>>>>>>> 53ca6764c438fa7cb86361591d231b5c10d26faf:Assets/Scripts/Player.cs
    }
}
