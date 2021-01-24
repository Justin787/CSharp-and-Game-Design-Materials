using System;
using System.Collections.Generic; //for lists
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Playlist_Program
{
    class Program
    {
        static void Main(string[] args)
        {
			List<string> playlist = new List<string>();
			//playlist.Add("b");
			while (0 == 0)
			{
				//Playlist
				int i = 0;
				Console.WriteLine(" Current Playlist:");
				foreach (string song in playlist)
				{
					i++;
					Console.WriteLine(" " + i + ") " + song);
				}
				if (playlist.Count == 0)
					Console.WriteLine(" You have no existing songs in this playlist.");


				//Menu
				Console.WriteLine("\n Menu:");
				Console.WriteLine(" A) Add a song\t\tB) Insert a song\t\tC) Remove a title ");
				Console.WriteLine(" D) Remove a spot\tE) Reverse the list\t\tF) Clear all");
				Console.WriteLine("\t\t\tQ) Quit program");
				Console.WriteLine();

				//User Input
				Console.Write(" Your choice: ");
				string menuInput = Console.ReadLine().ToLower();

				//Add a song
				if (menuInput == "a" || menuInput == "add a song")
				{
					Console.Write(" Title of song to add: ");
					playlist.Add(Console.ReadLine());
				}

				//Insert a song
				else if (menuInput == "b" || menuInput == "insert a song")
				{
					Console.Write(" Title of song to add: ");
					string song = Console.ReadLine();

					Console.Write(" Place to insert: ");
					string place = Console.ReadLine();
					int placeI = Convert.ToInt32(place);

					if (placeI <= playlist.Count && placeI > 0)
					{
						playlist.Insert(placeI - 1, song);
					}

					else
					{
						Console.WriteLine(" ERROR");
						Console.WriteLine(" Press [Enter] to continue");
						Console.ReadLine();
					}
				}

				//Remove a title
				else if (menuInput == "c" || menuInput == "remove a title")
				{
					Console.Write(" Title to remove: ");
					playlist.Remove(Console.ReadLine());
				}

				//Remove a spot
				else if (menuInput == "d" || menuInput == "remove a spot")
				{
					Console.Write(" Spot to remove: ");
					int removeAt = Convert.ToInt32(Console.ReadLine()) - 1;

					if (removeAt <= playlist.Count && removeAt >= 0) //if position exists, remove it
					{
						playlist.RemoveAt(removeAt);
					}

					else //Position does not exist
					{
						Console.WriteLine(" ERROR");
						Console.WriteLine(" Press [Enter] to continue");
						Console.ReadLine();
					}
				}

				//Reverse the list
				else if (menuInput == "e" || menuInput == "reverse the list")
				{
					playlist.Reverse();
				}

				//Clear all
				else if (menuInput == "f" || menuInput == "clear all")
				{
					playlist.Clear();
				}

				//Quit program
				else if (menuInput == "q" || menuInput == "quit" || menuInput == "quit program")
				{
					Console.Clear();
					break;
				}

				//Invalid input
				else
				{
					Console.WriteLine(" ERROR");
					Console.WriteLine(" Press [Enter] to continue");
					Console.ReadLine();
				}

				Console.Clear();
			}
		}
    }
}
