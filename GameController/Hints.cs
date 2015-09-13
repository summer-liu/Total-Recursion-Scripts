using UnityEngine;
using System.Collections;

public class Hints : MonoBehaviour{
  
	public static string hint;


     private static string[] hints = new string[] {
		//-----------------1--------------------
        "There are two important rules about recursion:\n \n"+"Every recursive method must have a base case -- a condition under which no recursive call is made -- to prevent infinite recursion.\n"
		+"\nEvery recursive method must make progress toward the base case to prevent infinite recursion.",
		
        "If you trace down the recursive calls, you'll find that fibonacci(n)=fibonacci(n-1)+fibonacci(n-2) for  n>1.",
		
        "Hey, you should be familiar with Fibanacci numbers: 0, 1, 1, 3, 5...",
		
		"Okay...The answer is : 8",
		
		//----------------2---------------------
         "Do you remember the two important rules about recursion:\n \n"+"Every recursive method must have a base case -- a condition under which no recursive call is made -- to prevent infinite recursion.\n"
		+"\nEvery recursive method must make progress toward the base case to prevent infinite recursion.",
		
        
        " Since 28>16, the first recursive call will return mystery(12,16). Then, mystery(12,16) will return mystery(12,4)..Then?",
        
        "Actually it's computing the Greatest Common Divisor of a and b!",
		
		"The answer is: 4 ",
		
		//------------------3-------------------
		"The first hint for you is still the two rules about recursion:\n \n"+"Every recursive method must have a base case -- a condition under which no recursive call is made -- to prevent infinite recursion.\n"
		+"\nEvery recursive method must make progress toward the base case to prevent infinite recursion.",
		
        
        " The answer is:Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while divide (/) by 10 removes the rightmost digit (126 / 10 is 12).",
        
        "Actually it's computing the sum of every digit of this number",
		
		"The answer is: 12",
		
		//----------------4---------------------
		"How recursion really works:\n \n"+"At runtime, a stack of activation records (ARs) is maintained: one AR for each active method, where active means: has been called, has not yet returned.\n \n"+"Each AR includes space for\n"
		+"the method's parameters,\n"+"the method's parameters,\n"+"the return address -- where (in the code) to start executing after the method returns.\n \n"
		+"When a method is called, its AR is pushed onto the stack. The return address in that AR is the place in the code just after the call (so the return address is the 'marker' for the previous 'clone').\n \n"
		+"When a method is about to return, the return address in its AR is saved, its AR is popped from the stack, and control is transferred to the place in the code referred to by the return address.",
		
		"When calling method(253), method(25) will be called and be put into stack. Then method(2) is called and put into stack. Then method(0), which is the base case, is called. And it will be poped out. Now the part of code after method(2) will be executed . The systemout put is 0. Then the remaining part of method(25) is executed..Get it? ",
		
		"Actually, it's judging if each digit of the number is an odd number! If is , the output of the digit is 1, else is 0",
		
		"The answer is: 011",
		
		//-------------------5-----------------
		"How recursion really works:\n \n"+"At runtime, a stack of activation records (ARs) is maintained: one AR for each active method, where active means: has been called, has not yet returned.\n \n"+"Each AR includes space for\n"
		+"the method's parameters,\n"+"the method's parameters,\n"+"the return address -- where (in the code) to start executing after the method returns.\n \n"
		+"When a method is called, its AR is pushed onto the stack. The return address in that AR is the place in the code just after the call (so the return address is the 'marker' for the previous 'clone').\n \n"
		+"When a method is about to return, the return address in its AR is saved, its AR is popped from the stack, and control is transferred to the place in the code referred to by the return address.",
		
		"When method(n-1) is called, it's pushed onto the stack.  Then method(n-1) will be executed. When method(n-1) is about to return, its AR is popped from the stack. And the code will continue to execute from the return address",
		
		"method(n-1) will call method(n-2). Method(n-2) will call method(n-3)….Until the base case is reached, B will be printed. And method(0) will popped out from stack, then method(1), then method(2)…. When method(5) is popped out from the stack, the code will continue to execute from the return address of method(5), which is the line after is(print R). ",
		
		"The answer is : BRRRRR",
		
		//-----------------------6-------------------
		"OK..actually you should see this code at level 1. Do you remember it? what's the base case for Fibonacci numbers?",
		
		"There are two base cases for fibonacci numbers, when number equals 1 or 0 ",
		
		"Hey, you should be familiar with Fibanacci numbers: 0, 1, 1, 3, 5... So, the base case is?",
		
		"The answer is : number",
		
		//-----------------------7-------------------
		
		"Notice that for n>0, f(n) = 1 + 1 / f(n-1)",
		
		"Remember that recursion function will call itself within the program text.",
		
		"When you want to compute golden(n), if n is not 0, you just need to recursively call 1+1/golden(n-1).",
		
		"The answer is :  1+1/golden(n-1)",
		
		//-----------------------8-------------------
		"The binary search algorithm is a method of searching a sorted array for a single element by cutting the array in half with each recursive pass. The trick is to pick a midpoint near the center of the array, compare the data at that point with the data being searched and then responding to one of three possible conditions: the data is found at the midpoint, the data at the midpoint is greater than the data being searched for, or the data at the midpoint is less than the data being searched for. ",
		
		"The situation you need to complete is : what should return when target > a[mid]? ",
		
		"Okay, if target is larger than a[mid], we should search in the upper side of a, which is a[mid+1] to a[last].",
		
		"The answer is :  binarySearch (target,mid+1,last)",
		
		//-----------------------9-------------------
		"Since a palindrome can be interpreted the same way in either forward or reverse direction, the first and last character are the same. ",
		
		"And, if the first and last character is the same, we need to decide if the second and penultimate character are the same. Here you need to notice the index of first character 0, and the index of the last character is string.length()-1. ",
		
		"So, if the first and last character are the same, we just need to recursively strip the first and last character and decide if the substring is palindrome. ",
		
		"The answer is :  message.substring(1,message.length()-2)",
		
		//-----------------------10-------------------
		"Do you remember how to convert a decimal number to a binary number? When converting from decimal to binary the mathematical way is simplest. Start with the decimal number you want to convert and start dividing that number by two, keeping track of the remainder after each complete division. Every time you divide by two, you will divide evenly (0) or get a remainder of one (1). Following the pattern to the end, you will get a binary number. Write the remainders in the order they were generated from right to left and the result is the equivalent binary value. ",
		
		"Remember that recursion function will call itself within the program text.",
		
		"So what you need to do is recursively divide 2 into N and read the remainders backwards",
		
		"The answer is :  covert(n/2)",
		
		//-----------------------11------------------
	    "This should be an easy question. I'm thinking if I should give you the hint..",
		
		"Okay,remember that to traverse a tree, we can first visit the root, then visit the entire left subtree, then visit the entire right subtree. ",
		
		"So what you need to complete is how to traverse the right subtree. It's similar to traversal of the left subtree.",
	
		"The answer is :  preOrder(tree.right)",
		
		//-----------------------12-------------------
		"Remember the job of the recursive cases can be seen as breaking down complex inputs into simpler ones. So, if you need to compute the size of a tree, you can instead compute the size of the left subtree and right subtree.",
		
		"But one more thing to remember, when you get the size of the left subtree and right subtree, don't forget the current node.",
				
		"So, the size of the tree is the sum of left subtree and right subtree, plus 1, which is the current node",
		
		"The answer is :  1+tree_size(tree.left)+tree_size(tree.right)",
		
		//-----------------------13-------------------
		"This question is similar to the binary search problem you met in level 2.",
		
		"When you didn't find the data in the left subtree, you just need to search the right subtree.",
		
		"Did you get it? it should be similar to binary_search of the left subtree.",
		
		"The answer is :  binary_search(tree.right,data)",
		
		//-----------------------14------------------
		"Okay, here is a hint: you can use Math.max( , ) to compare two numbers.",
		
		"It's similar to the tree size problem, but not that similar. To get the height of tree, you can first get the height of the left and right subtree, and see which one is higher. Again, don't forget the current node.",
		
		"ok..one more hint... 1+ Math.max( ?, ? )",
		
		"The answer is :  1+Math.max(height(tree.left),height(tree.right))",
		
		//-----------------------15------------------
		"Okay, to compare if two trees are equal, you just need to recursively compare if the subtrees are equal.",
		
		"If two trees are equal, the left subtree of tree1 and tree2 are equal, and the right subtree of tree1 and tree2 are equal.",
		
		"Okay, one more hint: equal_trees( ?, ?) && equal_trees(?,?).",
		
		"The answer is :\n  equal_trees(tree1.left, tree2.left)&&equal_trees(tree1.right,tree2.right)",
		
		//-----------------------16-------------------
		
		"To crack the password:\n public static void main(String[] args ){\n     int[] guess={0,0,0,0};\n       if(crack(password,guess,0)==true)\n            System.out.println('Get it');\n         else\n               System.out.println('Failed');",
		
		"To crack the password, call crack(password,guess,0). The password has 4 digits. What the recursive call do is:first, it will try all possiblity of last digit, from 0 to 9. Then, it will try every possibility of the third and last digits from 00 to 99.",
		
		//"",
		
		"So,first, crack(password,guess,0)is called, no digit has been cracked. Then it will call(password,guess,?) to crack the last digit, then call(password,guess,?) to crack the last two digits.... ",
		
		"The answer is :  password,guess,n+1"
    };
	
	public Hints(){
		
		hint="";
	}

	void OnGUI(){
		 GUI.depth=1;
		
		GUI.Label(new Rect(750, 150, 380, 500),hint);  //the lable to display hints.
		
		if((tableCollider.enter_level_1==true)||(tableCollider2.enter_level_2==true)||(tableCollider3.enter_level_3==true)||(safeCollider.enter_level_4==true))
		{	
	       
			if(Drama.getNumberOfAttempts()==3)
				hint=hints[Drama.getProblemNumber()*4+3];
			//if(Drama.getNumberOfAttempts()>3)
				//hint=" ";
			
			if(GUI.Button (new Rect (900,400,100,30), "Hints"))
		{
				
				hint=hints[Drama.getProblemNumber()*4+Drama.getNumberOfAttempts()];
	
		}
	
	}

}
}