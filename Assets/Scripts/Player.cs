﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Desinger variables

    public float speed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // get axis input from Unity
        float leftRight = Input.GetAxis(horizontalAxis);
        float upDown = Input.GetAxis(verticalAxis);

        // Create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, upDown);

        // Make direction vector length 1
           direction = direction.normalized;

        // Calculate velocity

        Vector2 velocity = direction * speed;

        // Give the velocty to the rigid body


        physicsBody.velocity = velocity;
	}
}
