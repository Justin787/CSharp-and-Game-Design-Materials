using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Sample_Population
{
    class Program
    {
        static void Main(string[] args)
        {
			Random rng = new Random();//random number
			int rand = 0;

			//United States Population
			Console.WriteLine(" How many people in the population from The United States (49.50% male, 50.50% female)?:");
			Console.Write(" ");

			//Variables
			string usInput = Console.ReadLine();//user input
			double usPop = Convert.ToDouble(usInput);//converts to double
			int usPopm = 0;
			int usPopf = 0;

			while (usPopm + usPopf < usPop)
			{
				rand = rng.Next(1, 10001);//number between 1 and 10000

				if (rand < 4950) //49.50% male
					usPopm++;
				else //50.50% female
					usPopf++;
			}

			Console.WriteLine("\n Results: ");
			Console.WriteLine(" " + usPopm + " male");
			Console.WriteLine(" " + usPopf + " female");
			Console.WriteLine();


			//Canadian Population
			Console.WriteLine(" How many people in the population from Canada (49.62% male, 50.38% female)?:");
			Console.Write(" ");

			//Variables
			string caInput = Console.ReadLine();//user input
			double caPop = Convert.ToDouble(caInput);//converts to double
			int caPopm = 0;
			int caPopf = 0;

			while (caPopm + caPopf < caPop)
			{
				rand = rng.Next(1, 10001);//number between 1 and 10000

				if (rand < 4962) //49.62% male
					caPopm++;
				else //50.38% female
					caPopf++;
			}

			Console.WriteLine("\n Results: ");
			Console.WriteLine(" " + caPopm + " male");
			Console.WriteLine(" " + caPopf + " female");
			Console.WriteLine();


			//Russian Population
			Console.WriteLine(" How many people in the population from Russia (46.47% male, 53.53% female)?:");
			Console.Write(" ");

			//Variables
			string ruInput = Console.ReadLine();//user input
			double ruPop = Convert.ToDouble(ruInput);//converts to double
			int ruPopm = 0;
			int ruPopf = 0;

			while (ruPopm + ruPopf < ruPop)
			{
				rand = rng.Next(1, 10001);//number between 1 and 10000

				if (rand < 4647) //46.47% male
					ruPopm++;
				else //53.53% female
					ruPopf++;
			}

			Console.WriteLine("\n Results: ");
			Console.WriteLine(" " + ruPopm + " male");
			Console.WriteLine(" " + ruPopf + " female");
			Console.WriteLine();
		}
    }
}
