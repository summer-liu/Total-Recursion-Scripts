using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {
	public Camera faceCam;
	public Camera rearCam;
	
	
	void Start(){
		faceCam.enabled = true;
		rearCam.enabled = false;
	}
	
	void Update(){
		if(Dialogue.currentState == State.BEGIN)
		{
			faceCam.enabled = true;
			rearCam.enabled = false;
		}
		else
		{
			faceCam.enabled = false;
			rearCam.enabled = true;
		}
	}
}
