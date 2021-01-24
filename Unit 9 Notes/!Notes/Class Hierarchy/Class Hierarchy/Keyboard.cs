using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Hierarchy
{
	class Keyboard : Computer_Part
	{
		bool isMechanical;

		//Constructor has to call the base constructor in its header
		public Keyboard(string name, int wattage, double value, bool isMechanical) :
			base(name, wattage, value) //"base" represents the ComputerPart constructor
		{
			this.isMechanical = isMechanical;
		}

		public void Type(int wpm)
		{
			if (isMechanical)
			{
				Console.WriteLine(" The mechanical keyboard boosts the speed!");
				wpm += 10;
			}
			Console.WriteLine(" Typed " + wpm + " per minute.");
		}
	}
}
