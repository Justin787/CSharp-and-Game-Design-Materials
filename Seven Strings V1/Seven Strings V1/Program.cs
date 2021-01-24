using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Seven_Strings_V1
{
    class Program
    {
        static void Main(string[] args)
        {
			//variables
			string[] arrayyy = new string[7]; //array for user's strings
			string longest = ""; //longest string
			string shortest =
				"                                    "; //shortest string

			Console.WriteLine(" Enter all of the seven continents:");
			//1st loop
			for (int i = 0; i < 7; i++) //gets strings from user
			{
				Console.Write(" ");
				arrayyy[i] = Console.ReadLine();
			}

			Console.WriteLine("\n You entered:");
			//2nd loop
			for (int i = 0; i < 7; i++) //shows the user their strings
			{
				Console.WriteLine(" " + arrayyy[i]);
			}

			//3rd loop
			for (int i = 0; i < 7; i++) //finds shortest and longest strings
			{
				if (arrayyy[i].Length >= longest.Length)//finds longest string
				{
					longest = arrayyy[i];
				}

				else if (arrayyy[i].Length < shortest.Length)//finds shortest string
				{
					shortest = arrayyy[i];
				}
			}

			Console.WriteLine("\n Longest string: " + longest); //longest string 
			Console.WriteLine(" Shortest string: " + shortest); //shortest string 

		}
	}
}
