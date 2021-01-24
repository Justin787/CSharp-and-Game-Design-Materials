using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes
{
    class Circle : TwoDShape
    {
		double radius;

		public Circle(string name, double radius)
		{
			this.name = name;
			this.radius = radius;
		}

		//must implement the abstract methods from TwoDShape
		public override void ChangeSize(double multiplier)
		{
			radius *= multiplier;
		}

		public override void Print()
		{
			Console.WriteLine(" Circle: " + name + "\n Radius: " + radius);
		}
	}
}
