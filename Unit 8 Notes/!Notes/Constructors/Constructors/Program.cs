using System;
using System.Collections.Generic;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
			//create a carnivore object
			Carnivore lion = new Carnivore(32, false, "lion");

			//declare a list of carnivores
			List<Carnivore> scaryanimals = new List<Carnivore>();

			//add carnivores to list
			scaryanimals.Add(lion);
			scaryanimals.Add(new Carnivore(62, true, "T-Rex"));
			scaryanimals.Add(new Carnivore(42, false, "bear"));
			scaryanimals.Add(new Carnivore(0, true, "eagle"));

			//use loop to print info
			foreach (Carnivore scarything in scaryanimals)
			{
				Console.WriteLine("Name: " + scarything.GetSpecies());
				Console.WriteLine("# of teeth: " + scarything.GetTeeth());
				Console.WriteLine("Has Talons: " + scarything.GetTalons());
				Console.WriteLine();
			}

			//have them kil and eat
			scaryanimals[0].Kill("Daniel");
			scaryanimals[1].Eat(100);
			scaryanimals[2].Kill("Gopher");
			scaryanimals[3].Eat(2);
		}
    }
}
