﻿using UnityEngine;
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
		int vx = (int)Input.GetAxisRaw ("Horizontal");
		position += speed * vx * Time.deltaTime;
		gameObject.transform.position = Vector3.ClampMagnitude(new Vector3(position * 3, 0, 0), 3);
    }
}