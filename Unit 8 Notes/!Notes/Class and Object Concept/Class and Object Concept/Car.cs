using System;
using System.Collections.Generic;
using System.Text;

namespace Class_and_Object_Concept
{
    class Car
    {
		/*
		 * Class diagram for car
		 * properties:
		 * mileage(int)
		 * color(string)
		 * does it have 4 doors?(bool)
		 * 
		 * methods:
		 * Drive()-- accepts int returns void
		 * Paint()-- accepts a string returns void
		 */

		//class variables 
		private int mileage = 0;
		private string color = "black";
		private bool has4doors = true;

		//class methods
		public void Drive(int miles)
		{
			//add miles to current mileage
			mileage += miles;
		}

		public void Paint(string targetcolor)
		{
			//change color to targetcolor
			color = targetcolor;
		}

		//Getter methods for the variables
		public int GetMileage()
		{
			return mileage;
		}

		public string GetColor()
		{
			return color;
		}

		public bool GetDoors()
		{
			return has4doors;
		}
	}
}
