using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class BreatheRule : Rule
{
	public Need needToSatisfy;
	
	//public override string ruleName {
	//	get { return "BreatheRule"; }
	//}
	
	//ruleName = "BreatheRule";
	
    // Start is called before the first frame update
    void Start()
    {
		//public string ruleName = "BreatheRule";
		//override ruleName = "BreatheRule";
		ruleName = "BreatheRule";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	// add logic and need comparison
	public override bool isSatisfied(Need need){
		// return isSatisfied() && need == asphysxiation
		return true; // test
		/*
		if (need == needToSatisfy){
			return true;
		}
		return false;
		*/
	}
	
}
