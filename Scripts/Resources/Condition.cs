using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public abstract class Condition : MonoBehaviour
{	
	public abstract bool Check(List<Resource> Resources);
	
	public abstract List<Resource> PerformSuccessful();
	
	public abstract List<Resource> PerformUnsuccessful();
	
}
