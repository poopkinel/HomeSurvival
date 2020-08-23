﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController controller;
	
	
	public float speed = 9f;
	
	public Vector3 velocity;
	
	public float gravity = -9.81f;
	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;
	
	bool isGrounded;
	
    // Update is called once per frame
    void Update()
    {
		// First attempt
		//isGrounded = Physics.CheckSphere(groundCheck, groundDistance, groundMask);
		// Second attempt
	    isGrounded = Physics.Raycast(groundCheck.position, -Vector3.up, groundDistance + 0.4f);
 
		if (isGrounded && velocity.y < 0){
			velocity.y = -2f;
		}
		
        float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		
		Vector3 move = transform.right * x + transform.forward * z;
		velocity.y += gravity * Time.deltaTime * Time.deltaTime;
		
		controller.Move((move+velocity) * speed * Time.deltaTime);
    }
}
