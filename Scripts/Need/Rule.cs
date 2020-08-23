using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public abstract class Rule : MonoBehaviour 
{
	public string ruleName; // make abstract?
	//virtual string ruleName;
	/*public Rule(string condName){
		this.condName = condName;
	}*/ // create Rules once on the editor itself.
	
	// public event?
	//dict?
	
	// each decendent adds relevant fields/variables
	
	public abstract bool isSatisfied(Need need) ;
	//{
	//	return false;
	//}
	
}

