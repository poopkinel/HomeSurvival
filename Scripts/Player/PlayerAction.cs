using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class PlayerAction : MonoBehaviour
{
	public EventLogic eventLogic;
	// temp for testing
	public Resource egg;
	public Resource pan;
	
	//public SatisfactionRules satisfactionRules;
	
	// split to UI - the Rect, 
	// and read a list of needs from the Needventory
	public Needventory needventory;
	
	
	// Satisfaction Rules
	public SatisfactionRules satisfactionRules;
	
	//public RectTransform oxygen;
	// OK
	// make private
	public float breatheRate = 0.1f;
	public float cryForFoodRate = 0.1f; // should this be in need somewhere?
	// TODO: Move to Need
	//public float maxOxygen = 0.7f;
	// Done
	
	// Actions
	// TODO: Change content to 
	//		AttemptSatisfy(Need Asphyxiation, float breatheRate);
	public void Breathe()
	{
		Need asphyx = needventory.needs.Find(x => x.needName == "Asphyxiation");

		// Add (empty) satisfaction rule to check:
		
		satisfactionRules.AttemptSatisfy(asphyx, breatheRate, "BreatheRule");
		//if (satisfactionRules.AttemptSatisfy(asphyx, "Breathe")){ // maybe later get name from function name
		//	//asphyx.Satisfy(breatheRate);
		//	needventory.needs[0].Satisfy(breatheRate);
		//}
		
		// then move this to needs manager
		/*Vector3 temp = oxygen.localScale;
		temp.y += breatheRate;
		temp.y = Mathf.Clamp(temp.y, 0f, maxOxygen);
		oxygen.localScale = temp;*/
		
	}
	
	public void CryForFood() // is it "Cry" or "CryForFood"? Is this an unknown needs?
	{
		//Create the need Hunger and link up in inspector
		Need hunger = needventory.needs.Find(x => x.needName == "Hunger");
		//implement AttemptSatisfy for Hunger
		satisfactionRules.AttemptSatisfy(hunger, cryForFoodRate, "CryForFoodRule");
			
	}
	
    void Start()
    {
        
    }

	//public void MixTwo(Resource first, Resource second)
	public void Mix(List<Resource> resources)
	{
		//eventLogic.AttemptAction(first, second, "Mix");
		eventLogic.AttemptAction(resources, "Mix");
	}
	
    void Update()
    {
		// Match Input from Keyboard to Action
		
        if (Input.GetKeyDown(KeyCode.B)){
			Breathe();
		}
		if (Input.GetKeyDown(KeyCode.C)){
			CryForFood();
		}
		
		if (Input.GetKeyDown(KeyCode.T)){
			GameEvents.current.EatTrigger();
		}
		
		//
		
		if (Input.GetKeyDown(KeyCode.M)){
			// for temp testing
			List<Resource> tempResources = new List<Resource> { egg, pan };//egg, pan } ;
			Mix(tempResources);
			//MixTwo(egg, pan);
		}
    }
}
