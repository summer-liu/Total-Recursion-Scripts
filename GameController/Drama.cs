using UnityEngine;
using System.Collections;

public class Drama{
	private static float mastery = 0;
	private static int answerStack = 0;
    private static int problemNumber = 0;
    private static int numberOfAttempts = 0;
    private static int level = 0;
/*	
	public Drama () {
		mastery = 0;
		answerStack = 0;
        problemNumber = 0;
        numberOfAttempts = 0;
	}
*/	
	public static void updateMastery(float increase) {
		mastery += increase;
	}
	
	public static void addToStack() {
		answerStack++;
	}

    public static void updateProblem(int newProblem){
        problemNumber = newProblem;
    }

    public static void updateNumberOfAttempts(bool reset) {
        if (reset)
            numberOfAttempts = 0;
        else
            numberOfAttempts++;
    }

    public static void updateLevel() {
        level++;
    }




	public static float getMastery() {
		return mastery;
	}
	
	public static int getStack() {
		return answerStack;
	}

    public static int getProblemNumber(){
        return problemNumber;
    }

    public static int getNumberOfAttempts() {
        return numberOfAttempts;
    }

    public static int getLevel(){
        return level;
    }

    public static bool metMasteryThreshold(){
        bool thresholdMet = false;

        if (level == 0){
            if (mastery >= 24) {
                thresholdMet = true;
            }
        }
        else if (level == 1) {
            if (mastery >= 48) {
                thresholdMet = true;
            }
        }
        else if (level == 2){
            if (mastery >= 72) {
                thresholdMet = true;
            }
        }
        else if (level == 3){
            if (mastery >= 100){
                thresholdMet = true;
            }
        }

        return thresholdMet;
    }
	
}
