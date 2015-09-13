using UnityEngine;
using System.Collections;

public class Level_4 : MonoBehaviour
{

    // Use this for initialization
    public Texture exit;
    public static bool done;

//    public Texture stack;
//    public Texture stackableBlock;
    public Texture bar;
    public Texture background2;

    public Texture question_4_1;

    private float barWidth;
    private float barHeight;
    private float barProgress;


    //progress
    public Level_4()
    {

        //progress bar
        barWidth = 500;
        barHeight = 25;
        //learning_gain=40;
        //public int learning_gain=20;

        done = false;
    }
    void start()
    {

    }


    void Update()
    {
    }

    void OnGUI()
    {
        GUI.depth = 2;

        if (!exit)
        {  //Assign texture to the variable!
            Debug.LogError("Please assign a texture on the inspector");
            return;
        }
        //////////////////////////////////////////////////////////
        // Level 2     //
        //////////////////////////////////////////////////////////			
        if (safeCollider.enter_level_4 == true)
        {   // if enter_level_1 is true...show the GUI. 	
            //Debug.Log ("Hi,you are entering level 1");

            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background2);
            //Hints--------------------------------------------

            //--------------------------------------------------

            //GUI.depth=2;
            if (GUI.Button(new Rect(1300, 10, 50, 50), exit))
            {
                //Debug.Log("Clicked the button with an image");
                safeCollider.enter_level_4 = false;
				Hints.hint="";
            }
            if (done)
            {
                safeCollider.enter_level_4 = false;
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
            GUI.BeginGroup(new Rect(400, 0, barWidth, barHeight * 2));
            GUI.Label(new Rect(200, 0, 100, 20), "Learning Gain");
            GUI.Box(new Rect(0, 20, barWidth, barHeight), "");
            barProgress = Drama.getMastery() / 100 * barWidth;
            // Debug.Log(barProgress);
            GUI.DrawTexture(new Rect(0, 20, barProgress, barHeight), bar);



            // GUI.Label(Rect(bar.width/2, 25, 50, barHeight),"Start");
            //GUI.Label(Rect(barWidth-30, 25, 100, barHeight),"End");
            GUI.EndGroup();

            GUI.BeginGroup(new Rect(215, 40, 1200, 400));
            // All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.
            // We'll make a box so you can see where the group is on-screen.

            if (Drama.getProblemNumber() == 15)
            {

                GUI.Box(new Rect(0, 10, 950, 400), "Level 4-1");
             /*   GUI.Label(new Rect(0, 60, 500, 50), "Congratulation - you have reached the final level. " +
                    "Did you see the safe? You need to crack the password to open it and get the key to " +
                    "go back to reality. How to crack the password? That’s easy! You just need to try " +
                    "every possibility.  Because of the recursive nature of permutations, recursion can be " +
                    "effectively used to find all possible combinations of a given set of elements. The " +
                    "password consists of 4 digits. The code below will try every possible combination of " +
                    "4 digits and check if it’s the same as the password. Can you complete the code? ");*/
				GUI.Label(new Rect(0, 60, 500, 110),"Congratulation - you have reached the final level. Did you see the safe? You need to crack the password to open it and get the key to go back to reality. How to crack the password? That's easy! You just need to try every possibility.  Because of the recursive nature of permutations, recursion can be effectively used to find all possible combinations of a given set of elements. The password consists of 4 digits. The code below will try every possible combination of 4 digits and check if it's the same as the password. Can you complete the code? ");
                GUI.DrawTexture(new Rect(0, 180, 520, 220), question_4_1);
            }
            else if (Drama.getMastery() >= 100)
            {
                GUI.Label(new Rect(0, 60, 500, 50), "Oh, wow.  You win.  Have a nice life.");
            }
            else if ((Drama.getMastery() < 100) && (Drama.getProblemNumber() > 15))
            {
                GUI.Label(new Rect(0, 60, 500, 50), "Haha!  You lose. Looks like you're stuck here forever.");
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
            GUI.Box(new Rect(520, 60, 430, 400), "");

            //	if(GUI.Button (new Rect (350,370,100,30), "Next"))
            //Debug.Log ("Next Question");
            GUI.EndGroup();

            //-------------------------------------------------------------------



        }


    }

    //Debug.Log ("Hi, there! 8");
}