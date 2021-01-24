using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Foreach_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and fill an array of ints
            int[] odds = { 1, 3, 5, 7, 9 };

            //use a foreach loop to write them out
            foreach (int number in odds)
            {
                Console.WriteLine(number);
                //number = 10; //doesnt work
            }
        }
    }
}
