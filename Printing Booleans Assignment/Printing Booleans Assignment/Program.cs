using System;
/*
*Written by Mr. Sanborn, Modified by Justin Decru
*Check out my Github: https://github.com/Justin787
*/
namespace Printing_Booleans_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
			//declare boolean variable
			bool myBool;
			//get two double values from the user
			double myVal1, myVal2;
			//your code to store user input goes here
			Console.WriteLine("Enter your first value: ");
			myVal1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter your second value");
			myVal2 = Convert.ToDouble(Console.ReadLine());
			//(don't forget to use the Convert class)

			Console.WriteLine("Printing Boolean variables!\n");
			Console.WriteLine("Part One: Simple Conditional Operators");
			Console.WriteLine("======================================");

			//greater than
			myBool = (myVal1 > myVal2);
			Console.WriteLine("Value 1 > Value 2: " + myBool + "\n");

			//less than (<)
			myBool = (myVal1 < myVal2);
			Console.WriteLine("Value 1 < Value 2: " + myBool + "\n");

			//greater than or equal to (>=)
			myBool = (myVal1 >= myVal2);
			Console.WriteLine("Value 1 >= Value 2: " + myBool + "\n");

			//less than or equal to (<=)
			myBool = (myVal1 <= myVal2);
			Console.WriteLine("Value 1 <= Value 2: " + myBool + "\n");

			//equal to (==)
			myBool = (myVal1 == myVal2);
			Console.WriteLine("Value 1 == Value 2: " + myBool + "\n");

			//not equal to (!=)
			myBool = (myVal1 != myVal2);
			Console.WriteLine("Value 1 != Value 2: " + myBool + "\n");

			//also convert the following to code and print the description and result:
			//1) Is the product of the two values greater than or equal to zero?
			myBool = (myVal1 + myVal2 >= 0);
			Console.WriteLine("Value 1 + Value 2 >= 0: " + myBool + "\n");
			//2) Is the difference of the two values less than the modulus of the two values?
			myBool = (myVal1 - myVal2 < myVal1 % myVal2);
			Console.WriteLine("Value 1 - Value 2 < Value 1 % Value 2: " + myBool);

			Console.WriteLine("\nPart Two: Compound Conditional Operators");
			Console.WriteLine("========================================");

			//AND statement 1
			//myBool = (myVal1 <= myVal2);
			//Console.WriteLine("\nValue 1 <= Value 2: " + myBool + "\n");
			myBool = (myVal1 > myVal2 && myVal2 >= 0);
			Console.WriteLine("myVal1 > myVal2 AND myVal2 is positive: " + myBool + "\n");

			//AND statement 2
			//myBool = (myVal1 <= myVal2);
			//Console.WriteLine("\nValue 1 <= Value 2: " + myBool + "\n");
			myBool = (myVal1 > myVal2 && myVal1 < 0);
			Console.WriteLine("myVal1 > myVal2 AND myVal1 is negative: " + myBool + "\n");

			//OR statement 1
			//myBool = (myVal1 <= myVal2);
			//Console.WriteLine("\nValue 1 <= Value 2: " + myBool + "\n");
			myBool = (myVal1 < myVal2 || myVal2 > 3);
			Console.WriteLine("myVal1 < myVal2 OR myVal2 is more than 3: " + myBool + "\n");

			//OR statement 2
			//myBool = (myVal1 <= myVal2);
			//Console.WriteLine("\nValue 1 <= Value 2: " + myBool + "\n");
			myBool = (myVal1 >= myVal2 || myVal1 < -3);
			Console.WriteLine("myVal1 >= myVal2 OR myVal1 is less than -3: " + myBool + "\n");

			//XOR (exclusive OR) statement
			//myBool = (myVal1 <= myVal2);
			//Console.WriteLine("\nValue 1 <= Value 2: " + myBool + "\n");
			myBool = (myVal1 == myVal2 ^ myVal2 > 10);
			Console.WriteLine("myVal1 = myVal2 XOR myVal2 is more than 10: " + myBool + "\n");

			//also convert the following to code and print the description and result:
			//1) Is the product of the two values greater than or equal to zero, AND is the sum of the two values greater than 10?
			myBool = (myVal1 + myVal2 >= 0 && myVal1 + myVal2 > 10);
			Console.WriteLine("myVal1 + myVal2 >= 0 AND myVal1 = myVal2 > 10: " + myBool + "\n");
			//2) Are the two values equal, OR is their modulus equal to zero?
			myBool = (myVal1 == myVal2 || myVal1 % myVal2 == 0);
			Console.WriteLine("myVal1 = myVal2 OR myVal1 % myVal2 = 0: " + myBool + "\n");

			Console.ReadLine(); //stop program from insta-closing
		}
    }
}
