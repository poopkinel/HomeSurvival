using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class MixCondition : Condition
{
	// here conditions are set ( = defined )
	
	/*
	public List<Resource> mixFirsts;
	public List<Resource> mixSeconds;
	public List<Resource> mixResults;
	*/
	
	public List<GameObject> mixFirstsGO;
	public List<GameObject> mixSecondsGO;
	public List<GameObject> mixResultsGO;
	
	//public GameObject resultResourceGO;
	
	public override bool Check(List<Resource> Resources){
	//public override bool Check(Resource first, Resource second){
		int index = 0;
		for (int i = 0; i<mixFirstsGO.Count; i++){
			var mixFirst = mixFirstsGO[i].GetComponent<Resource>();
			if (mixFirst == Resources[0])
			{
				var mixSecond = mixSecondsGO[i].GetComponent<Resource>();
				if (mixSecond == Resources[1]){
					return true;
				}
			}
		}
		return false;
		
	}
	
	public override List<Resource> PerformSuccessful() {
		List<Resource> resultResources = new List<Resource>(); // for now, testing
		//GameObject.Find(resultResource.name).SetActive(true);
		for (int i=0; i<mixResultsGO.Count; i ++){
			mixResultsGO[i].SetActive(true);
		}
		/*
		for (int i=0; i < mixResults.Count; i ++){
			resultResources.Add(mixResults[i]);
		}
		*/
		return resultResources; // temp - empty list
	}
	
	
	public override List<Resource> PerformUnsuccessful() {
		List<Resource> resultResources = new List<Resource>(1); // for now, testing
		// test
		return resultResources; // empty list
	}
	
	
    // Start is called before the first frame update
    void Start()
    {
		// temp for testing - should set active to false only for non-initial objects 
		for (int i=0;i<mixResultsGO.Count;i++)
		{	
			//resultResourceGO.SetActive(false);
			mixResultsGO[i].SetActive(false);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
