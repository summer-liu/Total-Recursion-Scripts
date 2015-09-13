using UnityEngine;
using System.Collections;

public class DoorOpen3 : MonoBehaviour {
	
	
	public GameObject Target4;
	public GameObject Target5;	
	//public  static bool Level_3.done=true;
	
	float DoorOpenAngle = 90.0f;
//   float DoorCloseAngle = 0.0f;
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
		if((enter==true)&&(Level_3.done==true))
			open=true;
		
		
	if (open==true)
		{
            //Debug.Log ("Open the door!!");
			
			//currentValue=DoorOpenAngle;
			///targetValue=0.0f;
		}
		if(open==false)
		{
			targetValue=DoorOpenAngle;
			currentValue=0.0f;
			
		}
		
		currentValue=currentValue+(targetValue-currentValue)*casing;
		Target4.transform.localRotation=Quaternion.identity;
		Target4.transform.Rotate(0.0f,-currentValue,0.0f);
		
		Target5.transform.localRotation=Quaternion.identity;
		Target5.transform.Rotate(0.0f,currentValue,0.0f);
		
		
	}
	
    void OnGUI()
	{
		if(guiEnable)
		{
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height),alert);
		}
		
		if((enter==true)&&(Level_3.done==true)) alert="The door is open now.";
		if((enter==true)&&(Level_3.done==false)) alert="You need first solve Level 3 to enter next room!";
		
	}
	
	void OnTriggerEnter(Collider other) {
		
		//Debug.Log ("Enter Enter!!!!");
        if(other.gameObject.tag=="Player")
		{
			enter=true;
			guiEnable=true;
		//	Debug.Log ("Enter!!!!");
		}
    }
	
		void OnTriggerExit(Collider other) {
        if(other.gameObject.tag=="Player")
		{
			enter=false;
			guiEnable=false;
		}
    }
}
