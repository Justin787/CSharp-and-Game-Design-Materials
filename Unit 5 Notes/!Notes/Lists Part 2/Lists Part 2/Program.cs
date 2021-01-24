using System;
using System.Collections.Generic;//for lists
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Lists_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
			//declare and populate a list of strings
			List<string> myList = new List<string>();
			myList.Add("pogo stick");
			myList.Add("unicycle");
			myList.Add("asteroid with a saddle on it");
			myList.Add("catapult/trebuchet");
			myList.Add("jet shoes");

			//print the current information
			Console.WriteLine("Current number of items: " + myList.Count);
			foreach (string catapult in myList)
			{
				Console.WriteLine(catapult);
			}
			Console.WriteLine();



			/*
			//Clear() - Resets the entire list to empty and the count to 0
			Console.WriteLine(" Clearing list...");
			myList.Clear();


			//print the current information
			Console.WriteLine("Current number of items: " + myList.Count);
			foreach (string catapult in myList)
			{
				Console.WriteLine(catapult);
			}
			Console.WriteLine();
			*/



			//Remove()
			Console.WriteLine("Removing the Indecistive trebuchet...");
			myList.Remove("catapult/trebuchet");

			//print the current information
			Console.WriteLine("Current number of items: " + myList.Count);
			foreach (string catapult in myList)
			{
				Console.WriteLine(catapult);
			}
			Console.WriteLine();



			//RemoveAt()
			Console.WriteLine("Removing index 2...");
			myList.RemoveAt(2);

			//print the current information
			Console.WriteLine("Current number of items: " + myList.Count);
			foreach (string catapult in myList)
			{
				Console.WriteLine(catapult);
			}
			Console.WriteLine();



			//IndexOf()  (-1 if element isnt found)
			Console.WriteLine("Index of 'jet shoes': " + myList.IndexOf("jet shoes"));
			Console.WriteLine("Index of 'Tim': " + myList.IndexOf("Tim"));
			Console.WriteLine();



			//Insert()
			Console.WriteLine("Inserting 'ostrich' at index 1.");
			Console.WriteLine("Inserting 'Tim' at index 3.");
			Console.WriteLine("Inserting 'Segway' at index 0.");
			myList.Insert(1, "ostrich");
			myList.Insert(3, "Tim");
			myList.Insert(0, "Segway");

			//print the current information
			Console.WriteLine("Current number of items: " + myList.Count);
			foreach (string catapult in myList)
			{
				Console.WriteLine(catapult);
			}
			Console.WriteLine();
		}
    }
}
