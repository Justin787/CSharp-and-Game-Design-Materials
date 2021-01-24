using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/

namespace Class_Hierarchy
{
	class Program
	{
		static void Main(string[] args)
		{
			//create some ComputerPart and keyboard objects
			Computer_Part graphics = new Computer_Part("Graphics Card", 150, 800.00);
			Computer_Part processor = new Computer_Part("Ryzen Processor", 100, 250.50);
			Computer_Part usbfan = new Computer_Part("USB-powered fan", 3, 0.25);
			Keyboard corsair = new Keyboard("Corsair Mechanical", 7, 100, true);
			Keyboard dell = new Keyboard("Classroom keyboard", 7, 3, false);

			//test the methods
			graphics.Print();
			processor.Print();
			usbfan.Print();
			corsair.Print();
			dell.Print();
			Console.WriteLine();
			processor.Depreciate(60);
			dell.Depreciate(20);
			Console.WriteLine();
			corsair.Type(90);
			dell.Type(20);
		}
	}
}
