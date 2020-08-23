using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : Need
{
    // Start is called before the first frame update
    void Start()
    {
		current = max;
		needName = "Hunger";
    }
}
