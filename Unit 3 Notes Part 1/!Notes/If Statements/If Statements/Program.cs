using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
			//A flowchart helps keep track of program progression. decision points are represented by diamonds ///// This is if you physically draw a flow chart on paper
			// New Keyword: if
			//an if statement is structured as the work "if" followed by a boolean condition in parenthesis and then a block or line

			//declare some variables
			double num1, num2;
			Console.Write("Enter num1: ");
			num1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter num2: ");
			num2 = Convert.ToDouble(Console.ReadLine());

			//Decision point(if statement)                              // = assignment       == comparison
			if (num1 > num2) //boolean condition
			{
				//Block of code or not run
				Console.WriteLine("num1 is bigger!!");
			}

			if (num1 < num2)
			{
				Console.WriteLine("num2 is bigger!!");
			}

			if (num1 == num2)
			{
				Console.WriteLine("They're the same, WHAT??");
			}

			Console.Write("Do you eat pizza? (Yes/No) ");
			string input = Console.ReadLine();

			if (input.ToLower() == "yes")
			{
				Console.WriteLine("Woah me too!");
			}

			if (input.ToLower() == "no")
			{
				Console.WriteLine("You are a demon!");
			}
		}
    }
}
