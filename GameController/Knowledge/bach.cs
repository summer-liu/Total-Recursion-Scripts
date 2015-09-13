using UnityEngine;
using System.Collections;

public class bach: MonoBehaviour {

	// Use this for initialization\
	
	public Texture bach1;
	public static bool gui_Enable;
	
	
	public bach()
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
		GUI.depth=4;
		if(gui_Enable)
		{
			GUI.DrawTexture(new Rect(800, 10, 500, 400), bach1); 
            
   		
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
			
			//Debug.Log ("Leave!");
			
			gui_Enable=false;
		}
    }
	
	
	
	
	
	
}
