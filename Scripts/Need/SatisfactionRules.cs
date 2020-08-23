using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SatisfactionRules : MonoBehaviour
{
	
	//public dictionary Rules (collection)
	// class of Rule - starts here maybe moves out to seperate script
	//public Dictionary<KeyValuePair<Rule, Need>, bool> rules;
	//test:
	public List<Rule> rules;
	// Something like: <highTemperature, Taste> -> true
	//				   <cryThreeTimesInRow, Hunger> -> true
	//					etc.
	
	
	
	// - matches Rules, needs and true/false
	
	// - - list of needs
	//public List<Need> needs;
	// - - list of 
	
	public void AttemptSatisfy(Need need, float increaseRate, string ruleName){
		//get component by name (ruleName)
		//Rule rule = this.FindObjectsOfType<typeof(Rule)>().ToList().Find( x=>x.name == ruleName + " Rule");
		
		Rule rule = rules.Find(x => x.ruleName == ruleName);
		//Rule rule = rules[0];
		
		//Rule rule = GameObject.Find(ruleName + " Rule").GetComponent<Rule>();
		
		//Rule rule = GameObject.Find( x => x.name == (ruleName + " Rule"));
		//Rule rule = this.FindObjectsOfType<typeof(Rule)>()
		
					
		if (rule.isSatisfied(need))
		{
			need.Satisfy(increaseRate);
		}
		
		// if (satisfactionRules.AttemptSatisfy(asphyx, "Breathe")){ // maybe later get name from function name
		//	//asphyx.Satisfy(breathingRate);
		//}
	}
	
	public void Start(){
		
	}
	
    //public update Rules
}

