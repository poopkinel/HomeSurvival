using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salad : Resource
{
	private void OnEat() {
		gameObject.SetActive(false);
	}
	
    // Start is called before the first frame update
    void Start()
    {
		GameEvents.current.onEatTrigger += OnEat;
        name = "salad";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnDestroy()
	{
		GameEvents.current.onEatTrigger -= OnEat;
	}
	
	// add unsubscribe

}
