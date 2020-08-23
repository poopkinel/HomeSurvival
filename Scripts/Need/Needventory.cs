/*using UnityEngine;
using UnityEditor;

public class Need : ScriptableObject
{
    public int myInt = 42;
}

public class SerializedPropertyTest : MonoBehaviour
{
    void Start()
    {
        Need obj = ScriptableObject.CreateInstance<Need>();
        SerializedObject serializedObject = new UnityEditor.SerializedObject(obj);

        SerializedProperty serializedPropertyMyInt = serializedObject.FindProperty("myInt");

        Debug.Log("myInt " + serializedPropertyMyInt.intValue);
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// *** Have a list of all Needs inside the Manager.
//     Dynamically 

[System.Serializable]
public class Needventory : MonoBehaviour
{
	//public Need oxygen;// = new Need ("Oxygen", 0.0001f, 0f, 0.7f);
	//Need hunger = new Need ("Hunger", 0.00005f, 0f, 0.7f);
	
	//public Need oxygen = NeedsManager.gameObject.AddComponent<Need>();
	//NeedsManager.AddComponent<Need>();
    
	//public Need need;
	
	// change to event system : this is subscribe to OnDeath()
	//public NeedsUI needsUI;
		
	
	public List<Need> needs;// = new List<Need>();
		
    // Start is called before the first frame update
    void Start() {
		//needs.Add(need);
		//needs.Add(new Need());
		//needs.Add(oxygen);
		//needs.Add(hunger);
    }

    // Update is called once per frame
    void Update()
    {
		for(int i = 0; i < needs.Count; i++){
			//check if empty - decide on death
			Need need = needs[i];
			if(need.current == need.min){
				//set active
				//needsUI.OnDeathUI(); // change to event system
				//OnDeath();
				SceneManager.LoadScene("deathScene", LoadSceneMode.Single);
			}
			
			// update the need value
			needs[i].UpdateCurrent();
		}
		// Update needs
        //for (int i=0; i < needs.Count; i++){
		//	needs[i].UpdateNeed();
		//}
    }
	
}
