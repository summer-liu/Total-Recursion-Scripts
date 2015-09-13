using UnityEngine;
using System.Collections;

public class Level_2 : MonoBehaviour {

	// Use this for initialization
	public Texture exit;
    public static bool done;

//	public Texture stack;
//  public Texture stackableBlock;
	public Texture bar;
	public Texture background2;
	
   public Texture question_2_1;
   public Texture question_2_2;
	public Texture question_2_3;
	public Texture question_2_4;
	public Texture question_2_5;
	
	
    private float barWidth;
    private float barHeight;
    private float barProgress;
    

    //progress
    public Level_2()
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
                        // Level 2     //
        //////////////////////////////////////////////////////////			
		if(tableCollider2.enter_level_2 == true){   // if enter_level_1 is true...show the GUI. 	
			//Debug.Log ("Hi,you are entering level 1");
			
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background2);
			//Hints--------------------------------------------
			
			//--------------------------------------------------
			
			//GUI.depth=2;
        	if (GUI.Button(new Rect(1300, 10, 50, 50), exit)){ 
				//Debug.Log("Clicked the button with an image");
		   		tableCollider2.enter_level_2 = false;
				Hints.hint="";
				}
            if (done)
            {
                tableCollider2.enter_level_2 = false;
				Hints.hint="";
            }
			
			
			//GUI.DrawTexture(new Rect(0, 0, 80, 80), aTexture_1, ScaleMode.ScaleToFit, true, 0);
			//Debug.Log ("Hi, there! 1");
			//if(Levels.pass_level_1==true)
				//GUI.DrawTexture(new Rect(0, 550, 140, 40), level_1);  //draw the block of level 1
			//   GUI.DrawTexture(new Rect(0, 100, 150, 400), stack);  //draw the stack
//            GUI.DrawTexture(new Rect(0, 100, 150, 400), stack);
//            GUI.DrawTexture(new Rect(0, (100 + ((7 - Drama.getProblemNumber()) * 50)), 150, ((1 + Drama.getProblemNumber()) * 50)), stackableBlock);
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

            if (Drama.getProblemNumber() == 5){
				
		        GUI.Box (new Rect (0,10,950,400), "Level 2-1");
                GUI.Label(new Rect(0, 60, 500, 110), "This is the Ackermann Room.  If you thought " +
                    "the problems in the Escher Room were easy, let's how you do on some " +
                    "code-completion problems. For Problem 1, prove you can complete the following " +
                    "recursion code to compute Fibonacci numbers.");
			    GUI.DrawTexture(new Rect(0, 170, 520, 220), question_2_1);	
            }
            else if (Drama.getProblemNumber() == 6){
                GUI.Box(new Rect(0, 10, 950, 400), "Level 2-2");
                GUI.Label(new Rect(0, 60, 500, 110), "And another question for you: Can you " +
                    "complete the code to compute an approximation to the golden ratio using " +
                    "the recursive formula: f(0) = 1, f(n) = 1 + 1 / f(n-1) if n > 0 ?");
			    GUI.DrawTexture(new Rect(0, 170, 520, 220), question_2_2);
            }
            else if (Drama.getProblemNumber() == 7){
                GUI.Box(new Rect(0, 10, 950, 400), "Level 2-3");
			    GUI.Label(new Rect(0, 60, 500, 110), "Anyone who knows anything about recursion " +
                    "should know about binary search. What about you? Can you complete the code " +
                    "for the binary search algorithm below?");
			    GUI.DrawTexture(new Rect(0, 170, 520, 220), question_2_3);
            }
            else if ((!Drama.metMasteryThreshold()) && (Drama.getProblemNumber() == 8)){
                GUI.Box(new Rect(0, 10, 950, 400), "Level 2-4");
			    GUI.Label(new Rect(0, 60, 500, 110), "Are we having fun or what?  Here's another fun " +
                    "one: \n A palindrome is a word, phrase, number, or other sequence of symbols or " +
                    "elements, whose meaning may be interpreted the same way in either forward or " +
                    "reverse direction. Can you complete the code to determine if a string is a " +
                    "palindrome? You can use message.substring( , ) to represent the substring of the " +
                    "message string, and message.length() to represent the length of the string.");
		        GUI.DrawTexture(new Rect(0, 170, 520, 220), question_2_4);
            }
            else if ((!Drama.metMasteryThreshold()) && (Drama.getProblemNumber() == 9)){
               GUI.Box(new Rect(0, 10, 950, 400), "Level 2-5");

               GUI.Label(new Rect(0, 60, 500, 110), "The code below takes a positive integer N (in " +
                   "decimal) and prints out its binary representation. Can you complete the code? ");
				GUI.DrawTexture(new Rect(0, 170, 520, 220), question_2_5);
			}
            else if (Drama.getMastery() >= 48) {
                GUI.Label(new Rect(0, 60, 500, 110), "Hm, not bad - we'll see how you do at the next " +
                    "level, though.  Take some time to move around the room, you'll find some intersting " +
                    "knowledge about recursion in mathematics and fractals .Then you can move on to next room!");
            }
            else if ((Drama.getMastery() < 48) && (Drama.getProblemNumber() > 9)){
                GUI.Label(new Rect(0, 60, 500, 110), "Not looking good, my friend - we'll see how you do at the next " +
                    "level.  Take some time to move around the room, you'll find some intersting knowledge about " +
                    "recursion in mathematics and fractals. Then you can move on to next room!");
            }
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
	
	//Debug.Log ("Hi, there! 8");
}


