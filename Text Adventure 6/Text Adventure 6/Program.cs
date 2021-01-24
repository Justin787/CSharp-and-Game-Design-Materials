using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Text_Adventure_6
{
    class Program
    {
        static void Main(string[] args)
        {
			//Variables
			int StrengthV = 9;     //#1
			int EnduranceV = 4;    //#2
			int KnowledgeV = 5;    //#3
			int HP = 100;       //#4
			double MoneyV = 0.00; //#5


			//Gnome ASCII Art
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

			Console.WriteLine(Gnome_ASCII);




			//User Interaction
			Console.WriteLine("Hello, survivor! Before we begin, what is your name?");
			string User_Name = Console.ReadLine();

			Console.WriteLine();

			Console.WriteLine("Also, who is your best friend?");
			string Friend_Name = Console.ReadLine();

			Console.WriteLine();

			Console.WriteLine("And lastly, what is your favorite body part?");
			string Body_Part = Console.ReadLine();

			Console.WriteLine();







			//Strings 
			string Stats = " Strength:" + StrengthV +
						   "\n Endurance:" + EnduranceV +
						   "\n Knowledge:" + KnowledgeV +
						   "\n Senses:" + HP +
						   "\n Money:" + MoneyV + "\n";

			string Paragraph_1 = "    A plane has crashed deep within a forest, you and your" +
								 "\n best friend, " + Friend_Name + ", are the only survivors.  " + Friend_Name + " has  " +
								 "\n been severly injured during the crash. Their " + Body_Part + " was" +
								 "\n completely ripped off and they're losing blood fast. You must" +
								  "\n wait for help while surviving the dangers of the forest...\n";

			string beginning_choices = "   Before you leave to search for food, you decide to search" +
									   "\n for something useful.  In the wreckage, you find: " +
									   "\n an AXE, a BACKPACK, and a RUBBER DUCK... ";

			string Paragraph_2 = "   In a panic, you quickly use your shirt to slow the bleeding" +
								 "\n of your friend's wound. You leave to search for food or water." +
								 "\n Heading north, you come to a small river, as you kneel to take a" +
								 "\n sip, you suddenly get an unsettling feeling, like you're being watched." +
								 "\n You look around for a few moments, but you see nothing except the trees." +
								 "\n As you make your way back to the crash site, you see the sun" +
								 "\n setting along the horizon.\n";

			string Paragraph_3 = "    You find " + Friend_Name + " unconscious in the grass, blood surrounded them." +
								 "\n Their shirt was missing. Three scratch marks could be seen across" +
								 "\n their chest. You check their pulse...   Nothing...     " + Friend_Name + "'s dead." +
								 "\n You sit alone as the darkness consumes you. Voices can be heard" +
								 "\n coming from the forest. After investigating, you find nothing." +
								 "\n You decide to try and get some sleep...\n";

			//User choice right here

			//Option one
			string Paragraph_4 = "    You wake up to a sharp pain across your " + Body_Part + ". You had been scratched." +
								 "\n After standing up, you hear small, fast, footsteps. The darkness" +
								 "\n made it nearly impossible to see. You feel another scratch on your left leg!" +
								 "\n Where was it coming from? And then another one across your neck!" +
								 "\n You're losing blood fast! without any medical equipment, you fall" +
								 "\n to the ground...\n";

			string You_Died_ASCII = " -    -   ---   -    -        ----  ----  ----  ----     " +
								  "\n  -  -   -   -  -    -        -   -  --   --    -   -    " +
								  "\n   --    -   -  -    -        -   -  --   --    -   -    " +
								  "\n   --     ---    ----         ----  ----  ----  ----     \n";

			//Option two
			string Paragraph_5 = "    You wake up to a noise coming from outside.  It sounds scary so you use common" +
								"\n sense and decide it might be a bad idea to check it out.  You go back to sleep..." +
								"\n\n  In the morning you investigate.  You leave the wreckage, and " + Friend_Name + "'s" +
								"\n body is gone.  You look down and see an arrow drawn in blood.  You follow it in" +
								"\n search of your friend's body.  You follow the path until the arrows stop.  There's" +
								"\n something written with the blood..." +
								"\n\n ''THERE'S NO ESCAPE'' " +
								"\n\n You turn to go back to the wreckage, but the trail was gone. It couldn't" +
								"\n have disappeared, could it?  You're unsure of where you came from, and night" +
								"\n is approaching quickly.  You started to run, faster than you have ever ran" +
								"\n before.  Out of nowhere, everything stops.  You wake up with blood all over your cheek." +
								"\n It seems that you hit a tree.  You can't move, the only thing you can do is lay helplessly" +
								"\n in the grass.  Your eyes close slowly... \n";




			string command = " ";
			while (command != "quit")          //Loop
			{

				Console.Clear();
				Console.WriteLine(Gnome_ASCII);
				Console.WriteLine(" " + User_Name + "\n");

				//Everything Printed
				Console.WriteLine(Stats);
				Console.WriteLine(Paragraph_1);
				Console.WriteLine(beginning_choices);
				Console.WriteLine("\n Enter a command:");
				Console.Write(" ");
				command = Console.ReadLine().ToLower();
				Console.WriteLine();

				if (command.Contains(" "))
				{
					string verb = command.Substring(0, command.IndexOf(" "));
					string noun = command.Substring(command.IndexOf(" ") + 1);

					if (verb == "look" || verb == "check" || verb == "examine")
					{
						if (noun == "axe")
							Console.WriteLine(" CLONK CLONK!");
						else if (noun == "backpack" || noun == "back pack")
							Console.WriteLine(" *slaps roof of backpack* \n This bad boy can fit so much spaghetti in it");
						else if (noun == "rubber duck" || noun == "rubberduck")
							Console.WriteLine(" *you make duck noises for 20 minutes*");
						else
							Console.WriteLine(" You cannot do that...");
					}

					else
						Console.WriteLine(" You cannot do that...");
				}
				else if (command == "quit")
					Console.WriteLine(" You gave up...");

				else
					Console.WriteLine(" I don't understand that command.");

				//Console.WriteLine(Paragraph_2);
				//Console.WriteLine(Paragraph_3);
				//Console.WriteLine(" Will you sleep in the wreckage or out in the open?\n");
				//Console.Write(" ");
				//string userchoice1 = Console.ReadLine();
				//Console.WriteLine();

				/*userchoice1 = userchoice1.ToLower();
				if (userchoice1 == "out in the open")
				{
					Console.WriteLine(Paragraph_4);
					Console.WriteLine(You_Died_ASCII);
				}
				else if (userchoice1 == "in the wreckage")
				{
					Console.WriteLine(Paragraph_5);
					Console.WriteLine(You_Died_ASCII);
				}
				else
				{
					Console.WriteLine(" ERROR");
				}
				Console.WriteLine();
               */

				Console.WriteLine("\n [Press Enter]");
				Console.ReadLine();
			}
		}
    }
}
