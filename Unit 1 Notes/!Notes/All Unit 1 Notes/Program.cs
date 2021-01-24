using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace All_Unit_1_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is where the code goes!
            //These are the single line comments.                  // Single line comment    /* multi line comment */

            //Simple print statements
            Console.WriteLine("print statements!");
            Console.WriteLine("Let us begin.");
            Console.WriteLine(); //Empty Line

            //Dealing with quotes
            Console.WriteLine("\"My name is Ed.\" said Ed");             //   \\=literal backslash   \"=literal quotation mark

            //Dealing with backslashes
            Console.WriteLine("Some slashes: / \\ / \\ / \\");

            //Ending a line inside a print statement
            Console.WriteLine("First line\nSecond line\n\n");   //  \n = end line (enter button)

            //Tab escape sequence:
            Console.Write("This\tis\tnicely\tspaced\n\n");     //  \t = tab



            //Some weird line
            Console.WriteLine("_________________________________________________________\n\n");




            // a message in wuotes is a literal, aka a string. if doesnt have quotes, its a value
            //Console.write("message") prints the message; Console.write(value) evaluates and prints the value

            Console.WriteLine("Simple arithmetic:\n");

            //Addition
            Console.Write("2 plus 2 is ");
            Console.Write(2 + 2);
            Console.WriteLine("\n");

            //Subtraction
            Console.Write("5 minus -8 is ");
            Console.Write(5 - -8);
            Console.WriteLine("\n");

            //Multiplication
            Console.Write("4 times 2 times 5 is ");
            Console.Write(4 * 2 * 5);
            Console.WriteLine("\n");

            //Division
            Console.Write("7 devided by 3 is ");
            Console.Write(8 / 3); // should be 2.666666               // Integer calculations only give integer answers (Whole numbers)
            Console.WriteLine("\n");
            Console.Write("uh let me try that again\n");
            Console.Write("eight divided by three is ");
            Console.Write(8.0 / 3);

            //Mystery operator (The modulus operator (%) stores the remainder of the division problem)
            //Ex. 15 devided by 4 is 3 with a remainder of 2. Therefore, 14 mod 4 is 2.
            Console.Write("14 modulo 4 is ");
            Console.Write(14 % 4);
            Console.WriteLine("\n");

            //Order of operations                //Follows the same order as PEMDAS; parentheses work from the inside out
            Console.Write("7 plus 4 divided by 3 is ");
            Console.Write(7 + 4 / 3);
            Console.Write("\n");
            Console.Write("if you add first it's ");
            Console.Write((7 + 4) / 3);
            Console.WriteLine("\n\n");



            //Some weird line
            Console.WriteLine("_________________________________________________________\n\n");


            Console.WriteLine("Values:\n");



            // A variable is a placeholder in memory. It has a value, an identifier(name), and a data type(determines how much memory is reserved and what kind of value is allowed to be stored)
            // Some primitive data types: int (integer value) / double(decimal value) / float(less precise decimal value)
            // In order to use a variable, you must declare its type and name.     int myVariable;
            // Declare some variables...
            int iNumber; // an integer value
            double dNumber; // a decimal value
            float fNumber; // a floating-point value

            // The assignment operator (=) evaluates everything on the right side and stores it in the variable on the left side.
            //asign some values to the variables...
            iNumber = 612;
            dNumber = -17.3;
            fNumber = 3.5f; //f for a float value

            // Display the variable values
            Console.WriteLine("iNumber: " + iNumber);
            Console.WriteLine("dNumber: " + dNumber);
            Console.WriteLine("fNumber: " + fNumber);

            Console.WriteLine("\n");

            //Change the variable values
            iNumber = 9;
            dNumber = dNumber + 2;
            /* The above line evaluates dNumber + 2 
             * and then stores the result in dNumber.
             */

            Console.WriteLine("iNumber: " + iNumber);
            Console.WriteLine("dNumber: " + dNumber);
            Console.WriteLine("fNumber: " + fNumber);

            //Declare and assign a new variable:
            int theBestNumber = 11;

            Console.WriteLine("\nThe Best Number is " + theBestNumber);

            Console.WriteLine("\n\n");
            /*Restrictions on variable names: 
             *cant use reserved keywords.
             *can use only letters, numbers, and underscores.
             *must start with a letter(should generally start with lowercase letter)
             */
            Console.WriteLine("_________________________________________________________\n\n");

            //Pseudocode is a blueprint for your program without any actual code.  You should write this in your comments as a preliminary project step before you start coding

            //Arithmetic assignment operators                                          
            int x = 9;
            double y = 4.2;

            //add 3 to the vallue of x
            //x = x + 3;
            x += 3; //arithmetic assignment

            Console.WriteLine("x = " + x);

            y -= 3.1;
            Console.WriteLine("y = " + y);

            Console.WriteLine();
            //current value of x is 12
            x %= 5;
            Console.WriteLine("New x = " + x);

            //increment and decrement      // increment operator (++) adds 1 to the variable, decrement does the opposite
            x++;  // add 1 to x
            Console.WriteLine("After incrementing");
            y--;  //subtract 1 from y
            Console.WriteLine("After decrementing, y =" + y);


            //casting                 //To store a value of a different type (where allowed) inside a variable, a cast is performed
            y = 6;     // implicitly casts an int to a double          // double myVal= 6;     ... is and implicit cast because no extra code is needed  
            x = (int)6.4;   // explicitly casts a double to an int

            Console.WriteLine("\nAfter casting, ");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
    }
}
