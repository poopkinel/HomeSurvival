using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rottable : MonoBehaviour
{
	
	public Resource resource;
	public GameObject gameObject;
	
	public float rotRate = 0.01f;
	
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onRotTrigger += OnRot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnDestroy()
	{
		GameEvents.current.onRotTrigger -= OnRot;
	}
	
	
	public void OnRot()
	{
		if (resource.rotLevel == null){
			resource.rotLevel = rotRate;
		}
		else {
			resource.rotLevel += rotRate;
		}
	}

}
