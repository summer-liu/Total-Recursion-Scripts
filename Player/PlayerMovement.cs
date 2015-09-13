using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
   // public AudioClip shoutingClip;      // Audio clip of the player shouting.
    public float turnSmoothing = 10f;   // A smoothing value for turning the player.
    public float speedDampTime = 0.1f;  // The damping for the speed parameter
    public Camera target;
    Vector3 forward;
    private Animator anim;              // Reference to the animator component.
    private HashIDs hash;               // Reference to the HashIDs.
    
    
    void Awake ()
    {transform.Rotate(0,-90,0);
        // Setting up the references.
        anim = GetComponent<Animator>();
        hash = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<HashIDs>();
        
        // Set the weight of the shouting layer to 1.
       // anim.SetLayerWeight(1, 1f);
    }
    
    
    void FixedUpdate ()
    {
      Vector3 forward=target.transform.TransformDirection(Vector3.forward);
		if(Mathf.Abs(forward.x)>Mathf.Abs(forward.z))
		{forward.z=0;forward.x=forward.x/Mathf.Abs(forward.x);}
		if (Mathf.Abs(forward.x)<Mathf.Abs(forward.z))
			{forward.x=0;forward.z=forward.z/Mathf.Abs(forward.z);}
		Debug.Log("x="+forward.x+"z="+forward.z);
		forward.y = 0;
	    forward = forward.normalized;
		//Debug.Log("x="+forward.x+"z="+forward.z);
		Vector3 right =new Vector3(forward.z, 0, -forward.x);
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
       // bool sneak = Input.GetButton("Sneak");
      //  if((v>0.01)&&(h==0))
		
		Vector3 targetDirection = h * right + v * forward;
		MovementManagement(targetDirection.x,targetDirection.z);
		//MovementManagement(h,v);
    }
    
    
    void Update ()
    {
        // Cache the attention attracting input.
        //bool shout = Input.GetButtonDown("Attract");
        
        // Set the animator shouting parameter.
        //anim.SetBool(hash.shoutingBool, shout);
        
       // AudioManagement(shout);
    }
    
    
    void MovementManagement (float horizontal, float vertical)
    {
        // Set the sneaking parameter to the sneak input.
       // anim.SetBool(hash.sneakingBool, sneaking);
        
        // If there is some axis input...
        if(horizontal != 0f || vertical != 0f)
        {
            // ... set the players rotation and set the speed parameter to 5.5f.
            Rotating(horizontal, vertical);
            anim.SetFloat(hash.speedFloat, 6.0f, speedDampTime, Time.deltaTime);
        }
        else
            // Otherwise set the speed parameter to 0.
            anim.SetFloat(hash.speedFloat, 0);
    }
    
    
    void Rotating ( float horizontal,float vertical)
    {
        // Create a new vector of the horizontal and vertical inputs.
        Vector3 targetDirection = new Vector3(horizontal, 0f,vertical );
        
        // Create a rotation based on this new vector assuming that up is the global y axis.
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);
        
        // Create a rotation that is an increment closer to the target rotation from the player's rotation.
        Quaternion newRotation = Quaternion.Lerp(rigidbody.rotation, targetRotation, turnSmoothing * Time.deltaTime);
        
        // Change the players rotation to this new rotation.
        rigidbody.MoveRotation(newRotation);
    }
    
    
  /*  void AudioManagement (bool shout)
    {
        // If the player is currently in the run state...
        if(anim.GetCurrentAnimatorStateInfo(0).nameHash == hash.locomotionState)
        {
            // ... and if the footsteps are not playing...
            if(!audio.isPlaying)
                // ... play them.
                audio.Play();
        }
        else
            // Otherwise stop the footsteps.
            audio.Stop();
        
        // If the shout input has been pressed...
        if(shout)
            // ... play the shouting clip where we are.
            AudioSource.PlayClipAtPoint(shoutingClip, transform.position);
    }*/
}