using UnityEngine;
using System.Collections;

public class HashIDs : MonoBehaviour {

	// Here we store the hash tags for various strings used in our animators.
    
    public int locomotionState;
   
    public int speedFloat;
  
    public int playerInSightBool;
   
    public int aimWeightFloat;
    public int angularSpeedFloat;
    public int openBool;
    
    
    void Awake ()
    {
        
        locomotionState = Animator.StringToHash("Base Layer.Locomotion");
        
        speedFloat = Animator.StringToHash("Speed");
       
        playerInSightBool = Animator.StringToHash("PlayerInSight");
        
        aimWeightFloat = Animator.StringToHash("AimWeight");
        angularSpeedFloat = Animator.StringToHash("AngularSpeed");
        openBool = Animator.StringToHash("Open");
    }
}
