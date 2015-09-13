using UnityEngine;
using System.Collections;

public class Level_3 : MonoBehaviour
{

    // Use this for initialization
    public Texture exit;
    public static bool done;

//    public Texture stack;
//    public Texture stackableBlock;
    public Texture bar;
    public Texture background2;

    public Texture question_3_1;
    public Texture question_3_2;
    public Texture question_3_3;
    public Texture question_3_4;
    public Texture question_3_5;


    private float barWidth;
    private float barHeight;
    private float barProgress;


    //progress
    public Level_3()
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
        if (tableCollider3.enter_level_3 == true)
        {   // if enter_level_1 is true...show the GUI. 	
            //Debug.Log ("Hi,you are entering level 1");

            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background2);
            //Hints--------------------------------------------

            //--------------------------------------------------

            //GUI.depth=2;
            if (GUI.Button(new Rect(1300, 10, 50, 50), exit))
            {
                //Debug.Log("Clicked the button with an image");
                tableCollider3.enter_level_3 = false;
				Hints.hint="";
            }
            if (done)
            {
                tableCollider3.enter_level_3 = false;
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

            if (Drama.getProblemNumber() == 10)
            {

                GUI.Box(new Rect(0, 10, 950, 400), "Level 3-1");
                GUI.Label(new Rect(0, 60, 500, 110), "Welcome to the Mandelbrot Room.  This is our " +
                    "greenhouse room, and so the problems here will all be about trees in Computer " +
                    "Science. Recursion provides a natural way to traverse a tree. To do so, we can " +
                    "first visit the root, then visit the entire left subtree, then visit the entire " +
                    "right subtree. This way of traversing a tree is called a preorder, because " +
                    "the the root appear before the children. Can you complete the code of the " +
                    "preOrder( ) function? To traverse a tree, we just need to call preOrder(root).");
                GUI.DrawTexture(new Rect(0, 170, 520, 220), question_3_1);
				Hints.hint="A tree is recursive data type.  If one is creating a tree of integers, it might look like the following:\n"+
					"class Tree{\n" +"  public int data; // data item (key)\n "+"  public Tree left;   // this node's left child \n"
						+"  public Tree right;        // this node's right child \n"+"}";
            }
            else if (Drama.getProblemNumber() == 11)
            {
                GUI.Box(new Rect(0, 10, 950, 400), "Level 3-2");
                GUI.Label(new Rect(0, 60, 500, 110), "The size of a tree is the number of nodes in that " +
                    "tree. You can use recursion to compute it! Well, if the tree is NULL, then there is " +
                    "no node in the tree; therefore the size is 0, so we return 0. Otherwise, what is the " +
                    "size of the tree? Remember you can recursively call the left subtree and right subtree.");
                GUI.DrawTexture(new Rect(0, 170, 520, 220), question_3_2);
            }
            else if (Drama.getProblemNumber() == 12)
            {
                GUI.Box(new Rect(0, 10, 950, 400), "Level 3-3");
                GUI.Label(new Rect(0, 60, 500, 110), "Here's something else to think about:  A binary search " +
                    "tree is a binary tree with the property that a parent node is greater than or equal to " +
                    "its left child, and less than or equal to its right child. So...Complete this code:");
                GUI.DrawTexture(new Rect(0, 170, 520, 220), question_3_3);
            }
            else if ((!Drama.metMasteryThreshold()) && (Drama.getProblemNumber() == 13))
            {
                GUI.Box(new Rect(0, 10, 950, 400), "Level 3-4");
                GUI.Label(new Rect(0, 60, 500, 110), "We can also compute the height of a node in a recursive " +
                    "way! The height of the tree is the longest path from the root to a NULL child. If the tree " +
                    "is NULL, then there is no node in the tree; therefore the height is 0, so we return 0. " +
                    "Otherwise, we can use the height of left and right subtrees to recursively compute the height " +
                    "of the tree. Can you compute the code below? ");
                GUI.DrawTexture(new Rect(0, 170, 520, 220), question_3_4);
            }
            else if ((!Drama.metMasteryThreshold()) && (Drama.getProblemNumber() == 14))
            {
                GUI.Box(new Rect(0, 10, 950, 400), "Level 3-5");

                GUI.Label(new Rect(0, 60, 500, 110), "Not all functions on tree's take a single argument. One could " +
                    "imagine a function that took two arguments, for example two trees. One common operation on two " +
                    "trees is the equality test, which determines whether two trees are the same in terms of the data " +
                    "they store and the order in which they store it. Can you complete the code below? ");
                GUI.DrawTexture(new Rect(0, 170, 520, 220), question_3_5);
            }
            else if (Drama.getMastery() >= 72)
            {
                GUI.Label(new Rect(0, 60, 500, 110), "Well, well - looks like you might actually get out of here.  But " +
                    "you still have to crack into the base case. We'll see if you can do that at the next level.  First, " +
                    "though, take some time to move around this room. You'll find some intersting knowledge about recursion " +
                    "in nature. Then you can move on to your final challenge!");
            }
            else if ((Drama.getMastery() < 72) && (Drama.getProblemNumber() > 14))
            {
                GUI.Label(new Rect(0, 60, 500, 110), "Looks like you're not going to be escaping, my friend.  Might as well " +
                    "take some time to explore this room, because this is your permanent home now. Here in the Mandelbrot " +
                    "Room, you'll find some intersting knowledge about recursion in nature. Enjoy!");
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