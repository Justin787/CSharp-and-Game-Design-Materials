using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace _2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
			//Arrays can be multidimensional. we'll work with two-dimensional arrays. ex) a school has a list of classrooms, a classroom has a list of students.

			//declare a 2-D array of strings
			int rows = 2, cols = 3; //2 rows, 3 columns
			string[,] map = new string[rows, cols];

			map[0, 0] = "Hole of Ravenous Eels";
			map[0, 1] = "Clolster of Homework";
			map[0, 2] = "Body Odor Chamber";
			map[1, 0] = "Big Toe Stubatorium";
			map[1, 1] = "Angry Parent Vortex";
			map[1, 2] = "Toilet Spider Hive";

			/*           Col 0:		Col 1:	  Col 2:
			 *    Row 0: [0,0]      [0,1]     [0,2]
			 *    Row 1: [1,0]      [1,1]     [1,2]
			 */

			//use nested loops to print the info
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write(map[i, j] + "\t\t");
				}

				Console.WriteLine(); //skip next line after row
			}
		}
    }
}
