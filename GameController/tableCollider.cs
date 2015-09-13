using UnityEngine;
using System.Collections;

public class tableCollider : MonoBehaviour {
	
	public  Camera camera1;
	public  Camera camera2;
	public static bool enter_level_1=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(enter_level_1==false){
			camera1.enabled=true;
			camera2.enabled=false;
		}
	}
	
	
	void OnTriggerEnter(Collider other) {
		
		//Debug.Log ("Enter the table");
        if(other.gameObject.tag=="Player")
		{
			
			Debug.Log ("Enter the table, disable main camera");
			//CameraMovement.TwoD=true;
			enter_level_1=true;
			camera1.enabled=false;
			camera2.enabled=true;
			Debug.Log ("Enter the table, Enable camera 2");
		/*Debug.Log ("Enter the table, disable main camera");
			if(Dialogue.currentState = State.EXPLORE){
				//Ask user if it's time to stop exploring
				State newState = Dialogue.getInput();
				if(newState = State.TABLE){
					string response = Dialogue.sendOutput();
				}		
			}
         */
			//Debug.Log ("Enter!!!!");
		}
    }
	
		void OnTriggerExit(Collider other) {
		
		//Debug.Log ("OUT of the table");
        if(other.gameObject.tag=="Player")
		{
			//CameraMovement.TwoD=false;
			enter_level_1=false;
			camera1.enabled=true;
			camera2.enabled=false;
		}
    }
	
	
	
}
