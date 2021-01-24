using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Halloween_Review
{
    class Program
    {
        static void Main(string[] args)
        {
			string input = "";
			Random rng = new Random();



			while (input != "quit")//Keep going until user says quit
			{
				//Print the menu
				Console.WriteLine("Choose a truly terrifying option!:");
				Console.WriteLine("MANGLE a two-word phrase!");
				Console.WriteLine("Count to an EVIL NUMBER!");
				Console.WriteLine("...Or be a coward and QUIT");

				//Get the user's selection
				input = Console.ReadLine().ToLower();

				//Do some stuff
				if (input == "mangle")//mangle a phrase
				{
					Console.WriteLine("Enter a two-word command: ");
					string command = Console.ReadLine();

					//make sure it has space
					if (command.Contains(" "))
					{
						int spaceindex = command.IndexOf(" "); //Index of the space
						string verb = command.Substring(0, spaceindex);
						string noun = command.Substring(spaceindex + 1);

						Console.WriteLine("HA HA HA, I HAVE MANGLED YOUR PHRASE:");
						Console.WriteLine("First piece: " + verb);
						Console.WriteLine("Second piecs: " + noun);
					}
					else //if it doesnt have a space
						Console.WriteLine("I SAID TWO WORDS, NOW DIE");
				}
				else if (input == "evil number")//count to a number
				{
					int value = rng.Next(1, 667);
					Console.WriteLine("I will count to " + value);

					//count until we reach given number
					int count = 1;
					while (count <= value)
					{
						Console.Write(count + 1);
						Console.Write(" ");
						count++;
					}

				}
				else if (input == "quit")//quit program
				{
					//do nothing the loop will break on this value
				}
				else //bad input
				{
					Console.WriteLine("YOU HAVE SINNED!");
				}

				//Repeat this process until they say quit}


				// clean up output at end of loop
				Console.WriteLine("\n[Press enter to continue]");
				Console.ReadLine();
				Console.Clear(); //Clear screen after they press enter



			}
		}
    }
}
