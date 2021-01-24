using System;
using System.Threading;//so we can use thread methods
using System.Collections.Generic; //for lists
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
			//declare and fill a list of strings
			List<string> myList = new List<string>();
			myList.Add("Love");
			myList.Add("is a");
			myList.Add("many-splendored");
			myList.Add("thing.");

			//change spot 2
			myList[2] = "complicated";

			//use a foreach loop to write them out
			foreach (string kitten in myList)
			{
				Console.WriteLine(kitten);
			}
		}
    }
}
