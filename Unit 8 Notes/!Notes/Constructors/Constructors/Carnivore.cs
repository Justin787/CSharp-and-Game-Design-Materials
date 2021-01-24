using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Carnivore
    {
		/*
		 * Class diagram for Carnivore:
		 * Properties
		 * # of teeth (int)
		 * does it have talons (bool)
		 * species (string)
		 * 
		 * Methods:
		 * Eat() - takes an int returns void
		 * Kill() - takes a string returns void
		 */

		//Class variables
		int teeth;
		bool hasTalons;
		string species;

		//default constructor (empty)
		public Carnivore()
		{
			//this runs when a carnivore is created
		}

		//constructor with parameters
		public Carnivore(int teeth, bool talons, string species)
		{
			this.teeth = teeth; //'this' refers to the object the method was called on
			hasTalons = talons;
			this.species = species;
		}

		//Eat()
		public void Eat(int pounds)
		{
			//print a message about eatin' stuff
			Console.WriteLine("The " + species + " eats " + pounds + " pounds of meat");
		}

		//Kill()
		public void Kill(string prey)
		{
			Console.WriteLine("The " + species + " kills a " + prey);
		}

		//getter methods
		public int GetTeeth() { return teeth; }
		public bool GetTalons() { return hasTalons; }
		public string GetSpecies() { return species; }
	}
}
