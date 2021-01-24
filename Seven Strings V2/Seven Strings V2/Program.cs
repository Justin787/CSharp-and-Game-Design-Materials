using System;
using System.Threading;
using System.Collections.Generic;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Seven_Strings_V2
{
    class Program
    {
        static void Main(string[] args)
        {
			//variables
			string[] arrayyy = new string[7]; //array for user's strings
			string longest = ""; //longest string
			string shortest = ""; //shortest string
			List<string> myList = new List<string>();

			Console.WriteLine(" Enter all of the seven continents (Wrong answers only):");
			for (int i = 0; i < 7; i++) //gets strings from user
			{
				Console.Write(" ");
				myList.Add(Console.ReadLine());

				if (i == 0)
					shortest = myList[i];
			}



			Console.WriteLine("\n You entered:");
			foreach (string sTrInG in myList)
			{
				Console.Write(" ");
				Console.WriteLine(sTrInG);
			}



			for (int i = 0; i < 7; i++) //finds shortest and longest strings
			{
				if (myList[i].Length >= longest.Length)//finds longest string
				{
					longest = myList[i];
				}

				else if (myList[i].Length < shortest.Length)//finds shortest string
				{
					shortest = myList[i];
				}
			}



			Console.WriteLine("\n Longest string: " + longest); //longest string 
			Console.WriteLine(" Shortest string: " + shortest); //shortest string 

			Console.WriteLine("\n After removing the longest and shortest 'continents', the new list is:");
			int shortestInt = myList.IndexOf(shortest);
			int longestInt = myList.IndexOf(longest);
			myList.RemoveAt(shortestInt);
			myList.RemoveAt(longestInt);

			foreach (string sTrInG in myList)
			{
				Console.Write(" ");
				Console.WriteLine(sTrInG);
			}
			Console.WriteLine();
		}
    }
}
