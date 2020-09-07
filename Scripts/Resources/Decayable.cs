using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Decayable : MonoBehaviour
{	
	//public EventLogic eventLogic; // should handle SetActive for resources
	public GameObject gameObject;
	public Resource resource;

	public float currentDecay = 1f;
	public float decayThreshold = 0f;
	public float decayRate = 0.001f;
	
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onDecayTrigger += OnDecay;
    }

    // Update is called once per frame
    void Update()
	{
		
	}
	
	void OnDestroy()
	{
		GameEvents.current.onDecayTrigger -= OnDecay;
	}
	
	public void OnDecay()
    {
        if (currentDecay - decayRate <= decayThreshold)
		{
			//eventLogic should handle that
			gameObject.SetActive(false);
		}
		else {
			currentDecay -= decayRate;
		}
    }
	
}
