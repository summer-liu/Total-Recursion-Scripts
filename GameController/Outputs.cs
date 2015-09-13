using UnityEngine;
using System.Collections;

public class Outputs{
    private static string userName;

    public void setUserName(string name){
        userName = name;
    }

    private static string[] beginOutput = new string[] {
        "Who's there?",
        "? Um...Are you here to help me?",
        "Ah! Someone to help me at last! My name is Alex. Can I just tell you what we need to do?",

        "Well, the R4R made this prison some sadistic recursion game, filled " +
            "with recursion artwork and  puzzles. Can you help me solve recursion problems, " +
            "so I can escape?",
        
        "Oh!  But they said I have to solve them before I have a \"stack " +
            "overflow\" problem, which happens if I don't answer the " +
            "questions efficiently enough, I guess.  So, we gotta be careful. " +
            "You want to look around the room - see what you're getting into?",
        
        "Okay, I'm sure there's no way to escape, though - I've looked " +
            "everywhere. Just use the arrow keys on your keyboard to tell me " +
            "where to move. The questions I need to answer are on the " +
            "computer on the table."
    };

	public string getBegin(int index){
		return beginOutput[index];
	}

	private static string[] tableOutput = new string[] {
        //Cluster 0
		"I have no idea on this problem.  What do you think the answer is?", 
		"Uhh...That doesn't seem to be the right answer...", 
		"One more try - any ideas?", 
		"Oh no, we aren't starting off well.  You need to help me!", 

        //Cluster 1
		"Ah!  Let me see...No, this is another one I just don't get.  What do you say it is?",
        "I guess that wasn't correct.",
        "We have one more try on this one.  You think you got it?",
        "Agh!  I'm doomed.  We need to do better so my mastery score goes up!",

        //Cluster 2
        "Okay - well, I know this is question 3.  You're gonna have to tell me what answer 3 is, though. I feel useless.",
        "That doesn't seem to be right",
        "Sigh.  I'm beginning to think I'm doomed to stay in this prison forever.  My fault for being so useless...Any other guesses?",
        "Well, maybe we'll get the next one",

        //Cluster 3
		"These problems are hard! Please tell me you know the answer.",
        "No luck.  I wish I were more help",
        "One more chance.  Please - think hard - I see my stack is growing, and my mastery score is still low!",
        "Ugh...we're really not doing well",

        //Cluster 4
        "Let's see if we can get this question 5 right.  Hmm...I don't know it.  What do you think the answer is?",
        "Eh...No.  ",
        "Please - this is our last chance.  Don't you have any idea what it might be?",
        "Wow - well, at least I don't feel bad about not knowing anything about recursion.  Because apparently I'm not the only one."
	};

	public string getTable(int index){
		return tableOutput[index];
	}

    private static string[] nextLevelOutput = new string[] {
        "Well, at least we can get out of this room, now - I've been stuck here too " +
            "long. Mind if we get moving?",
        "Aha - well, I got no need to dawdle here - you?",
        "Hm...this is a nice room, I'm kind of sad to leave.  But it's good, because I think " +
            "we're close to getting me out of here.  What do you think?",
        "Alright - I guess we should get a move on. " +
            "Please use the arrow keys to maneuver us over through the door now, to get to some " +
            "new room...with some new puzzles.  I don't know..." +
            "I have a bad feeling about this...",
        "Thanks for all your help so far.  Just let me know " +
            "when you're ready to solve some more puzzles, and I " +
            "will do my best to make some contribution."
    };

    public string getNextLevel(int index) {
        return nextLevelOutput[index];
    }
        
	





/*	
	private static string[] queryOutput = new string[] {
		"output1", 
		"output2", 
		"output3", 
		"output4", 
		"output5"
	};
	public string getQuery(int index){
		return queryOutput[index];
	}

	
	
	private static string[] exploreOutput = new string[] {
		"output1", 
		"output2", 
		"output3", 
		"output4", 
		"output5"
	};
	public string getExplore(int index){
		return exploreOutput[index];
	}
	*/
	

}
