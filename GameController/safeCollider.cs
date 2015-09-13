using UnityEngine;
using System.Collections;

public class safeCollider : MonoBehaviour {
	
	public  Camera camera1;
	public  Camera camera3;
	public static bool enter_level_4=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(enter_level_4==false){
			camera1.enabled=true;
			camera3.enabled=false;
		}
	}
	
	
	void OnTriggerEnter(Collider other) {
		
		Debug.Log ("Enter the table");
        if(other.gameObject.tag=="Player")
		{
			//CameraMovement.TwoD=true;
			enter_level_4=true;
			camera1.enabled=false;
			camera3.enabled=true;
		/*	
			if(Dialogue.currentState = State.EXPLORE){
				//Ask user if it's time to stop exploring
				State newState = Dialogue.getInput();
				if(newState = State.TABLE){
					string response = Dialogue.sendOutput();
				}		
			}
         */
			
		}
    }
	
		void OnTriggerExit(Collider other) {
		
		Debug.Log ("OUT of the table");
        if(other.gameObject.tag=="Player")
		{
			//CameraMovement.TwoD=false;
			enter_level_4=false;
			camera1.enabled=true;
			camera3.enabled=false;
		}
    }
	
	
	
}
