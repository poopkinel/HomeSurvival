/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depletable : MonoBehaviour
{
	
	//public float depleteRate = 0.0001f;
	public RectTransform rectTransform;
	public float depleteRate;
	public Need oxygen;
	
	public GameObject deathPanel;
	private CanvasGroup pan;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 temp = rectTransform.localScale;
		temp.y -= depleteRate;;
		rectTransform.localScale = temp; 
		
		pan = deathPanel.GetComponent<CanvasGroup>();
		
		if (temp.y <= 0) {
			pan.alpha = 1;
		}

    }
}
*/