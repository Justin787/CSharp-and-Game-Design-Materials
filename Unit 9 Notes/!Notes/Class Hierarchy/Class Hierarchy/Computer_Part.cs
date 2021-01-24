using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Hierarchy
{
    class Computer_Part
    {
		/*
		 * Class diagram:
		 * Properties:
		 * String name
		 * int wattage 
		 * double value
		 * 
		 * Methods:
		 * Print()
		 * Depreciate()
		 */

		string name;
		int wattage;
		double value;

		public Computer_Part(string name, int wattage, double value)
		{
			this.name = name;
			this.wattage = wattage;
			this.value = value;
		}

		public void Print()
		{
			Console.WriteLine(" " + name + "(worth $" + value + ") " + " draws " + wattage + " watts.");

		}

		public void Depreciate(double percent)
		{
			Console.WriteLine(" Value of " + name + " depreciated by " + percent + "%.");
			percent /= 100;
			value *= (1 - percent); //reduce value by given percentage
			Console.WriteLine("New Value: " + value);
		}
	}
}
