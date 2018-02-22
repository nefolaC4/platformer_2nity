﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (controller2D))]
public class playerScript : MonoBehaviour {

    float moveSpeed = 6;
    float gravity = -20;
    Vector3 velocity;

    controller2D controller;
	
	void Start () {

        controller = GetComponent<controller2D>();
	}

    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        velocity.x = input.x * moveSpeed;
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
