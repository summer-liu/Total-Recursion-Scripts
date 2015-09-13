using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour {

	// Use this for initialization
	public Texture exit;
    public static bool done;

//	public Texture stack;
//   public Texture stackableBlock;
	public Texture bar;
	public Texture background2;
	
   public Texture question_1_1;
   public Texture question_1_2;
	public Texture question_1_3;
	public Texture question_1_4;
	public Texture question_1_5;
	
	
    private float barWidth;
    private float barHeight;
    private float barProgress;
    

    //progress
    public Interface()
    {
        
	    //progress bar
	    barWidth=500;
	    barHeight=25;
	    //learning_gain=40;
	    //public int learning_gain=20;

        done = false;
    }
    void start(){

    }

	 
	void Update(){
	}

    void OnGUI() {
		GUI.depth=2;
		 
        if (!exit) {  //Assign texture to the variable!
            Debug.LogError("Please assign a texture on the inspector");
            return;
        }
		//////////////////////////////////////////////////////////
                        // Level 1     //
        //////////////////////////////////////////////////////////
		if(tableCollider.enter_level_1 == true){   // if enter_level_1 is true...show the GUI. 	
			//Debug.Log ("Hi,you are entering level 1");
			
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background2);
			//Hints--------------------------------------------
			
			//--------------------------------------------------
			
			//GUI.depth=2;
        	if (GUI.Button(new Rect(1300, 10, 50, 50), exit)){ 
				//Debug.Log("Clicked the button with an image");
		   		tableCollider.enter_level_1 = false;
				Hints.hint="";
				}
            if (done)
            {
                tableCollider.enter_level_1 = false;
				Hints.hint="";
            }
			
			
			//GUI.DrawTexture(new Rect(0, 0, 80, 80), aTexture_1, ScaleMode.ScaleToFit, true, 0);
			//Debug.Log ("Hi, there! 1");
			//if(Levels.pass_level_1==true)
				//GUI.DrawTexture(new Rect(0, 550, 140, 40), level_1);  //draw the block of level 1
			//   GUI.DrawTexture(new Rect(0, 100, 150, 400), stack);  //draw the stack
//            GUI.DrawTexture(new Rect(0, 100, 150, 400), stack);
//           GUI.DrawTexture(new Rect(0, (100 + ((7 - Drama.getProblemNumber()) * 50)), 150, ((1 + Drama.getProblemNumber()) * 50)), stackableBlock);
			//GUI.DrawTexture(new Rect(1225,100 , 150, 500), mastery);
			   // Draw the progress bar(learning gain)
			
			//Debug.Log ("Hi, there! 2");
            GUI.BeginGroup (new Rect (400, 0, barWidth, barHeight*2));
            GUI.Label(new Rect(200, 0, 100, 20), "Learning Gain");
            GUI.Box(new Rect(0,20,barWidth,barHeight),"");
            barProgress = Drama.getMastery()/100*barWidth;
	       // Debug.Log(barProgress);
	        GUI.DrawTexture(new Rect(0,20,barProgress,barHeight),bar);

            

			  // GUI.Label(Rect(bar.width/2, 25, 50, barHeight),"Start");
               //GUI.Label(Rect(barWidth-30, 25, 100, barHeight),"End");
               GUI.EndGroup();

			GUI.BeginGroup (new Rect (215,40,1200,400));
		// All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.
		// We'll make a box so you can see where the group is on-screen.

            if (Drama.getProblemNumber() == 0){
				
		        GUI.Box (new Rect (0,10,950,400), "Level 1-1");				
			    GUI.Label(new Rect(0, 60, 500, 110), "We hope you are appreciating the fine art " +
                    "of the Escher Room - Level 1 of our beautiful prison.  Let's see if you can " +
                    "compute the answers to the following series of recursion questions. For " +
                    "Problem 1, just prove you can find the answer to the recursive call " +
                    "\bfibonacci(6)\b of the classic recursion function below.");
			    GUI.DrawTexture(new Rect(0, 170, 520, 220), question_1_1);
		
            }
            else if (Drama.getProblemNumber() == 1){
                GUI.Box(new Rect(0, 10, 950, 400), "Level 1-2");
		    	GUI.Label(new Rect(0, 60, 500, 100), "Here's another question for you: what's " +
                    "the answer to the recursive call mystery(28, 16) of the following function?");
			    GUI.DrawTexture(new Rect(0, 170, 520, 220), question_1_2);
            }
            else if (Drama.getProblemNumber() == 2){
                GUI.Box(new Rect(0, 10, 950, 400), "Level 1-3");
			    GUI.Label(new Rect(0, 60, 500, 100), "If you liked that one, here's a harder one: " +
                    "calculate the answer to the recursive call sumDigits(5232)");
			    GUI.DrawTexture(new Rect(0, 170, 520, 220), question_1_3);
            }
            else if ((!Drama.metMasteryThreshold()) && (Drama.getProblemNumber() == 3)){
                GUI.Box(new Rect(0, 10, 950, 400), "Level 1-4");
			    GUI.Label(new Rect(0, 60, 500, 100), "Here's a tricky one for you: what's the output " +
                    "of the recursive call method(253)?");
		        GUI.DrawTexture(new Rect(0, 170, 520, 220), question_1_4);
            }
            else if ((!Drama.metMasteryThreshold()) && (Drama.getProblemNumber() == 4)){
               GUI.Box(new Rect(0, 10, 950, 400), "Level 1-5");
			
			   GUI.Label(new Rect(0, 60, 500, 100), "Alright, how about this one: calculate the " +
                    "output of the recursive call method(5)");
				GUI.DrawTexture(new Rect(0, 170, 520, 220), question_1_5);
			}
			
            else if (Drama.getMastery() >= 24) {
				Debug.Log ("You succeed in Level 1! Con!");
                GUI.Label(new Rect(0, 60, 500, 100), "Okay, champ - we'll see how you do at the next " +
                    "level.  Take some time to move around the room, you'll find some intersting knowledge about recursion in art.Then you can move on to next room!");
            }
            else if ((Drama.getMastery() < 24) && (Drama.getProblemNumber() > 4)){
				Debug.Log ("Sorry");
                GUI.Label(new Rect(0, 60, 500, 100), "Not looking good, champ - we'll see how you do at the next " +
                    "level.  Take some time to move around the room, you'll find some intersting knowledge about recursion in art.Then you can move on to next room!");
            }
			Debug.Log ("mastery="+Drama.getMastery());
		   // GUI.Button (new Rect (50,370,100,30), "Go");
			//GUI.Button (new Rect (200,370,100,30), "Hint");
			//if(GUI.Button (new Rect (350,370,100,30), "Next"))
				    //Debug.Log ("Next Question");
			
		// End the group we started above. This is very important to remember!
			//Debug.Log ("Hi, there! 4");
   
			//GUI.Label(new Rect(0, 120, 520, 600), question_1_1);
        
			//GUI.Label(new Rect(30, 320, 120, 20), "methodB(2534985)=");
			//Debug.Log ("Hi, there! 5");
			//tempInput2 = GUI.TextArea(new Rect(150, 320, 200, 20), tempInput2, 200); //User Input
			//Debug.Log ("Hi, there! 6");
			//GUI.Label(new Rect(10,50,500,500),"This is the first line.\n This is the second line.");
			GUI.Box (new Rect (520,60,430,400), "");
			
		//	if(GUI.Button (new Rect (350,370,100,30), "Next"))
				    //Debug.Log ("Next Question");
		    GUI.EndGroup ();
			
			//-------------------------------------------------------------------
			

				
		}
		
		
    }
	

}


