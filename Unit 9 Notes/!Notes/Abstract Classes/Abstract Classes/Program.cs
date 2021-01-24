using System;
using System.Collections.Generic; //for lists
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
			//instantiate our 5 non abstract classes
			Circle circ = new Circle("circle du Soleil", 2.5);
			Rectangle rect = new Rectangle("Get REKTangle", 3, 4);
			Scalene scal = new Scalene("HEY THESE SIDES DONT MATCH", 3, 4, 5);
			Isosceles isos = new Isosceles("Eye Sauce", 10.5, 6.66);
			Equilateral equi = new Equilateral("Try-Hard-angle", 8);

			//polymorphism: create a List of TwoDShapes to hold these
			List<TwoDShape> myList = new List<TwoDShape>();
			myList.Add(circ);
			myList.Add(rect);
			myList.Add(scal);
			myList.Add(isos);
			myList.Add(equi);

			//use a loop to demonstrate common methods
			foreach (TwoDShape shape in myList)
			{
				shape.ChangeSize(2);
				shape.Print();
				Console.WriteLine();
			}
		}
    }
}
