using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour {
	public AudioSource music; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		
		GUI.depth=3;
		if(bach.gui_Enable)
		{
			//GUI.DrawTexture(new Rect(800, 10, 500, 400), bach1); 
             if (GUI.Button(new Rect(1215, 300, 80, 50), "Play"))  {  //play music
                    if (!music.isPlaying){  
                      music.Play();  
            }  
              
        }  
          
        if (GUI.Button(new Rect(1215, 350, 80, 50), "Stop"))  {  //stop music
              
            if (music.isPlaying){  
                 music.Stop();  
            }  
        }  
   		
		}

	}
	
	
	
	
	
}
