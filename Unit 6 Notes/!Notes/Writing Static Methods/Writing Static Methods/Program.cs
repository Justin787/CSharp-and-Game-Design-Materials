using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/

namespace Writing_Static_Methods
{
    class Program
    {
		static void Main(string[] args)
		{
			//call the PrintThing() method
			Console.WriteLine("Calling PrintThing method.");
			PrintThing();

			//declare 2 ints and send them to swap()
			int x = 7, y = 2;
			Console.WriteLine("x = " + x + " and y = " + y);
			Console.WriteLine("Calling swap method ");
			Swap(x, y);
			Console.WriteLine("x = " + x + " and y = " + y);

			//call the sum() method and print the result
			int sum = Add(x, y);
			Console.WriteLine("\n the sum of x and y is: " + sum);
			Console.WriteLine("\n the sum of x and y is: " + Add(x, y));
		}

		//Write a method to print a thing
		//no return value, no arguments
		static void PrintThing()
		{
			Console.WriteLine("a thing");
		}

		//method that takes in two ints and swaps them
		static void Swap(int x, int y)
		{
			int temp = x;
			x = y;
			y = temp;
			Console.WriteLine("After swap: x = " + x +
				" and y = " + y);
		}

		//method that takes 2 ints and returns their sum
		static int Add(int x, int y)
		{
			int sum = x + y;
			return sum;

			/*no code below the return statement will execute*/
		}
	}
}
