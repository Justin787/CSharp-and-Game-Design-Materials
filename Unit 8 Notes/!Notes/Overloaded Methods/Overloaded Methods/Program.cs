using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Overloaded_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
			//overloaded methods are multiple methods with the same name and the same return type and/or the same number of arguements

			//create the objects
			Rapper r1 = new Rapper("Timmy Turner", 1000);
			Rapper r2 = new Rapper("Mexican Eminem", 2);
			Rapper r3 = new Rapper("Edgelord");
			Rapper r4 = new Rapper("Mr. Sanborn");

			//Call Print()
			r1.Print();
			r2.Print();
			r3.Print();
			r4.Print();

			//test the CompareTo() method
			Console.WriteLine();
			r1.CompareTo(500);
			r2.CompareTo(500);
			r3.CompareTo(r4);
			r4.CompareTo(r1);
		}
    }
}
