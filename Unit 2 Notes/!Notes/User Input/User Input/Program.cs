using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
			// console.readline() for user input
			//Cant be an int, must be a string
			Console.Write("Enter something!\n");
			string input = Console.ReadLine();
			Console.WriteLine("You entered: " + input);
			Console.WriteLine("The first letter is " + input[0]);

			//Convert.ToDouble(string) and Convert.ToInt(string) to convert (most common convert methods)
			//conversions and calculations
			Console.Write("Give an integer: ");
			string input2 = Console.ReadLine(); //accept string
			int num1 = Convert.ToInt32(input2); //convert to int
			Console.Write("Give an integer: ");
			string input3 = Console.ReadLine(); //accept string
			double num2 = Convert.ToDouble(input3); //convert to double

			Console.WriteLine("the product is " + (num1 + num2));
			Console.WriteLine();
		}
    }
}
