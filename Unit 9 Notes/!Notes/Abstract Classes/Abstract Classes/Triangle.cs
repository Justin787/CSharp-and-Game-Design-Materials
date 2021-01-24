using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes
{
	abstract class Triangle : TwoDShape
	{
		protected double side1, side2, side3;

		public Triangle(string name, double side1, double side2, double side3)
		{
			this.name = name;
			this.side1 = side1;
			this.side2 = side2;
			this.side3 = side3;
		}

		//must implement the abstract methods from TwoDShape
		public override void ChangeSize(double multiplier)
		{
			side1 *= multiplier;
			side2 *= multiplier;
			side3 *= multiplier;
		}

		//we'll implement Print() in the subclasses
	}
}
