using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Intro_to_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
			//an array is a collection of variables of the same type. declared using square braces:  [ ]
			//an array has a specified length that cannot be changed after it is declared (Static, not dynamic) 

			//declare a couple of arrays
			int[] array1 = new int[3]; //stores 3 ints
			string[] array2 = { "Different", "way", "to", "store", "values!" }; //stores 5 strings

			//fill arrays with values and print them
			array1[0] = 10;
			array1[1] = 20;
			array1[2] = 31;

			//Console.WriteLine(array1);  //doesnt work
			Console.WriteLine(array1[0] + " " + array1[1] + " " + array1[2]);

			//traverse and print the second array
			for (int i = 0; i < array2.Length; i++)
				Console.WriteLine(array2[i]);

			//the largest possible value int32 can hold is available as the constant int32.maxvalue and the smallest is int32.minvalue
			//max and min values
			Console.WriteLine("Biggest possible int: " + Int32.MaxValue);
			Console.WriteLine("Smallest: " + Int32.MinValue);
		}
    }
}
