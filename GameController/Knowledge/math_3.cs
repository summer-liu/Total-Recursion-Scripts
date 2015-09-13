using UnityEngine;
using System.Collections;

public class math_3: MonoBehaviour {

	// Use this for initialization\
	
	public Texture math3;
	bool gui_Enable;
	
	public math_3()
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
			GUI.DrawTexture(new Rect(700, 200, 600, 500), math3); 
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
