using System;
using System.Collections.Generic;
using System.Text;

namespace Overloaded_Computers
{
    class Computer
    {
		string model;
		string comments;
		int year;
		double value;


		//Constructors
		public Computer(string model, string additionalComments, int buildYear, double value)
		{
			this.model = model;
			this.comments = additionalComments;
			this.year = buildYear;
			this.value = value;
		}

		public Computer(string model)
		{
			this.model = model;

			//Default Values
			year = 2019;
			value = 4500;
			comments = "No comments... sorry:(";
		}

		public Computer(string model, double value)
		{
			this.model = model;
			this.value = value;

			//Default Values
			year = 2019;
			comments = "No comments... sorry:(";
		}


		//CompareTo() methods
		public void CompareTo()//Judges 
		{
			if (value < 1000)
				Console.WriteLine(" The " + model + " is worth " + value + ", nice choice!");

			else if (value >= 1000 && value < 2000)
				Console.WriteLine(" The " + model + " is worth " + value + ", not gonna lie, this is a little expensive");

			else if (value >= 2000)
				Console.WriteLine(" The " + model + " is worth " + value + ", which is way out of your price range");
		}

		public void CompareTo(int year)//Compares year
		{
			if (this.year > year)
				Console.WriteLine(" The " + model + " was made after " + year);

			else if (this.year < year)
				Console.WriteLine(" The " + model + " was made before " + year);

			else if (this.year == year)
				Console.WriteLine(" The " + model + " was made in " + year);
		}

		public void CompareTo(double value)//Compares price
		{
			if (this.value == value)
				Console.WriteLine(" The " + model + " is worth " + value);

			else if (this.value > value)
				Console.WriteLine(" The " + model + " is worth more than " + value);

			else if (this.value < value)
				Console.WriteLine(" The " + model + " is worth less than " + value);
		}

		public void CompareTo(Computer com)//Compares two computers
		{
			Console.WriteLine(" " + model + ":\t\t\t\t\t\t" + com.model + ":");
			Console.WriteLine(" " + comments + "\t\t\t\t\t\t" + com.comments);
			Console.WriteLine(" Year: " + year + "\t\t\t\t\t\t\tYear: " + com.year);
			Console.WriteLine(" Value: " + value + "\t\t\t\t\t\t\tValue: " + com.value);
			Console.WriteLine();
		}
	}
}
