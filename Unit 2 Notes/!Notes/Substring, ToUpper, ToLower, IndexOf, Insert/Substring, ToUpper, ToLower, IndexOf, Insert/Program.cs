using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Substring__ToUpper__ToLower__IndexOf__Insert
{
    class Program
    {
        static void Main(string[] args)
        {

			//substring()
			string str1 = "wednesday is the third day";
			Console.WriteLine("Original: " + str1);
			Console.Write("Start at position 13: ");
			Console.Write(str1.Substring(13));
			Console.WriteLine();

			Console.Write("Start at position 4, take 10 chars: ");
			Console.WriteLine(str1.Substring(4, 10));


			//Index of (char)
			Console.WriteLine("Index of 'y': " + str1.IndexOf('y'));
			Console.WriteLine("Index of '#': " + str1.IndexOf('#'));
			Console.WriteLine();

			//combine these to look for a word
			string str2 = str1.Substring(str1.IndexOf("third"));
			Console.WriteLine(str2);
			Console.WriteLine();

			//ToLower() and ToUpper()
			Console.WriteLine(str1.ToLower());
			Console.WriteLine(str1.ToUpper());
			Console.WriteLine();

			//Remove()
			Console.WriteLine(str1.Remove(12, 6));
		}
    }
}
