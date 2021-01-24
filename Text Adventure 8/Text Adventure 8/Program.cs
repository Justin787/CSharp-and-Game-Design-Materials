using System;
using System.Threading;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Text_Adventure_8
{
    class Program
    {
        static void Main(string[] args)
        {

			string Gnome_ASCII = "                        ^                          \n" +
								 "                       / \\                        \n" +
								 "       The            /   \\                       \n" +
								 "     Forest...       /_____\\                      \n" +
								 "                    /VVVVVVv\\                     \n" +
								 "                   | (@) (@) }>                    \n" +
								 "                   \\  # < #  /                    \n" +
								 "                    \\__vv___/                     \n" +
								 "                      /     \\                     \n" +
								 "------------------------------------------------------\n";

			int StrengthV = 9;
			int EnduranceV = 4;
			int KnowledgeV = 5;
			int HP = 100;//Player health
			double MoneyV = 0.00;
			string Stats = " Strength:" + StrengthV +
						   "\n Endurance:" + EnduranceV +
						   "\n Knowledge:" + KnowledgeV +
						   "\n Health:" + HP +
						   "\n Money:" + MoneyV + "\n";

			//get info from user
			Console.WriteLine(Gnome_ASCII + "\n Hello, survivor! Before we begin, what is your name?");
			Console.Write(" ");
			string name = Console.ReadLine();

			Console.WriteLine("\n Also, who is your best friend?");
			Console.Write(" ");
			string Friend_Name = Console.ReadLine();

			Console.WriteLine("\n And lastly, what is your favorite body part?");
			Console.Write(" ");
			string Body_Part = Console.ReadLine();

			//print intro 
			Console.WriteLine("\n    A plane has crashed deep within a forest, you and your" +
								 "\n best friend, " + Friend_Name + ", are the only survivors.  " + Friend_Name + " has  " +
								 "\n been severly injured during the crash. Their " + Body_Part + " was" +
								 "\n completely ripped off and they're losing blood fast. You must" +
								  "\n wait for help while surviving the dangers of the forest...\n");

			Console.WriteLine(" Press [Enter] to continue.");
			Console.ReadLine();
			Console.Clear();

			//declare important variables
			int row = 0, col = 0; //keep track of current player location
								  //2-D arrays for locations, descriptions, and maps
			string[,] locations = { { "Plane Wreckage", "Pond" }, { "West Entrance", "East Entrance" } };
			string[,] descriptions = new string[2, 2];
			descriptions[0, 0] = " You are currently in the Plane Wreckage.  You can't help but " +
								 "\n notice a BACKPACK lying on the ground.";
			descriptions[0, 1] = " You're at the pond.  You see something floating near your feet." +
								 "\n It seems to be...  a RUBBER DUCK?";
			descriptions[1, 0] = " You are at the West Entrace to the forest, there's an AXE for some unknown reason";
			descriptions[1, 1] = " You are at the East Entrance to the forest, here you find PAUL BREMER standing in silence.";
			string[,] maps = new string[2, 2];
			maps[0, 0] = "_____\n|x|_|\n|_|_|";
			maps[0, 1] = "_____\n|_|x|\n|_|_|";
			maps[1, 0] = "_____\n|_|_|\n|x|_|";
			maps[1, 1] = "_____\n|_|_|\n|_|x|";

			string command = "";//keep track of user input

			//loop while user hasnt entered quit
			while (command != "quit")
			{
				//print current info
				Console.WriteLine(" " + name + "\n ----------\n" + Stats);
				Console.WriteLine(locations[row, col]);
				Console.WriteLine(maps[row, col] + "\n");
				Console.WriteLine(descriptions[row, col] + "\n"); //current location details

				//get command from user
				Console.Write(" What will you do?: ");
				command = Console.ReadLine().ToLower();
				Console.WriteLine();

				//parse and deal with command
				//check for a space
				if (command.Contains(" "))
				{
					//if it has one break it into verb and noun
					string verb = command.Substring(0, command.IndexOf(" "));
					string noun = command.Substring(command.IndexOf(" ") + 1);

					//2 word commands
					//look/check/examine
					if (verb == "look" || verb == "check" || verb == "examine")
					{
						//backpack in wreckage
						if ((noun == "back pack" || noun == "backpack") && row == 0 && col == 0)
						{
							Console.WriteLine(" *Intense thinking*");
							Console.WriteLine(" *Slaps roof of backpack*");
							Console.WriteLine(" This bad boy can fit so much spaghetti in it.\n");
							Console.WriteLine(" Press [Enter] to continue.");
							Console.ReadLine();
							Console.Clear();
						}
						//Rubber duck at lake
						else if ((noun == "rubber duck" || noun == "rubberduck") && row == 0 && col == 1)
						{
							Console.WriteLine(" Roses are red, your soul is black,");
							Console.WriteLine(" congratulations you found a duck, quack quack.");

							Console.WriteLine(" Press [Enter] to continue.");
							Console.ReadLine();
							Console.Clear();
						}
						//tin of hair gel in room 3
						else if (noun == "axe" && row == 1 && col == 0)
						{
							Console.WriteLine(" B I G  C H O P");
							Console.WriteLine(" ...another B I G  C H O P");

							Console.WriteLine(" Press [Enter] to continue.");
							Console.ReadLine();
							Console.Clear();
						}
						//paul bremer at east entrance
						else if ((noun == "paul bremer" || noun == "paulbremer") && row == 1 && col == 1)
						{
							Console.WriteLine(" Ladies and gentlemen...");
							Console.WriteLine(" we got him.\n");

							Console.WriteLine(" Press [Enter] to continue.");
							Console.ReadLine();
							Console.Clear();
						}
						else //bad noun
						{
							Console.WriteLine(" Good job you won!!!!");
							Console.WriteLine(" Just kidding, you're just bad at text adventures.");
							Console.WriteLine(" Press [Enter] to continue.");
							Console.ReadLine();
							Console.Clear();
						}
					}
					//go
					else if (verb == "go")
					{
						if (noun == "north" || noun == "up")
						{
							if (row > 0) //check for legal move
							{
								row--;
								Console.WriteLine(" Press [Enter] to continue.");
								Console.ReadLine();
								Console.Clear();
							}
							else //tried to move off grid
							{
								Console.WriteLine(" You cannot travel in that direction, don't ask why because I don't know.");
								//press enter to continue
								Console.WriteLine("Press [ENTER] to continue.");
								Console.ReadLine();
								Console.Clear();
							}
						}

						else if (noun == "south" || noun == "down")
						{
							if (row < 1) //check for legal move
							{
								row++;
								Console.WriteLine(" Press [Enter] to continue.");
								Console.ReadLine();
								Console.Clear();
							}
							else //tried to move off grid
							{
								Console.WriteLine(" You cannot travel in that direction, don't ask why because I don't know.");
								//press enter to continue
								Console.WriteLine(" Press [Enter] to continue.");
								Console.ReadLine();
								Console.Clear();
							}
						}

						else if (noun == "east" || noun == "right")
						{
							if (col < 1) //check for legal move
							{
								col++;
								Console.WriteLine(" Press [Enter] to continue.");
								Console.ReadLine();
								Console.Clear();
							}
							else //tried to move off grid
							{
								Console.WriteLine(" You cannot travel in that direction, don't ask why because I don't know.");
								//press enter to continue
								Console.WriteLine(" Press [Enter] to continue.");
								Console.ReadLine();
								Console.Clear();
							}

						}

						else if (noun == "west" || noun == "left")
						{
							if (col > 0) //check for legal move
							{
								col--;
								Console.WriteLine(" Press [Enter] to continue.");
								Console.ReadLine();
								Console.Clear();
							}
							else //tried to move off grid
							{
								Console.WriteLine(" You cannot travel in that direction, don't ask why because I don't know.");
								//press enter to continue
								Console.WriteLine(" Press [Enter] to continue.");
								Console.ReadLine();
								Console.Clear();
							}
						}
						else //bad noun
						{
							Console.WriteLine(" A wild Snorlax is blocking the path...");
							Console.WriteLine(" ...if the limits of this program were a wild Snorlax");
							//press enter to continue
							Console.WriteLine(" Press [Enter] to continue");
							Console.ReadLine();
							Console.Clear();
						}
					}
					else //bad verb
					{
						Console.WriteLine(" A wild Snorlax is blocking the path...");
						Console.WriteLine(" ...if the limits of this program were a wild Snorlax");
						//press enter to continue
						Console.WriteLine(" Press [Enter] to continue");
						Console.ReadLine();
						Console.Clear();

					}


				}

				//help
				else if (command == "help")
				{
					Console.Clear();

					Console.WriteLine(" Valid Commands:\n");
					Console.WriteLine(" GO [North, South, East, West]");
					Console.WriteLine(" -Move in any direction, but not off the grid\n");
					Console.WriteLine(" LOOK, CHECK, or EXAMINE [Item]");
					Console.WriteLine(" -Get information about a given item\n");
					Console.WriteLine(" QUIT ");
					Console.WriteLine(" -Exit game\n");

					//press enter to continue
					Console.WriteLine(" Press [Enter] to continue.");
					Console.ReadLine();
					Console.Clear();
				}

				//if no space deal with 1 word commands
				else if (command == "quit")//quit command
				{
					Console.WriteLine(" You decide that you're too cool for text adventures.");
					Console.WriteLine(" ...You can never be too cool for text adventures.  Have a nice life, nerd.");

					//press enter to continue
					Console.WriteLine(" Press [Enter] to continue.");
					Console.ReadLine();
					Console.Clear();

					break;//break main loop of program(quit)
				}

				else //bad 1 word command
				{
					Console.WriteLine(" The number you are trying to reach is currently unavailable. ");
					Console.WriteLine(" Leave a message after the BEEP...");
					Thread.Sleep(3000);
					Console.WriteLine(" BEEP!!!");

					//press enter to continue
					Console.WriteLine(" Press [Enter] to continue.");
					Console.ReadLine();
					Console.Clear();
				}


			}
		}
    }
}
