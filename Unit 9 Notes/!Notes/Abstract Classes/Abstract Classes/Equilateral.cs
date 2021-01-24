using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes
{
	class Equilateral : Triangle
	{
		public Equilateral(string name, double side1) : base(name, side1, side1, side1)
		{
			//dont do anything here let the base constructor handle it
		}

		//implement (override) the abstract Print() method from TwoDShape
		public override void Print()
		{
			Console.WriteLine(" Equilateral Triangle: " + name + "\n Side Lengths: " + side1 + ", " + side2 + ", " + side3);
		}
	}
}
