using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Adventure_10
{
    class Character
    {
		string name;
		int health;
		int row;
		int col;

		public Character(int row, int col, int health, string name)
		{
			this.row = row;
			this.col = col;
			this.health = health;
			this.name = name;
		}

		public void Move(string noun)
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

			else   //bad noun
			{
				Console.WriteLine(" A wild Snorlax is blocking the path...");
				Console.WriteLine(" ...if the limits of this program were a wild Snorlax");
				//press enter to continue
				Console.WriteLine(" Press [Enter] to continue");
				Console.ReadLine();
				Console.Clear();

			}
		}

		public int GetRow()
		{
			return row;
		}

		public int GetCol()
		{
			return col;
		}

		public void Print()
		{
			Console.WriteLine(" " + name + "\n ----------\nHP: " + health);
		}
	}
}
