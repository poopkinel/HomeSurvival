using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Need : MonoBehaviour {
	
	public string needName;
	public float depleteRate;
	public float min = 0, max, current;
	//public Panel deathPanel;
	
	void Start(){
		current = max;
	}
	
	public void UpdateCurrent(){
		if (current - depleteRate <= 0){
			current = 0;
		}
		else {
			current -= depleteRate;
		}
	}
	
	public void Satisfy(float increase){
		if(current + increase > max){
			current = max;
		}
		else{
			current += increase;
		}
	}
	
}

[System.Serializable]
public class UnknownNeed : Need {

	//public float increaseRate; // this is for unknown needs
	public string needName = "Unknown"; // maybe "?" or ""
	
}

