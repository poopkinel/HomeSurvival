using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class EatRule : Rule
{
	// this should be a list
	public Need needToSatisfy;
	
    // Start is called before the first frame update
    void Start()
    {
        ruleName = "EatRule";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	// this might also should be a list of needs
	public override bool isSatisfied(Need need) {
		if (true) // how do I access the food eaten here?
		{
			return true;
		}
	}
	
}
