using System;
using System.Threading;//Allows you to use Thread.Sleep()
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Useful_Tools
{
    class Program
    {
        static void Main(string[] args)
        {
			//keyword: new - makes space in memory for a new object
			//To generate a random integer, use the random class
			Random rng = new Random();
			int rand = rng.Next(1, 11); //between 1 and 10
										//                                int rand = rng.Next(int low, int hi);
										//                                                  ^this stores a random number between "low" and the number one less than "hi" in an int called "rand"

			Console.WriteLine("Your random number is: " + rand);

			//To make program pause for a specified length of time, add "using System.Threading;" to the top of your code
			//Then use this method for specified number of miliseconds (1000 = 1 second):
			//using sleep()
			Console.WriteLine("\nProgram will self destruct in 5...");
			Thread.Sleep(1000); //wait for 1 second
			Console.WriteLine("\nProgram will self destruct in 4...");
			Thread.Sleep(1000); //wait for 1 second
			Console.WriteLine("\nProgram will self destruct in 3...");
			Thread.Sleep(1000); //wait for 1 second
			Console.WriteLine("\nProgram will self destruct in 2...");
			Thread.Sleep(1000); //wait for 1 second
			Console.WriteLine("\nProgram will self destruct in 1...");
			Thread.Sleep(1000); //wait for 1 second
			Console.WriteLine("\nHA GOTTEM!!");
			Thread.Sleep(2000);
			Console.Clear(); // Clear the screen
			Thread.Sleep(2000);
			Console.WriteLine("System reboot completed.");
			Thread.Sleep(3000);
			Console.Clear();
			//Change font color
			Thread.Sleep(1000);
			Console.WriteLine("Changing color: ");
			Console.ForegroundColor = ConsoleColor.Magenta;
			Thread.Sleep(1000);
			Console.WriteLine("Color change executed");
			Console.ForegroundColor = ConsoleColor.Gray;
			Thread.Sleep(1000);
			Console.WriteLine("IT WENT HORRIBLY WRONG!!!");
			Console.ResetColor(); //Reset color 
		}
    }
}
