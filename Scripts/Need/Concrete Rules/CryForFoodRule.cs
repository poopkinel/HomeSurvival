using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class CryForFoodRule : Rule
{
	public Need needToSatisfy;
	
	public override bool isSatisfied(Need need)
	{
		if (! need == needToSatisfy){
			return false;
		}
		// add patterns of crying
		return true; // temp result
	}
	
    // Start is called before the first frame update
    void Start()
    {
        ruleName = "CryForFoodRule";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
