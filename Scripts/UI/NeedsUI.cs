using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NeedsUI : MonoBehaviour
{

	public Needventory needventory;
	public Canvas canvas;
	public Sprite panelBackgroundSprite;
	//public TextMeshProUGUI textTemplate;
	
	//public Image img;
	
	/* Deprycated
	private void SetDeathPanel(){
		GameObject deathPanel = new GameObject("Death Panel");
		deathPanel.AddComponent<CanvasRenderer>();
		Image deathImg = deathPanel.AddComponent<Image>();
		deathPanel.transform.SetParent(canvas.transform, false);
		deathImg.color = Color.white;
		deathPanel.SetActive(false);
	}
	*/
	
	/* Deprycated
	public static void OnDeathUI(){ // add subscription to event
		// maybe add the need that terminated?
		
		// Change scene - scene manager
		// make sure all are in build
		//	Editor - Edit
		
		GameObject deathPanel = GameObject.Find("Death Panel").GetComponent<GameObject>();
		deathPanel.SetActive(true);
		
	}
	*/
	
    // Start is called before the first frame update
	
	/* void Start () {
     GameObject newCanvas = new GameObject("Canvas");
     Canvas c = newCanvas.AddComponent<Canvas>();
     c.renderMode = RenderMode.ScreenSpaceOverlay;
     newCanvas.AddComponent<CanvasScaler>();
     newCanvas.AddComponent<GraphicRaycaster>();
     GameObject panel = new GameObject("Panel");
     panel.AddComponent<CanvasRenderer>();
     Image i = panel.AddComponent<Image>();
     i.color = Color.red;
     panel.transform.SetParent(newCanvas.transform, false);
 }*/
 
 
	private void AddNeedText(GameObject needGameObject, int offset){
		
		
		
		GameObject textGameObject = new GameObject("Text " + needGameObject.name);
		RectTransform r = textGameObject.AddComponent<RectTransform>();
		//TextMeshPro m_textMeshPro = textGameObject.AddComponent<TextMeshPro>();
		TextMeshProUGUI m_textMeshPro = textGameObject.AddComponent<TextMeshProUGUI>();
		//TextMeshPro ngo = new TextMeshPro();
		//textGameObject.transform.SetParent(canvas.transform);
		textGameObject.transform.SetParent(needGameObject.transform);
		
		//TextMeshPro myText = textGameObject.AddComponent<TextMeshProUGUI>();
		//TextMeshProUGUI myTextGUI = GetComponent<TMPro.TextMeshProUGUI>();
		//myTextGUI = textTemplate;
		m_textMeshPro.SetText(needGameObject.name);
		//myText.text = need.needName;
		//myText.SetText(need.needName);
		
		// alignment
		// RectTransform alignment
		var p = r.position;
		// these values are adjusted to the automatic values on AddComponent
		p.x = 203.5f + 60.65f;  // Need some more research 
		p.y = 114.5f;
		// add offset for needs UI layout
		p.x -= offset * 93f;
		r.position = p;
		//center and middle of line
		m_textMeshPro.alignment = TextAlignmentOptions.Center;
		// pivot to (0,1)
		var TMPivot = m_textMeshPro.GetComponent<RectTransform>().pivot;
		TMPivot.x = 1;
		TMPivot.y = 0;
		m_textMeshPro.GetComponent<RectTransform>().pivot = TMPivot;
		
		// font size = 15
        //m_textMeshPro.enableAutoSizing = true;
		//m_textMeshPro.SetText(need.needName);
        //m_textMeshPro.enableAutoSizing = false;
		m_textMeshPro.fontSize = 14;
		// pos x=0, pos y=0
 
		
	}
	private void AddNeedPanels(GameObject needGameObject, int offset)
	{
			
		//GameObject maxPanel = new GameObject("Max Panel " + need.needName);
		GameObject maxPanel = new GameObject("Max Panel " + needGameObject.name);
		maxPanel.AddComponent<CanvasRenderer>();
		Image maxImg = maxPanel.AddComponent<Image>();
		maxImg.sprite = panelBackgroundSprite;
		//	go to parent (Canvas) and add component:
		//maxPanel.transform.SetParent(canvas.transform, false);
		maxPanel.transform.SetParent(needGameObject.transform, false);
		// alpha
		maxImg.color = new Color(
					maxImg.color.r, maxImg.color.g, maxImg.color.b, 0.4f);
		// image type sliced
		maxImg.type = Image.Type.Sliced;
		//i.color = Color.white;
		var maxPiv = maxPanel.GetComponent<RectTransform>().pivot;
		maxPiv.x = 1;
		maxPiv.y = 0;
		maxPanel.GetComponent<RectTransform>().pivot = maxPiv;
	
	
	//
		
	
		//GameObject currentPanel = new GameObject("Current Panel " + need.needName);
		GameObject currentPanel = new GameObject("Current Panel " + needGameObject.name);
		currentPanel.AddComponent<CanvasRenderer>();
		//Image img = canvas.FindObjectsOfType<typeof(Image)>().ToList().Find( x=>x.name == "BackgroundImage" );
		//Image img = canvas.FindObjectOfType("BackgroundImage").GetComponent<Image>();
		Image curImg = currentPanel.AddComponent<Image>();
		curImg.sprite = panelBackgroundSprite;
		//currentPanel.transform.SetParent(canvas.transform, false);
		currentPanel.transform.SetParent(needGameObject.transform, false);
	
		// alpha
		curImg.color = new Color(
					curImg.color.r, curImg.color.g, curImg.color.b, 0.4f);
		
		// image type sliced
		curImg.type = Image.Type.Sliced;	
		
		// set pivot to (0,0)	
		// Anchors
		var curPiv = currentPanel.GetComponent<RectTransform>().pivot;
		curPiv.x = 1;
		curPiv.y = 0;
		currentPanel.GetComponent<RectTransform>().pivot = curPiv;
		
		
		// NOTE: during update the localScale.y will diminish
	}
	
	/* deprycated
	private void AddNeedUI(Need need){ //change signature to List<Need> needs
		AddNeedPanels(need);
		AddNeedText(need);
	}
	*/
	
	private void AddNeedsUI(List<Need> needs)
	{ //change signature to List<Need> needs
		int offset;
		
		for (int i=0; i<needs.Count; i++)
		{
					
			// game object for each need (offseting the transform etc.)
			
			GameObject needGameObject = new GameObject(needs[i].needName);
			needGameObject.transform.SetParent(canvas.transform, false);
			
			offset = i; // offset is for UI layout 
			
			var tempPosition = needGameObject.transform.position;
			tempPosition.x -= (offset) * (108.5f); // this is for UI layout of multiple needs
												// when more then 3 needs exist, newline 
												// will be required.
			needGameObject.transform.position = tempPosition;
			
			//AddNeedPanels(needs[i], offset);
			//AddNeedText(needs[i], offset);
			AddNeedPanels(needGameObject, offset);
			AddNeedText(needGameObject, offset);
		}
	}
	
    void Start()
    {
				
		// Add a panel for each need:
        // for need in needventory.needs
		//      addPanel(need)
		
		AddNeedsUI(needventory.needs);
		//AddNeedUI(needventory.needs[0]);
		//AddNeedUI(needventory.needs[1]);

		//SetDeathPanel();
    }

    // Update is called once per frame
    void Update()
    {
		
		for (int i=0; i < needventory.needs.Count; i ++){
			Need need = needventory.needs[i];
			RectTransform curNeedRectTransform = GameObject.Find("Current Panel "+need.needName).GetComponent<RectTransform>();
			var ls = curNeedRectTransform.localScale;
			ls.y = need.current;
			curNeedRectTransform.localScale = ls;
		}
		
		/*
		
		Need need = needventory.needs[0]; //temp for testing
		// for each need in needs:
        // read panel info (current, and in future thresholds):
		RectTransform curNeedRectTransform = GameObject.Find("Current Panel "+need.needName).GetComponent<RectTransform>();
		//    set scale on currentRect of need	
		var ls = curNeedRectTransform.localScale;
		ls.y = need.current;
		curNeedRectTransform.localScale = ls;
		//	  maybe in future change colors
		
		// Check if new needs are Create / Update / Delete
		// (discovered or changed relationship).
		// if added:
		// add a new panel with AddNeedPanels(newNeed)
		
		
		
		//  ---- Still temp for testing -----
		
		Need need2 = needventory.needs[1]; //temp for testing
		// for each need in needs:
        // read panel info (current, and in future thresholds):
		RectTransform curNeedRectTransform2 = GameObject.Find("Current Panel "+need2.needName).GetComponent<RectTransform>();
		//    set scale on currentRect of need	
		var ls2 = curNeedRectTransform2.localScale;
		ls2.y = need2.current;
		curNeedRectTransform2.localScale = ls2;
		//	  maybe in future change colors
		
		// Check if new needs are Create / Update / Delete
		// (discovered or changed relationship).
		// if added:
		// add a new panel with AddNeedPanels(newNeed)
		*/
    }
	

	
	
}
