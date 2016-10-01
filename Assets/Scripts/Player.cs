using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public bool dead;
    public float position; // -1 to 1

    float speed = 3f;

	// Use this for initialization
	void Start () {
        GetComponent<Animator>().SetBool("dead", false);
        dead = false;
        position = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (!dead) {
            int vx = (int)Input.GetAxisRaw("Horizontal");
            position += speed * vx * Time.deltaTime;
            gameObject.transform.position = Vector3.ClampMagnitude(new Vector3(position * 3, 0, 0), 3);
        }
    }

    void OnTriggerEnter2D(Collider2D coll) {
        dead = true;
        GetComponent<Animator>().SetBool("dead", true);
        GetComponent<Rigidbody2D>().velocity = new Vector2(4, 7);
        print(coll);
    }
}
