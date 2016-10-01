using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    float speed = 3f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		int vx = (int)Input.GetAxisRaw ("Horizontal");
		int vy = (int)Input.GetAxisRaw ("Vertical");
    }
}
