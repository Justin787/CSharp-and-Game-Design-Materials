using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Printing_Methods
{
    class Program
    {
		static string nyoom = "";

		static void Main(string[] args)
		{
			while (nyoom != "quit")
			{
				PrintHeader();
				string userInput = PrintMenu();

				if (userInput.Equals("a"))//favorite sports team
				{
					Console.WriteLine(" Which sport? (basketball, football)");
					Console.Write(" ");
					string sport = Console.ReadLine().ToLower();


					Console.WriteLine(SportsTeam(sport));
					Console.WriteLine(" Press [Enter] to continue");
					Console.ReadLine();


				}

				else if (userInput.Equals("b"))//guess my age
				{
					Console.WriteLine(" How old do you think I am?");
					Console.Write(" ");
					int guess = Convert.ToInt32(Console.ReadLine());

					GuessAge(guess);
				}

				else if (userInput.Equals("c"))//how many video games i own
				{
					NumberOfGames();
				}

				else if (userInput.Equals("d"))//quit
				{
					nyoom = "quit";
				}

				else
				{
					Console.WriteLine(" ERROR");
					Console.WriteLine(" Press [Enter] to continue");
					Console.ReadLine();
				}
				Console.Clear();
			}

		}

		static void PrintHeader()
		{
			Console.WriteLine(" \t\t[Information about Justin]\n");
		}

		static string PrintMenu()/////////////////
		{
			string menu =
						  " A) Print my favorite sports team" +
						  "\n B) Guess my age" +
						  "\n C) Find out how many video games I own" +
						  "\n D) Quit Program" +
						  "\n\n What would you like to do?";
			Console.WriteLine(menu);
			Console.Write(" ");
			string selection = Console.ReadLine();

			return selection;
		}

		static string SportsTeam(string sport)
		{
			string team = "";

			if (sport == "basketball")
			{
				team = "\n My favorite basketball team is the Cleveland Cavaliers";
			}

			else if (sport == "football")
			{
				team = "\n My favorite football team is the Detroit Lions";
			}

			else
				team = " ERROR";

			return team;
		}

		static void GuessAge(int guess)
		{
			Console.WriteLine();

			if (guess == 15)//guess is right
			{
				Console.WriteLine(" That is correct!!");
			}

			else if (guess > 15)//guess is too high
			{
				Console.WriteLine(" Sorry, you're wrong.  Your guess is too high.  I am 15.");
			}

			else if (guess < 15)//guess is too low
			{
				Console.WriteLine(" Sorry, you're wrong.  Your guess is too low.  I am 15.");
			}

			Console.WriteLine(" Press [Enter] to continue");
			Console.ReadLine();
		}

		static int NumberOfGames()
		{
			int gametotal = 250;
			Console.WriteLine("\n I own " + gametotal + " games.");
			Console.WriteLine(" Press [Enter] to continue");
			Console.ReadLine();
			return gametotal;

		}
	}
}
