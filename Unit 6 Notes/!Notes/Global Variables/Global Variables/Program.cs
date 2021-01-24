using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Global_Variables
{
    class Program
    {
        //global variables
        static Random rng = new Random();
        static int count = 0; //keep track of loop iterations

        static void Main(string[] args)
        {
            //create and fill an array of ints
            int[] numbers = { 11, 12, 13, 14 };

            //int variable
            int myNum = 100;

            //call scramble method
            Scramble(numbers, myNum);

            //print results
            foreach (int num in numbers)
                Console.Write(num + " ");

            Console.WriteLine("\nmyNum: " + myNum);
            Console.WriteLine("Final value of count: " + count);
        }

        //Method to randomize int array
        static void Scramble(int[] myArray, int number)
        {
            Random rng = new Random();
            //fill the array with random numbers
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rng.Next(1, 3);//1-2 
                count++;//increment count

            }

            number = 7;
        }
    }
}
