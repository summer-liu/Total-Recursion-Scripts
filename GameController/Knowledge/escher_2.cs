using UnityEngine;
using System.Collections;

public class escher_2: MonoBehaviour {

	// Use this for initialization\
	
	public Texture escher2;
	bool gui_Enable;
	
	public escher_2()
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
			GUI.DrawTexture(new Rect(750, 350, 500, 400), escher2); 
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
