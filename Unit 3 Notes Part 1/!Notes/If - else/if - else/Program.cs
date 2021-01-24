using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace if___else
{
    class Program
    {
        static void Main(string[] args)
        {
			//get input from user
			Console.Write("How much money ya got?");
			string money = Console.ReadLine();
			double dmoney = Convert.ToDouble(money);

			//if-else logic
			if (dmoney >= 100)
			{
				Console.WriteLine("You ballin'");
			}
			else
			{
				Console.WriteLine("LOL u poor");
			}

			//if-else-if logic
			Console.WriteLine(" Name a color:  ");
			string color = Console.ReadLine();

			if (color == "red")
			{
				Console.WriteLine("yeah, like BLOOD");

			}

			else if (color == "blue")
			{
				Console.WriteLine("Blue LIke the SEA");

			}

			else if (color == "green")
			{
				Console.WriteLine("hmmmm...      trees are green");

			}

			else
			{
				Console.WriteLine("Thats a boring color");
			}
		}
    }
}
