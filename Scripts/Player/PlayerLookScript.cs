﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookScript : MonoBehaviour
{
	
	public float mouseSensitivity = 500f;
	
	public Transform playerBody;
	
	float xRotation = 0f;
	float yRotation = 0f;
	
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
		
		xRotation += mouseY;
		xRotation = Mathf.Clamp(xRotation, -45f, 45f);
		
		yRotation += mouseX;
		
		playerBody.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
		
				
    }
}
