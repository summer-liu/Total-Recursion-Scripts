using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour {
	
	
	//public  static bool Interface.done=true;
	public GameObject Target;
	//public  Camera camera3;
	//public  Camera camera4;
	
	float DoorOpenAngle = -90.0f;
    //float DoorCloseAngle = 0.0f;
	//float smooth = 2.0f;
	
	bool open=false;
	bool enter=false;
	bool guiEnable=false;
	 float targetValue=0.0f;
	 float currentValue=0.0f;
	float casing=0.05f;
	string alert;
	
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//Debug.Log ("Test!!!");
		if((enter==true)&&(Interface.done==true))
			open=true;
		
		
	if (open==true)
		{
            //Debug.Log ("Open the door!!");
			
			currentValue=DoorOpenAngle;
			targetValue=0.0f;
	   Target.transform.localRotation=Quaternion.identity;
		Target.transform.Rotate(0.0f,-90.0f,0.0f);
		}
		if(open==false)
		{
			 targetValue=DoorOpenAngle;
			 currentValue=0.0f;
			
		Target.transform.localRotation=Quaternion.identity;
		Target.transform.Rotate(0.0f,0.0f,0.0f);
			
		}
		
		//currentValue=currentValue+(targetValue-currentValue)*casing;
		
		
		
	}
	
    void OnGUI()
	{
		if(guiEnable)
		{
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height),alert);
		}
		
		if((enter==true)&&(Interface.done==true)) alert="The door is open now.";
		if((enter==true)&&(Interface.done==false)) alert="You need first solve Level 1 to open the door~";
		
	}
	
	void OnTriggerEnter(Collider other) {
		
		//Debug.Log ("Enter Enter!!!!");
        if(other.gameObject.tag=="Player")
		{
			enter=true;
			guiEnable=true;
			//Debug.Log ("Enter the door!!");
			
		}
    }
	
		void OnTriggerExit(Collider other) {
        if(other.gameObject.tag=="Player")
		{
			enter=false;
			guiEnable=false;
			//Debug.Log ("Leave the door!!");
			
			
		}
    }
}
