using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("While loop");
			//Use a while loop to count to 10
			int bop = 0;
			while (bop < 10)
			{
				bop = bop + 1;
				Console.WriteLine(bop);
			}
			Console.WriteLine("Press enter to continue");
			Console.ReadLine();


			Console.WriteLine("for loop");
			//for{variable,condition,increment)
			//FOR LOOOOOOOPS (Specifically made for counting)
			//use a for loop to count to 10
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine(i);
			}


			//nested loops to list the SMB levels  NOTE: THESE ARE INSANELY USEFUL
			for (int worlds = 1; worlds <= 8; worlds++) //worlds go from 1 to 8
			{
				for (int level = 1; level <= 4; level++)//levels go from 1 to 4
				{
					Console.WriteLine("World " + worlds + "-" + level);
				}
			}

			Console.ReadLine();
			Console.Clear();
			//Write a for loop that counts down from 100 to 0 and prints every number divisible by 5 (Count down by 5's)
			for (int num1 = 100; num1 > 0; num1--)
			{
				if (num1 % 5 == 0)
				{
					Console.WriteLine(num1);
				}


			}
		}
    }
}
