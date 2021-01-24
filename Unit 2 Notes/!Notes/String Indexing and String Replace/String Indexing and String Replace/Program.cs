using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace String_Indexing_and_String_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
			//Characters in a string each have a numerical position, starting with 0 (Zero-based indexing)
			//the position of a char is its index. To access the char at a given index use square brackets ("at")
			string str1 = "its the afternoon";
			string str2 = "nearly miller time";

			Console.WriteLine("Old str1: " + str1);
			Console.WriteLine("Old str2: " + str2);


			//Indexing 
			Console.WriteLine("str[9] = " + str1[9]);
			Console.WriteLine("str2[0] = " + str2[0]);

			str1 += " " + str2;
			Console.WriteLine("str[25] = " + str1[25]);


			//Accessing an illegal index
			//Console.WriteLine(str2[30]);


			//A method is a task for the code to run
			string mystr1 = "pass the butter";
			string mystr2 = mystr1.Replace("butter", "gardening shears");

			Console.WriteLine();
			Console.WriteLine(mystr1);
			Console.WriteLine(mystr2);
			Console.WriteLine();

			//chained dot notation
			mystr2 = mystr2.Replace("gardening shears", "House").Replace("pass", "Throw");
			Console.WriteLine(mystr2);
			Console.WriteLine();
		}
    }
}
