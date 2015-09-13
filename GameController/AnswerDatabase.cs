using UnityEngine;
using System.Collections;

public class AnswerDatabase {

    private static string[] answers = new string[] {
		"8",      //correct answer to problem 01
		"4",      
		"12", 
		"011", 
		"BRRRRR",

        "number",
        "1+1/golden(n-1)",
        "binarySearch (target,mid+1,last)",
        "message.substring(1,message.length()-2)",
        "covert(n/2)",

        "preOrder(tree.right)",
        "1+tree_size(tree.left)+tree_size(tree.right)",
        "binary_search(tree.right,data)",
        "1+Math.max(height(tree.left),height(tree.right))",
        "equal_trees(tree1.left, tree2.left)&&equal_trees(tree1.right,tree2.right)",

        "password,guess,n+1"
	};

    public string getAnswer(int index)
    {
        return answers[index];
    }	
	
}
