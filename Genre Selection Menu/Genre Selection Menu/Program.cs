using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Genre_Selection_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("\t\tGame Selection Menu");
			Console.WriteLine("====================================================\n");
			Console.WriteLine(" A) JRPG");
			Console.WriteLine(" B) Survival Horror");
			Console.WriteLine(" C) Platformer");
			Console.WriteLine(" D) Action Adventure");
			Console.WriteLine(" E) Fighter\n");

			Console.WriteLine(" Which game do you choose?\n ");
			string userInput = Console.ReadLine();
			Console.WriteLine();
			userInput = userInput.ToLower();

			if (userInput.Contains("a"))
			{
				Console.WriteLine(" You have selected A for JRPG.  Those are my favorite!");
			}
			else if (userInput.Contains("b"))
			{
				Console.WriteLine(" You have selected B for Survival Horror.  I love games like that!");
			}
			else if (userInput.Contains("c"))
			{
				Console.WriteLine(" You have selected C for Platformer.  Those are amazing!");
			}
			else if (userInput.Contains("d"))
			{
				Console.WriteLine(" You have selected D for Action Adventure.  That's a great choice!");
			}
			else if (userInput.Contains("e"))
			{
				Console.WriteLine(" You have selected E for Fighter.  I love fighting games!");
			}
			else
			{
				Console.WriteLine(" ERROR");
			}

			Console.WriteLine();
		}
    }
}
