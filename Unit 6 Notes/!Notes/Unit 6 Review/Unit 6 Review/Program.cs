using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/

namespace Unit_6_Review
{
    class Program
    {
		static void Main(string[] args)
		{
			string userInput = "";

			//loop 
			while (userInput != "q")
			{
				//call Print menu
				userInput = PrintMenu();

				//if-else-if our way to the right method
				if (userInput.Equals("a"))
				{
					//call the Add() method 
					Console.WriteLine(" Enter 2 numbers: ");
					Console.Write(" ");
					double num1 = Convert.ToDouble(Console.ReadLine());
					Console.Write(" ");
					double num2 = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine(" The sum is " + Add(num1, num2));
				}

				else if (userInput.Equals("b"))
				{
					//call the Subtract() method
					Console.WriteLine(" Enter 2 numbers: ");
					Console.Write(" ");
					double num1 = Convert.ToDouble(Console.ReadLine());
					Console.Write(" ");
					double num2 = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine(" The answer is " + Subtract(num1, num2));
				}

				else if (userInput.Equals("c"))
				{
					//call the Multiply() method
					Console.WriteLine(" Enter 2 numbers: ");
					Console.Write(" ");
					double num1 = Convert.ToDouble(Console.ReadLine());
					Console.Write(" ");
					double num2 = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine(" The answer is " + Multiply(num1, num2));
				}

				else if (userInput.Equals("d"))
				{
					//call the Divide() method
					Console.WriteLine(" Enter 2 numbers: ");
					Console.Write(" ");
					double num1 = Convert.ToDouble(Console.ReadLine());
					Console.Write(" ");
					double num2 = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine(" The answer is " + Divide(num1, num2));
				}

				else if (userInput.Equals("e"))
				{
					//call the IsEven method
					Console.WriteLine(" Enter a number:");
					Console.Write(" ");
					int num1 = Convert.ToInt32(Console.ReadLine());

					string even;

					if (IsEven(num1) == true)
					{
						even = "even";
					}

					else
					{
						even = "odd";
					}

					Console.WriteLine(" The number is " + even);
				}

				else if (userInput != "q")
				{
					Console.WriteLine(" Error");
				}

				Console.WriteLine("\n Press [ENTER] to continue.");
				Console.ReadLine();
				Console.Clear();
			}
		}

		//PrintMenu(): Returns a string!
		static string PrintMenu()
		{
			Console.WriteLine(" A) Add");
			Console.WriteLine(" B) Subtract");
			Console.WriteLine(" C) Multiply");
			Console.WriteLine(" D) Divide");
			Console.WriteLine(" E) Is Even");
			Console.WriteLine(" Q) Quit");
			Console.WriteLine(" What would you like to do?");
			Console.Write(" ");

			string userInput = Console.ReadLine().ToLower();
			return (userInput);

		}

		//Add(): accepts 2 doubles, returns a double
		static double Add(double num1, double num2)
		{
			return (num1 + num2);
		}

		//Subtract()
		static double Subtract(double num1, double num2)
		{
			return (num1 - num2);
		}

		//Multiply()
		static double Multiply(double num1, double num2)
		{
			return (num1 * num2);
		}

		//Divide()
		static double Divide(double num1, double num2)
		{
			return (num1 / num2);
		}

		//IsEven(): accepts 1 int, returns a bool
		static bool IsEven(int num1)
		{
			bool even;
			if (num1 % 2 == 0)
			{
				even = true;
			}

			else
			{
				even = false;
			}

			return even;
		}
	}
}
