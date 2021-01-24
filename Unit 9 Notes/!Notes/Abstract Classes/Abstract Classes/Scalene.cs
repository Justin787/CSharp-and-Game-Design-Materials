using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes { 
	class Scalene : Triangle
	{
		public Scalene(string name, double side1, double side2, double side3) : base(name, side1, side2, side3)
		{
			//dont do anything here let the base constructor handle it
		}

		//implement (override) the abstract Print() method from TwoDShape
		public override void Print()
		{
			Console.WriteLine(" Scalene Triangle: " + name + "\n Side Lengths: " + side1 + ", " + side2 + ", " + side3);
		}

	}
}
