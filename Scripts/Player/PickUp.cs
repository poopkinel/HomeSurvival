using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
	public Transform itemDest;
	//public RectTransform hunger ;
	//public RectTransform thirst ;

	//float feedingRate = 0.1f;
	//float maxFood = 0.7f;
	
	//float drinkingRate = 0.4f;
	//float maxFluid = 0.7f;
    
	bool itemGrab = false;
	public void Update(){
		
		if(Input.GetKeyUp(KeyCode.E)){
			itemGrab = !itemGrab;
		}	
		if (itemGrab){
			onItemHeld();
		}
		else { 
			onItemReleased();
		}
	}
	
	public void onItemHeld() { // on press "E"
		GetComponent<Collider>().enabled = false;
		GetComponent<Rigidbody>().useGravity = false;
		this.transform.position = itemDest.position;
		this.transform.parent = GameObject.Find("First Person Player").transform;
		
		/*if (Input.GetKeyUp(KeyCode.C)){
			Vector3 h = hunger.localScale;
			h.y += feedingRate;
			h.y = Mathf.Clamp(h.y, 0.2f, maxFood);
			hunger.localScale = h;			
			
			Vector3 t = thirst.localScale;
			t.y += drinkingRate;
			t.y = Mathf.Clamp(t.y, 0.2f, maxFluid);
			thirst.localScale = t;	
		}
		*/
	}
	public void onItemReleased(){
		this.transform.parent = null;
		GetComponent<Rigidbody>().useGravity = true;
		GetComponent<Collider>().enabled = true;
	}
}
		 