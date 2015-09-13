using UnityEngine;
using System.Collections;

public class safeOpen : MonoBehaviour {
	
	public GameObject camera1;
	public GameObject camera2;
	
	float safeOpenAngle = 90.0f;
	float targetValue=100.0f;
	 float currentValue=0.0f;
	 float casing=0.05f;
	
	Vector3 currentPosition;
	//Vector3 currentRotation;
	float rotateAngle=90.0f;
	Vector3 targetPostion=new Vector3(-103.402f,9.583f,-8.385f);
	//Vector3 targetRotation=new Vector3(90.0f,-73.6521f,0f);
	// Use this for initialization
	void Start () {
	
		camera1.active=true;
		camera2.active=false;
		//currentPosition=camera2.transform.position;
	}
	
	
	// Update is called once per frame
	void Update () {
		
		
		if(Level_4.done==true)
		{
			
			currentValue=currentValue+(targetValue-currentValue)*casing;
		    transform.localRotation=Quaternion.identity;
		    transform.Rotate(0.0f,0.0f,currentValue);
			camera1.active=false;
			camera2.active=true;
			//camera2.gameObject.activeSelf=
			//Debug.Log("Enable camera 3");
		//	camera2.transform.position = Vector3.Lerp(currentPosition, targetPostion, Time.deltaTime);
			//camera2.transform.Rotate(rotateAngle * Time.deltaTime,0, 0);
			//camear2.transform.rotation= Vector3.Lerp(currentRotation,targetRotation,Time.deltaTime);
		}
	
	}
}
