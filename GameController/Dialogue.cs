using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour {

	public static State currentState;
	public Texture background;
    private bool flag;
    private bool enter;
	
    private string userName;
    private int beginningDialogue;
    private int nextLevelDialogue;
    private bool hasMetThreshold;

	private string tempInput;
	private string userInput;
    private string systemOutput;
    private bool cooperative;
	
//	private Drama dramaMaster;        
    private AnswerDatabase correctAnswers;
    private Outputs systemOutputs;
//    private Inputs expectedInputs;
	
	
	public Dialogue(){ 
		currentState = State.BEGIN;
        //dramaMaster = new Drama();
	    correctAnswers = new AnswerDatabase();
        systemOutputs = new Outputs();
        //expectedInputs = new Inputs();
        userName = "";
        beginningDialogue = 0;
        nextLevelDialogue = 0;
		enter = false;
		flag = false;
        cooperative = true;
        hasMetThreshold = true;
	}
	
	void Start () {
        systemOutput = "If anyone out there can hear this...please help." +
        "The R4R locked me in here. I need to escape.  But I can't do it " +
        "alone.  Please.  Someone please help...";

        tempInput = "I will help.";		
        userInput = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnGUI()
    {//Debug.Log("Hi");
        //////////////////////////////////////////////////////////
        //First, we display the introductory message.           //
        //The user has to say "yes" to enter Total Recursion.   //
        //////////////////////////////////////////////////////////
        if (!enter)
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background);

            if (GUI.Button(new Rect(650, 550, 70, 50), "Send"))
            {
                if (tempInput.Equals("I will help."))
                {
                    systemOutput = sendOutput();
                    tempInput = "My name is ";
                    enter = true;
                }
            }

            GUI.Label(new Rect(220, 450, 500, 75), systemOutput);                    //System Output
            tempInput = GUI.TextArea(new Rect(220, 525, 500, 100), tempInput, 200); //User Input			
        }
        else
        {

            //////////////////////////////////////////////////////////
            //Now, once we are done with the introductory screen,we //
            //proceed with the dialogue for the rest of the game.   //
            //////////////////////////////////////////////////////////
            flag = false;                                           //User has not submitted a response yet

            if (GUI.Button(new Rect(650, 550, 70, 50), "Send"))
            {    //if the button Send is clicked.	
                userInput = tempInput;                              //Record the User Input
                flag = true;                                        //Signal that we have a response
            }


            if (flag) {
                State oldState = currentState;
                State newState = getInput(userInput);
                systemOutput = sendOutput();

                if (newState == oldState)      {
                    if (newState == State.BEGIN)      {
                        if (beginningDialogue < 6)
                            tempInput = "Yeah";
                        else
                            tempInput = "Sounds good";
                    }
                    else if ((newState == State.TABLE)||(newState == State.NEXT_LEVEL)) {
                        tempInput = "";
                    }
            //        else if (newState == State.NEXT_LEVEL)  {
            //            if (!nextLevelDialogue)
            //                tempInput = "I'm ready";
            //        }
                }
                else if (newState == State.NEXT_LEVEL){         //If the state has changed to NEXT_LEVEL
                    tempInput = "Let's go.";
                }

                flag = false;
            }

            //////////////////////////////////////////////////////////
            //No matter what the state is, we update the system     //
            //output in the GUI and record/show the user input.     //
            //////////////////////////////////////////////////////////
			GUI.depth=0;
            GUI.Label(new Rect(220, 450, 500, 75), systemOutput);                       // System output
            tempInput = GUI.TextArea(new Rect(220, 525, 500, 100), tempInput, 200);     // User input			
        }
    }
	




    /*
     * ***********************************************************************************
     * **************************************************************************************************
     *   HELPER METHODS
     * **************************************************************************************************
     *************************************************************************************
	*/

    //////////////////////////////////////////////////////////////
    //System output                                             //
    //  Methods                                                 //
    //////////////////////////////////////////////////////////////
	private string sendOutput(){
		string output = "";

        if (currentState == State.BEGIN)
            output = beginOutput();
        else if (currentState == State.TABLE)
            output = tableOutput();
        else if (currentState == State.NEXT_LEVEL)
            output = nextLevelOutput();
		
		return output;
	}
	
	private string beginOutput() {
        string response = "";

        if (beginningDialogue == 1)
		{
            response = userName + systemOutputs.getBegin(beginningDialogue);
            beginningDialogue++;
        }
   //     else if (beginningDialogue == 2){
   //         if (userInput.
   //     }
        else if (beginningDialogue < 6)
        {
            if (cooperative)
            {
                response = systemOutputs.getBegin(beginningDialogue);
                beginningDialogue++;
            }
            else
			{
                response = "Please?  Just say yes!";
                cooperative = true;
            }
        }
        else
            response = "Just tell me when you're ready";
        return response;
	}
	
	private string tableOutput() {
        string response = "";

        if ((Drama.getNumberOfAttempts() < 8) && ((tableCollider.enter_level_1 == true) || 
												(tableCollider2.enter_level_2 == true) || 
												(tableCollider3.enter_level_3 == true)))
		{
            int outputCluster = 4 * (Drama.getProblemNumber() % 5);
            response = systemOutputs.getTable((Drama.getNumberOfAttempts()) + outputCluster);
        }
  //      else{
  //          response = "Agh!  You've killed me";
  //      }

        return response;
	}

    private string nextLevelOutput()
    {
        string response = "";

        if (nextLevelDialogue == 0)
        {
            hasMetThreshold = Drama.metMasteryThreshold();
            Drama.updateLevel();
        }

        if (Drama.getLevel() >= 3 && !hasMetThreshold)
        {
            if (nextLevelDialogue == 0)
            {
                response = "I don't have enough of a learning gain score to proceed.";
                tempInput = "What does that mean?";
            }
            else if (nextLevelDialogue == 1)
            {
                if(Drama.getLevel() == 3)
                    Level_3.done = true;
                else
                    Level_4.done = true;

                response = "You know what it means.";
            }
            else if (nextLevelDialogue == 2)
            {
                response = "Game over.";
                enter = false;
            }

        }
        else if (Drama.getLevel() == 4 && hasMetThreshold)
        {
            if (nextLevelDialogue == 0)
            {
                response = "We did it!  Thank you!";
                tempInput = "You're welcome.";
                Level_4.done = true;
            }
            else if (nextLevelDialogue == 1)
			{
                Level_4.done = true;
                response = "You know what this means?";
                tempInput = "What?";
            }
            else if (nextLevelDialogue == 2)
            {
                response = "Victory!";
                enter = false;
            }
        }
        else
        {
            //TODO: Change the conditional here
            if (nextLevelDialogue == 0)
            {
                response = systemOutputs.getNextLevel(Drama.getLevel());
            }
            else if (nextLevelDialogue == 1)
            {
                response = systemOutputs.getNextLevel(3);
                if (Drama.getLevel() == 1)
                    Interface.done = true;
                else if (Drama.getLevel() == 2)
                    Level_2.done = true;
                else if (Drama.getLevel() == 3)
                    Level_3.done = true;
//                else if (Drama.getLevel() == 4)
//                    Level_4.done = true;

            }
            else
            {
                response = systemOutputs.getNextLevel(4);
            }
        }

        nextLevelDialogue++;

        return response;
    }



    //////////////////////////////////////////////////////////////
    //User input                                                //
    //  Methods                                                 //
    //////////////////////////////////////////////////////////////
	private State getInput(string literalInput){
        string stringInput = literalInput;
        string[] arrayInput = new string[1];
        if (currentState != State.TABLE)
        {
            stringInput = literalInput.Replace("?", " questionMark ");
            stringInput = stringInput.Replace(",", "");
            stringInput = stringInput.Replace(".", "");
            stringInput = stringInput.Replace("-", "");
            stringInput = stringInput.Replace(":", "");
            stringInput = stringInput.Replace(";", "");
            stringInput = stringInput.Replace("!", "");

            arrayInput = stringInput.Split(' ');
        }
        else
        {
          arrayInput[0] = literalInput;
        }
		if(currentState == State.BEGIN){
            if (literalInput.StartsWith("My name is"))
			{
                userName = literalInput.Substring(11, literalInput.Length - 11);
                systemOutputs.setUserName(userName);
            }
            else
			{
                if(beginningDialogue < 5)
				{
                    bool checkCooperative = false;
                    for (int i = 0; i < arrayInput.Length; i++){
                        if(Inputs.checkUncertain(arrayInput[i]))
						{
                            checkCooperative = false;
                            break;
                        }
                        if(Inputs.checkYes(arrayInput[i]))
						{
                            checkCooperative = true;
                        }
                    }

                    if (!checkCooperative)
					{
                        cooperative = false;
                    }

                }
                else
				{
                    bool stateChange = false;
                    for (int i = 0; i < arrayInput.Length; i++){
                        if(Inputs.checkUncertain(arrayInput[i]))
						{
                            currentState = State.BEGIN;
                            break;
                        }
                        if(Inputs.checkReady(arrayInput[i]))
						{
                            stateChange = true;
                            nextLevelDialogue = 0;
                        }
                    }

                    if (stateChange)
					{
                        currentState = State.TABLE;
                    }
                }
                        tempInput = "";
            }
        }
		else if(currentState == State.TABLE)
		{
            currentState = tableInput(arrayInput);
		}
        else if (currentState == State.NEXT_LEVEL)
        {
            bool stateChange = false;
            for (int i = 0; i < arrayInput.Length; i++){
                if(Inputs.checkUncertain(arrayInput[i]))
				{
                    currentState = State.NEXT_LEVEL;
                    break;
                }
                if(Inputs.checkReady(arrayInput[i]))
				{
                    stateChange = true;
                    nextLevelDialogue = 0;
                }
            }

            if (stateChange)
			{
                currentState = State.TABLE;
            }

            tempInput = "";
 //           if (literalInput.Equals("I'm ready"))
 //               currentState = State.TABLE;
 //           else{
 //           }       //Do not update
        }
		
		return currentState;
	}
	

	private State tableInput(string[] literalInput){
        int problem = Drama.getProblemNumber();
        string expectedAnswer = correctAnswers.getAnswer(problem);
        bool resetNumberOfAttempts = false;
        tempInput = "";
		if ((tableCollider.enter_level_1 == true)||(tableCollider2.enter_level_2 == true)||(tableCollider3.enter_level_3 == true))
        	Drama.updateNumberOfAttempts(resetNumberOfAttempts);
        
        //If player has used up to many attempts on this problem... //
        if (Drama.getNumberOfAttempts() > 3)
		{
			Hints.hint="";
            resetNumberOfAttempts = true;
            Drama.updateNumberOfAttempts(resetNumberOfAttempts);
            Drama.updateProblem(++problem);

            if ((problem == 5) || (problem == 10) || (problem == 15) || (problem == 16))
			{
                currentState = State.NEXT_LEVEL;
            }
 
            return currentState;        
        }
        
        //Otherwise... //

        for (int i = 0; i < literalInput.Length; i++)
        {
            if (literalInput[i].Equals(expectedAnswer))
            {   
				Hints.hint=" ";
                if (Drama.getLevel() == 3)
				{
                    Drama.updateMastery(100 - Drama.getMastery());  //mastery = 100
                }
                else
				{
                    if (Drama.getNumberOfAttempts() == 1)
                        Drama.updateMastery(10);
                    else if (Drama.getNumberOfAttempts() == 2)
                        Drama.updateMastery(8);
                    else if (Drama.getNumberOfAttempts() == 3)
                        Drama.updateMastery(5);
                }

                resetNumberOfAttempts = true;
                Drama.updateNumberOfAttempts(resetNumberOfAttempts);
                Drama.updateProblem(++problem);
            }
            else if (Drama.getNumberOfAttempts() == 3)
			{
                tempInput = "Okay, let's try another one";
            }
        }

        if (Drama.metMasteryThreshold() || ((problem % 5 == 0) && (Drama.getNumberOfAttempts() == 0))) 
		{
            Drama.updateProblem((Drama.getLevel() + 1) * 5);
            currentState = State.NEXT_LEVEL;    //Update the State
        }
        else
		{
		}           //Do not update

       return currentState;
	}
	
}
