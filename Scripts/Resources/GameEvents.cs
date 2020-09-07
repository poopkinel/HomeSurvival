using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
	
	public static GameEvents current;
    
	private void Awake(){
		current = this;
	}
	
	// event clocks consts
	//private int eventClock = 1000;
	//private const int DECAYCLOCK = 999;
	// for testing - shorter clock
	
	private const int eventClockSize = 1;
	private int eventClock;
	
	private const int DECAYCLOCK = 1;
	private const int ROTCLOCK = 1;
	
	// events 
	public event Action onEatTrigger;	
	public event Action onDecayTrigger;
	public event Action onRotTrigger;
	
	// methods
	public void EatTrigger() // calls all the methods subscribed to OnEatTrigger
	{
		if (onEatTrigger != null)
		{
			onEatTrigger();
		}
	}
	
	public void DecayTrigger()
	{
		if (onDecayTrigger != null)
		{
			onDecayTrigger();
		}
	}
	
	public void RotTrigger()
	{
		if (onRotTrigger != null)
		{
			onRotTrigger();
		}
	}
	
	// Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
	// Update is used to induced Time-Triggered events (e.g: decay)

    void Update()
    {
        if (eventClock <= 0){
			eventClock = eventClockSize;
		}
		else {
			eventClock--;
		}
		
		// Time induced event triggers
		
		if (eventClock == DECAYCLOCK){
			current.DecayTrigger();
		}
		
		if (eventClock == ROTCLOCK){
			current.RotTrigger();
		}
		
		
    }
}
