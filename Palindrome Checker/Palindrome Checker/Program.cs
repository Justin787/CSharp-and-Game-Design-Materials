using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Palindrome_Checker
{
    class Program
    {
		static void Main(string[] args)
		{
			while (0 == 0)
			{
				Console.WriteLine(" Enter a word or phrase (Use command 'quit' to end program)");
				Console.Write(" ");

				//getting info from user
				string userInput = Console.ReadLine();

				if (userInput.ToLower().Equals("quit"))
				{
					Console.Clear();
					break;
				}


				if (PalindromeChecker(userInput))
				{
					Console.WriteLine("\n '" + userInput + "' is a palindrome");
				}

				else
				{
					Console.WriteLine("\n '" + userInput + "' is not a palindrome");
				}

				Console.WriteLine("\n Press [Enter] to continue");
				Console.ReadLine();
				Console.Clear();
			}
		}

		static bool PalindromeChecker(string userInput)
		{
			string userInputE = userInput;//copy input

			userInputE = HelperMethod(userInputE);//helper method
			return RecursionMethod(userInputE);
		}

		static string HelperMethod(string userInputE)
		{
			userInputE = userInputE.ToLower();// makes a letters lowercase

			if (userInputE.Contains(" "))//removes spaces
			{
				userInputE = userInputE.Replace(" ", "");
			}

			return userInputE;
		}


		static bool RecursionMethod(string userInput)
		{
			//base case if string is 0 or 1 chars long
			if (userInput.Length == 0 || userInput.Length == 1)
			{
				return true;
			}

			string lastChar = userInput.Substring(userInput.Length - 1, 1);//last char
			string firstChar = userInput.Substring(0, 1);//first char
														 //compare first and last letters

			if (userInput.Length > 1)
			{

				if (firstChar.Equals(lastChar))
				{
					userInput = userInput.Substring(1, userInput.Length - 2);
					return RecursionMethod(userInput);
				}

				else
				{
					return false;//isnt a palindrome
				}
			}

			//repeat
			else
			{
				return RecursionMethod(userInput);
			}
		}
	}
}
