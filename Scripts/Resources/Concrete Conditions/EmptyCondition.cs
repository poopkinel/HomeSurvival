using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyCondition : Condition
{
    public override bool Check(List<Resource> Resources){
		return true;
	}
	
	public override List<Resource> PerformSuccessful(){
		List<Resource> resources = new List<Resource> {};
		return resources;
	}
	
	public override List<Resource> PerformUnsuccessful(){
		List<Resource> resources = new List<Resource> {};
		return resources;
	}
	
}
