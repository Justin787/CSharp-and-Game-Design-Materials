using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Class_and_Objects_Program
{
    class Program
    {
        static void Main(string[] args)
        {
			//Pencil Object
			Console.WriteLine(" Object 1");

			Thing pencil = new Thing();

			pencil.SetName("Pencil");
			pencil.SetPurpose("Writes stuff");

			Console.WriteLine(" Name: " + pencil.GetName());
			Console.WriteLine(" Purpose: " + pencil.GetPurpose());



			//Eraser Object
			Console.WriteLine("\n Object 2");

			Thing eraser = new Thing();

			eraser.SetName("Eraser");
			eraser.SetPurpose("Gets rid of mistakes");

			Console.WriteLine(" Name: " + eraser.GetName());
			Console.WriteLine(" Purpose: " + eraser.GetPurpose());



			//Mtn Dew Object
			Console.WriteLine("\n Object 3");

			Thing mtnDew = new Thing();

			mtnDew.SetName("Mtn Dew");
			mtnDew.SetPurpose("Keeps you motivated");

			Console.WriteLine(" Name: " + mtnDew.GetName());
			Console.WriteLine(" Purpose: " + mtnDew.GetPurpose());
			Console.WriteLine();
		}
    }
}
