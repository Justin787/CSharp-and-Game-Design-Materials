using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Recursion_Part_2
{
    class Program
    {
		static void Main(string[] args)
		{
			//find a Fibonacci value
			Console.Write("Which Fibonacci value do you want?");
			int fib = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(" Fibonacci value #" + fib + " = " + Fibonacci(fib));

			//check if a number is prime
			Console.Write("what number should i check for primeliness");
			int num = Convert.ToInt32(Console.ReadLine());
			if (IsPrime(num))
				Console.WriteLine("Yes, " + num + " is prime");
			else
				Console.WriteLine("No, " + num + " is not prime");

		}


		//Fibonacci sequence: starts with 1, 1; each number beyond that is the sum of the two numbers before it
		//1, 1, 2, 3, 5, 8, 13, 21...
		//f(x) = f(x-1) + f(x-2)

		static int Fibonacci(int input)
		{
			//base case 1st and 2nd numbers are 1
			if (input == 1 || input == 2)
				return 1;


			else
				return Fibonacci(input - 1) + Fibonacci(input - 2);



		}


		static bool PrimeChecker(int input, int current)
		{
			if (current == 1)
				return true;
			else if (input % current == 0)
				return false;
			else
				return PrimeChecker(input, current - 1);
		}

		//helper method to set starting values
		static bool IsPrime(int num)
		{
			int firstfactor = num / 2;
			return PrimeChecker(num, firstfactor);
		}
	}
}
