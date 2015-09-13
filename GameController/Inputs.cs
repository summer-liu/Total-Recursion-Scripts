using UnityEngine;
using System.Collections;

public class Inputs{
    private static string YES_LIST = "yes yeah ya yeh yus y sure alright aright indeed fine okay ok " +
            "okey okey-dokey absolutely lets let's good cool righto certainly definitely definately def";
    private static string[] YES = YES_LIST.Split(' ');

    private static string NO_LIST = "no na nah nein nope not n";
    private static string[] NO = NO_LIST.Split(' ');

    private static string UNCERTAIN_LIST = "not won't don't wouldn't can't couldn't wont dont wouldnt cant " +
            "couldnt guess hard impossible confuse confusing confused confuses unsure uncertain " +
            "difficult tricky dunno havent haven't";
    private static string[] UNCERTAIN = UNCERTAIN_LIST.Split(' ');

    private static string QUESTION_LIST = "why what how where who wha when questionmark";
    private static string[] QUESTION = QUESTION_LIST.Split(' ');

    private static string BACK_LIST = "backward backwards back return retreat";
    private static string[] BACK = BACK_LIST.Split(' ');

    private static string FORWARD_LIST = "forward forwards onward onwards front ahead again same";
    private static string[] FORWARD = FORWARD_LIST.Split(' ');

    private static string READY_LIST = "ready set prepared solve";
    private static string[] READY = READY_LIST.Split(' ');




    public static bool checkYes(string inputWord)
    {
        string input = inputWord;
        for (int i = 0; i < YES.Length; i++)
        {
            if (input.Equals(YES[i], System.StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    public static bool checkNo(string inputWord)
    {
        string input = inputWord;
        for (int i = 0; i < NO.Length; i++)
        {
            if (input.Equals(NO[i], System.StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    public static bool checkUncertain(string inputWord)
    {
        string input = inputWord;
        for (int i = 0; i < UNCERTAIN.Length; i++)
        {
            if (input.Equals(UNCERTAIN[i], System.StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    public static bool checkQuestion(string inputWord)
    {
        string input = inputWord;
        for (int i = 0; i < QUESTION.Length; i++)
        {
            if (input.Equals(QUESTION[i], System.StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    public static bool checkQuestionMark(string inputWord)
    {
        string input = inputWord;
        if (input.Equals(QUESTION[7], System.StringComparison.InvariantCultureIgnoreCase))
        {
            return true;
        }

        return false;
    }

    public static bool checkBack(string inputWord)
    {
        string input = inputWord;
        for (int i = 0; i < BACK.Length; i++)
        {
            if (input.Equals(BACK[i], System.StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    public static bool checkForward(string inputWord)
    {
        string input = inputWord;
        for (int i = 0; i < FORWARD.Length; i++)
        {
            if (input.Equals(FORWARD[i], System.StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    public static bool checkReady(string inputWord)
    {
        string input = inputWord;
        for (int i = 0; i < READY.Length; i++)
        {
            if (input.Equals(READY[i], System.StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }
}
