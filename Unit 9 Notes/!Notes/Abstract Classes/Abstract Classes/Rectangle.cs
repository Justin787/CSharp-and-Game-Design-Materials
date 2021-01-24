using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes
{
	class Rectangle : TwoDShape
	{
		double length, width;

		public Rectangle(string name, double length, double width)
		{
			this.name = name;
			this.length = length;
			this.width = width;
		}

		//must implement the abstract methods from TwoDShape
		public override void ChangeSize(double multiplier)
		{
			width *= multiplier;
			length *= multiplier;
		}

		public override void Print()
		{
			Console.WriteLine(" Rectangle: " + name + "\n Dimensions: " + length + " x " + width);
		}
	}
}
