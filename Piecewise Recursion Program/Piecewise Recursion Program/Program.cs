using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Piecewise_Recursion_Program
{
    class Program
    {
		static void Main(string[] args)
		{
			//Question 1
			Console.WriteLine(" Question 1:");
			Console.WriteLine("        |  f( x - 4 ) + 2  if x > 10");
			Console.WriteLine(" f(x) = |");
			Console.WriteLine("        |  -7              if x <= 10");
			Console.WriteLine("\n f(25) = " + Piecewise1(25));
			Console.WriteLine("\n----------------------\n");

			//Question 2
			Console.WriteLine(" Question 2:");
			Console.WriteLine("        |  f( x / 12 + 5 ) - 3  if x > 25");
			Console.WriteLine(" f(x) = |");
			Console.WriteLine("        |  20                   if x <= 25");
			Console.WriteLine("\n f(30) = " + Piecewise2(30));
			Console.WriteLine("\n----------------------\n");

			//Question 4
			Console.WriteLine(" Question 4:");
			Console.WriteLine("        |  f( x * 2) - 4  if x <= 20");
			Console.WriteLine(" f(x) = |");
			Console.WriteLine("        |  -100                   if x > 20");
			Console.WriteLine("\n f(500) = " + Piecewise4(500));
			Console.WriteLine("\n----------------------\n");
		}


		//Question 1
		static int Piecewise1(int x)
		{
			if (x <= 10)
			{
				return -7;
			}

			else
			{
				return Piecewise1(x - 4) + 2;
			}
		}


		//Question 2
		static int Piecewise2(int x)
		{
			if (x <= 25)
			{
				return 20;
			}

			else
			{
				return Piecewise2(x / 12 + 5) - 3;
			}
		}


		//Question 4
		static int Piecewise4(int x)
		{
			if (x > 20)
			{
				return -100;
			}

			else
			{
				return Piecewise4(x * 2) - 4;
			}
		}
	}
}
