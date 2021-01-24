using System;
using System.Threading;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
			Random rng = new Random();//random number
			string bob = "bob";
			while (bob == "bob")
			{


				//Menu
				Console.WriteLine("\tPassword Generator Menu\n");
				Console.WriteLine(" Which character subset would you like?:");
				Console.WriteLine("-------------------------------------------");
				Console.WriteLine(" A. Lowercase letters");
				Console.WriteLine(" B. Uppercase and lowercase letters");
				Console.WriteLine(" C. Uppercase letters, lowercase letters, and numbers");
				Console.WriteLine(" D. Uppercase letters, lowercase letters, numbers, and punctuation");
				Console.WriteLine(" E. Quit Program\n");

				Console.Write(" ");
				string userInput = Console.ReadLine().ToLower();//user menu option

				if (userInput.Equals("e"))//exits program
				{
					Console.WriteLine("\n Quiting program...");
					break;
				}


				if (userInput != "a" && userInput != "b" && userInput != "c" && userInput != "d" && userInput != "e")//Error if input isnt an option
				{
					Console.WriteLine("\n ERROR\n");
					break;
				}



				//Password length
				Console.WriteLine("\n How long would you like your password to be (5 or more characters)?");
				Console.Write(" ");
				string ooo = Console.ReadLine();//how many characters in password
				int userInputN = Convert.ToInt32(ooo);
				string password = "";


				if (userInputN < 5) //number of characters less than 5, creates an error
				{
					Console.WriteLine("\n ERROR");
					break;
				}


				else if (userInput.Equals("a")) //Lowercase letters
				{
					for (int i = 0; i < userInputN; i++) //loops as many times as user says
					{
						int rand = rng.Next(97, 123); //random number between 97 and 123 (lowercase a-z on ascii table)

						char myChar = (char)rand;
						password += myChar; //adds random letter to password
					}
				}


				else if (userInput.Equals("b")) //Uppercase and lowercase letters
				{
					for (int i = 0; i < userInputN; i++)
					{
						int rand = rng.Next(65, 123);//random number

						while (rand > 90 && rand < 97) //picks new number if current number is a bad one
							rand = rng.Next(65, 123);

						char myChar = (char)rand;
						password += myChar; //adds random letter to password
					}
				}


				else if (userInput.Equals("c")) //Uppercase letters, lowercase letters, and numbers
				{
					for (int i = 0; i < userInputN; i++)
					{
						int rand = rng.Next(48, 123); //random number

						while ((rand > 57 && rand < 65) || (rand > 90 && rand < 97)) //ranges of bad numbers
							rand = rng.Next(48, 123);

						char myChar = (char)rand;
						password += myChar; //adds random letter to password
					}
				}


				else if (userInput.Equals("d")) //Uppercase, lowercase, numbers, and punctuation
				{
					for (int i = 0; i < userInputN; i++)
					{
						int rand = rng.Next(32, 126);

						char myChar = (char)rand;
						password += myChar; //adds random letter to password
					}
				}

				//Shows what password is
				if (userInputN >= 5) //if number of characters is higher than or equal to 5, display password
					Console.WriteLine("\n Your password is: " + password + "\n\n");



				//Option to create new password
				Console.WriteLine("\n Would you like to create another password?"); //option to quit or continue loop
				Console.Write(" ");
				string continueInput = Console.ReadLine().ToLower();


				if (continueInput.Equals("no")) //if no, quit loop
				{
					Console.WriteLine("\n Exiting Program...\n");
					break;
				}

				else if (continueInput.Equals("yes")) //if yes, continue loop
					Console.Clear();

				else
				{
					Console.WriteLine("\n I'm gonna take that as a yes..."); // error, restart anyways
					Thread.Sleep(1000);
					Console.Clear();
				}
			}
		}
    }
}
