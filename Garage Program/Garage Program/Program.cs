using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Garage_Program
{
    class Program
    {
		static Random rng = new Random();

		static void Main(string[] args)
		{
			//Create an array for 3 car objects
			Car[] garage = new Car[3];
			//Details for car objects
			garage[0] = new Car("Ford", "iDontKnowAnyCarsCar", "purple", 30000, 2004, 1);
			garage[1] = new Car("Dodge", "aTruck", "green", 500, 1999, 2);
			garage[2] = new Car("Apple", "doesntExistYetCar", "rose-gold", -500, 2038, 3);


			//Create an array for 5 color strings
			string[] colors = new string[5];
			//Add colors to array
			colors[0] = "pink";
			colors[1] = "brown";
			colors[2] = "yellow";
			colors[3] = "black";
			colors[4] = "rainbow";

			//Foreach loop
			foreach (Car car in garage)
			{
				Console.WriteLine();
				Console.WriteLine(" Before:");
				car.Print();
				car.Paint(RandomColor(colors));
				car.Drive(rng.Next(0, 501));
				Console.WriteLine(" After:");
				car.Print();
			}
		}

		//Random color
		static string RandomColor(string[] colors)
		{
			return colors[rng.Next(0, 5)];
		}
	}
}
