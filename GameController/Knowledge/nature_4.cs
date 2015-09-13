using UnityEngine;
using System.Collections;

public class nature_4: MonoBehaviour {

	// Use this for initialization\
	
	public Texture nature4;
	bool gui_Enable;
	
	public nature_4()
	{
		gui_Enable=false;
		
		
	}
	void Start () {
	
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	
	void OnGUI()
	{
		if(gui_Enable)
		{
			GUI.DrawTexture(new Rect(800, 10, 500, 400), nature4); 
		}
		
		
		
		
	}
	
	
	
	void OnTriggerEnter(Collider other) {
		
		//Debug.Log ("Enter Enter!!!!");
        if(other.gameObject.tag=="Player")
		{
			Debug.Log ("Art work");
			gui_Enable=true;
			
			
		}
    }
	
		void OnTriggerExit(Collider other) {
        if(other.gameObject.tag=="Player")
		{
			
			Debug.Log ("Leave!");
			
			gui_Enable=false;
		}
    }
	
	
	
	
	
	
}
