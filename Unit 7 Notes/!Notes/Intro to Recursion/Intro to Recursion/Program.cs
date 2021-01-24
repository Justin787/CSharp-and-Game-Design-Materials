using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Intro_to_Recursion
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("f(85) = " + Piecewise(85));
		}

		//recursive method to solve function
		static int Piecewise(int x)
		{
			//base case: f(x) = 7 if x <= 62
			if (x <= 62)
			{
				Console.WriteLine("Base Case: " + x + " is less than or equal to 62,");
				Console.WriteLine(" so f(" + x + ") = 7.");
				return 7;
			}

			//Recursive step: f(x) = f(x-8) + 3 if x > 62
			else
			{
				Console.WriteLine("Recursive step: " + x + " is greater than 62,");
				Console.WriteLine(" so f(" + x + ") = f(" + (x - 8) + ") + 3.");
				Console.WriteLine();
				return Piecewise(x - 8) + 3; //recursive call
			}
		}
	}
}
