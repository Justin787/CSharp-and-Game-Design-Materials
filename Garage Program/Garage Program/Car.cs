using System;
using System.Collections.Generic;
using System.Text;

namespace Garage_Program
{
    class Car
    {
		string make;
		string model;
		string color;
		int mileage;
		int year;
		int spotNum;


		public Car(string make, string model, string color, int mileage, int year, int spotNum)
		{
			this.make = make;
			this.model = model;
			this.color = color;
			this.mileage = mileage;
			this.year = year;
			this.spotNum = spotNum;
		}


		public void Drive(int miles)
		{
			mileage = mileage + miles;
		}

		public void Paint(string color)
		{
			this.color = color;
		}

		public void Print()
		{
			Console.WriteLine(" Spot " + spotNum + " - " + color + " " + year + " " + make + " " + model + ", " + mileage);
		}
	}
}
