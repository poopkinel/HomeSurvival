﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour
{
	
	public Animator anim;
	
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C)){
			anim.Play("drinkAnimation");
			//GetComponent<BoxCollider>().enabled = false;
			// replentish hunger
			
		}
    }
}
