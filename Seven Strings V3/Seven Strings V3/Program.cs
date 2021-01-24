using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Seven_Strings_V3
{
    class Program
    {
		//Array of seven strings
		static string[] stringArray = new string[7];

		static void Main(string[] args)
		{
			Console.WriteLine(" Enter all of the seven continents:");

			PopulatingArray();

			Console.WriteLine(" You entered:");
			PrintArray();
		}

		static void PopulatingArray()
		{
			if (stringArray.Length < 7)
			{
				Console.Write(" ");
				stringArray[stringArray.Length + 1] = Console.ReadLine();
				Console.WriteLine();
				PopulatingArray();
			}
		}

		static void PrintArray()
		{
			for (int i = 0; i < 7; i++) //shows the user their strings
			{
				Console.WriteLine(" " + stringArray[i]);
			}
		}
	}
}
