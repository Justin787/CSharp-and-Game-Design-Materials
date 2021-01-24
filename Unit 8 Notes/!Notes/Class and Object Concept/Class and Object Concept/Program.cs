using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Class_and_Object_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
			//make a car
			Car Kia = new Car();

			//print its details
			Console.WriteLine("\nJames' Sporty Kia:");
			Console.WriteLine("Mileage: " + Kia.GetMileage());
			Console.WriteLine("Color: " + Kia.GetColor());
			Console.WriteLine("Has 4 Doors: " + Kia.GetDoors());

			//drive it
			Kia.Drive(2);

			//paint it
			Kia.Paint("red");

			//print its new details
			Console.WriteLine("\nJames' Sporty Kia (new values):");
			Console.WriteLine("Mileage: " + Kia.GetMileage());
			Console.WriteLine("Color: " + Kia.GetColor());
			Console.WriteLine("Has 4 Doors: " + Kia.GetDoors());
		}
    }
}
