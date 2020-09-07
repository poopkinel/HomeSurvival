using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class EventLogic : MonoBehaviour
{
	// Resource[] ? better?
	public List<Resource> activeResources;
	
	// This script is where we check if conditions are successful or not -
	// here the Check() function is performed.
	
	public Condition actionCondition;
	//public Resource 
	public Condition EmptyResource;
	
	//this function is called by 
	public List<Resource> AttemptAction(List<Resource> attemptResources, string action)
	//public List<Resource> AttemptAction(Resource first, Resource second, string action)
	{
		// change to : find the condition actionCondition by action string
		//if (actionCondition.Check(first, second)){
		if (actionCondition.Check(attemptResources)){
			//return actionCondition.PerformSuccessful(first, second);
			return actionCondition.PerformSuccessful();
		}
		else {
			//return actionCondition.PerformUnsuccessful(first, second);
			return actionCondition.PerformUnsuccessful();
		}
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
		for (int i=0; i<activeResources.Count; i++){
			//if (activeResources[i])
			activeResources[i].Decay();
		}
		*/
    }
}
