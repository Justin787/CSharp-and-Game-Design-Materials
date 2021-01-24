using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
			//A while loop checks a boolean condition and runs the block of code repeatedly as long as the condition is true
			//declare an int value
			int tigers = 0;

			//loop while there are fewer than 10 tigers
			while (tigers < 10)
			{
				//get additional tigers
				Console.WriteLine(" Current Tigers: " + tigers);
				Console.Write(" How many tigers shall we add?  ");
				int add = Convert.ToInt32(Console.ReadLine());
				tigers += add;
				Console.WriteLine();
			}

			Console.WriteLine(" Bad news: You were eaten by " + tigers + " tigers.");
			Console.WriteLine(" That was actually pretty irresponsible.\n");

			Console.WriteLine(" Max Tigers: " + (Int32.MaxValue));
			Console.WriteLine();
			//add = 5 //"add" doesn't exist here

			Console.WriteLine("\n Good news: You get to be a ThPoOkY GhOsT!!");

			int enemyHP = 1000;
			while (enemyHP > 0)
			{
				Console.WriteLine(" The Ghostbusters are here!");
				Console.WriteLine(" Will you spook, scare, possess, or poltergize?");
				string move = Console.ReadLine().ToLower();

				if (move == "spook" || move == "scare")
					enemyHP -= 250;
				else if (move == "possess")
					enemyHP -= 800;
				else if (move == "poltergize")
				{
					Console.WriteLine(" You successfully confuse them");
					enemyHP -= 1;
				}

				else if (move == "just straight up kill them") //Secret move
					break; //Break the loop right away
				else
					Console.WriteLine(" You say 'BOO' but they aren't affected");
				Console.WriteLine();

			}
			Console.WriteLine(" You defeated the Ghostbusters!");
			Console.WriteLine("The franchise will finally end.");
		}
    }
}
