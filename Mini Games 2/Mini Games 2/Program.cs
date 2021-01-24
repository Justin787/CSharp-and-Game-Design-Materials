using System;
using System.Threading;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Mini_Games_2
{
    class Program
    {
        static void Main(string[] args)
        {
			string non = "boop";

			while (non == "boop")
			{
				//Game selection menu
				Console.WriteLine("\t\tGame Selection Menu");
				Console.WriteLine("====================================================\n");
				Console.WriteLine(" A) Riddle");
				Console.WriteLine(" B) Complex Arithmetic (Trust me, you don't want this one)");
				Console.WriteLine(" C) Mad Libs");
				Console.WriteLine(" D) Guessing Game");
				Console.WriteLine(" E) Exit menu");

				Console.WriteLine("\n Which game do you choose?\n ");
				Console.Write(" ");
				string userInput = Console.ReadLine();
				Console.WriteLine();
				userInput = userInput.ToLower();



				if (userInput.Equals("a")) //Riddle mini game
				{
					Console.WriteLine(" You have selected A for Riddle");
					Console.WriteLine();
					Thread.Sleep(2000);
					Console.Clear();


					//Mini game start
					int tries = 2;
					string useless = "this is a useless string";
					while (useless == "this is a useless string")
					{
						Console.WriteLine(" \t\t\tRiddle");
						Console.WriteLine("====================================================\n");
						Console.WriteLine(" Your riddle is:\n");
						Thread.Sleep(250);
						Console.WriteLine(" What is black, white, and red all over?\n");//Riddle
						Console.WriteLine(" Your answer: ");
						Console.Write(" ");
						string riddleInput = Console.ReadLine();//User Input
						riddleInput = riddleInput.ToLower();

						if (riddleInput.Contains("a penguin in a blender"))//Right answer
						{
							Console.WriteLine("\n You are CORRECT!!!");
							break;
						}
						else if (tries <= 0)//Wrong answer, no tries left
						{
							Console.WriteLine("\n You're out of tries... A for effort?\n");
							Console.WriteLine(" The correct answer is: A penguin in a blender\n");
							break;
						}
						else//Wrong answer
						{
							Console.WriteLine("\n Good try, but that's not it...\n");
							tries = tries - 1;
						}

						//Changes "tries" to singular form on last try 
						string triesS = "tries";
						if (tries == 0)
						{
							triesS = "try";
						}

						Console.WriteLine("\n You have " + (tries + 1) + " " + triesS + " left.");
						Thread.Sleep(1500);
						Console.Clear();
					}
					Console.WriteLine("\n\n");
					Thread.Sleep(2500);
				}



				else if (userInput.Equals("b"))//Complex Arithmetic mini game
				{

					Console.WriteLine(" You have selected B for Complex Arithmetic");
					int guesses = 3;
					string useless = "this is a useless string";
					while (useless == "this is a useless string")
					{
						guesses = guesses - 1;
						Console.WriteLine();
						Thread.Sleep(2000);
						Console.Clear();
						//Mini game start
						Console.WriteLine(" \t\tComplex Arithmetic");
						Console.WriteLine("====================================================\n");

						if (guesses == -1)
						{
							Console.WriteLine(" You are out of guesses...");
							Console.WriteLine(" The right answer was: 1");
							break;
						}

						Console.WriteLine(" YOU PICKED THE WRONG MINI GAME, NOW YOU WILL SUFFER!!!\n");
						Console.WriteLine(" Here's an equation to make you regret your decision: ");
						Console.WriteLine(" 4x + 12x = 16\n");
						Console.WriteLine(" What is the value of x?");
						Console.WriteLine(" Your answer:  ");
						Console.Write(" ");
						string arithmeticInput = Console.ReadLine();
						int arithmeticInputN = Convert.ToInt32(arithmeticInput); //Converts string to int

						if (arithmeticInputN == (1))
						{
							Console.WriteLine("\n CONGRATS, YOU ARE A GENIUS!!!\n");//Right answer
							Thread.Sleep(1500);
							break;
						}
						else
						{
							Console.WriteLine("\n Good try, but that's the wrong answer\n");//Wrong answer
							Console.WriteLine(" You have " + guesses + " guesses left.");

						}
						Thread.Sleep(1500);
					}
				}



				else if (userInput.Equals("c"))//Mad Libs Mini Game
				{
					Console.WriteLine(" You have selected C for Mad Libs!");
					Console.WriteLine();
					Thread.Sleep(2000);
					Console.Clear();
					//Mini game start
					Console.WriteLine(" \t\t    Mad Libs");
					Console.WriteLine("====================================================\n");
					Console.WriteLine(" Enter some words to begin!\n"); //User Input
					Console.WriteLine(" Name: ");
					Console.Write(" ");
					string name = Console.ReadLine();
					Console.WriteLine("\n Adjective: ");
					Console.Write(" ");
					string adjective = Console.ReadLine();
					Console.WriteLine("\n Adjective #2 : ");
					Console.Write(" ");
					string adjective2 = Console.ReadLine();
					Console.WriteLine("\n Time (Ex: 1:00) : ");
					Console.Write(" ");
					string time = Console.ReadLine();
					Console.Clear();

					Console.WriteLine(" Your Story...\n\n"); //Story
					Thread.Sleep(500);
					Console.WriteLine("\t Once upon a time, there was a girl named " + name + ".\n" +
									  " She lived in a " + adjective + " house with lots and lots of trees\n" +
									  " surrounding it.  One day, " + name + " was taking a walk in the\n" +
									  " nearby forest at " + time + " A.M., when something " + adjective2 +
									  " and\n brown ran past her.  She didn't know what it was, so she\n" +
									  " followed it.  She chased the creature for what seemed \n" +
									  " like forever.  She gave up.  The creature was nowhere  \n" +
									  " to be seen.  She kept walking, and found a " + adjective + " tree.   \n" +
									  " She examined the tree and found a piece of a " + adjective2 + " tooth stuck in \n" +
									  " one of the branches.  A few moments later, " + name + " heard a mighty \n" +
									  " howl from behind her, and she turned around quickly to see a \n" +
									  " tall man covered in hair.  He was very tall and he appeared  \n" +
									  " to have pointy ears.  The creature instantly ran into the forest. \n" +
									  " " + name + " has never seen it since her encounter.\n\n\n");
					Console.WriteLine(" Press enter to continue...");
					Console.ReadLine();
				}



				else if (userInput.Equals("d"))//Guessing Game
				{
					Console.WriteLine(" You have selected D for Guessing Game");
					Console.WriteLine();
					Thread.Sleep(2000);
					Console.Clear();

					Random rng = new Random();//Random number generator
					int rand = rng.Next(1, 11);
					int guessingInputN = 0;
					int guesses = 0;
					string bop = "boop";
					while (bop == "boop")
					{
						//Mini game start
						Console.WriteLine(" \t\t    Guessing Game");
						Console.WriteLine("====================================================\n");

						Console.WriteLine(" Pick a number between 1 and 10:");//User Input
						Console.Write(" ");

						string guessingInput = Console.ReadLine();
						guessingInputN = Convert.ToInt32(guessingInput);//Convert to int
						Console.WriteLine();

						if (guessingInputN > 10)
						{
							Console.WriteLine(" YOUR NUMBER IS HIGHER THAN 10, YOU BROKE THE RULES!!!!"); //Hihger than 10
						}
						else if (guessingInputN < 0)
						{
							Console.WriteLine(" YOUR NUMBER IS LOWER THAN 0, YOU BROKE THE RULES!!!!"); //Lower than 0
						}
						else if (rand > guessingInputN)
						{
							Console.WriteLine(" The number you picked is too low...");//Too low
						}
						else if (rand < guessingInputN)
						{
							Console.WriteLine(" The number you picked is too high...");//Too high
						}

						if (rand != guessingInputN)
						{
							Thread.Sleep(1000);
							Console.Clear();
						}
						else if (rand == guessingInputN)
						{

							guesses = guesses + 1;
							Console.WriteLine(" You are correct!!!\n"); //Right number
							Console.WriteLine(" You guessed the number in " + guesses + " guesses.");
							Console.WriteLine("\n\n");
							Thread.Sleep(2500);
							break;
						}


						guesses = guesses + 1;
						Console.WriteLine();
						Console.WriteLine(" Guesses: " + guesses);//Number of guesses
					}
				}

				else if (userInput.Equals("e"))//Exit Menu 
				{
					Console.Clear();
					Console.Write(" ");
					break;
				}

				else//Error Message
				{
					Console.WriteLine(" ERROR");
				}
				Console.Clear();
			}
		}
    }
}
