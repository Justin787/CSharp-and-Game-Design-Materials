using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring bool
            bool var1, var2;
            var1 = 7 > 5;
            var2 = (3 - 8) >= -50;
            Console.WriteLine("7>5: " + var1);
            Console.WriteLine("Other: " + var2);

            //wihtout a variable
            Console.WriteLine("2+2 == 5 ? " + ((2 + 2) == 5));
            Console.WriteLine("7 != 8 * 2 " + (7 != 8 * 2));

            // AND = && evals true only if both are tru
            // OR = || evals if either are tru
            // XOR = ^ evals if one is tru and one is false
            Console.WriteLine();
            Console.WriteLine("true AND true " + (true && true));
            Console.WriteLine("true AND false " + (true && false));
            Console.WriteLine("false AND false " + (false && false));
            Console.WriteLine();

            Console.WriteLine("true OR true " + (true || true));
            Console.WriteLine("true OR false " + (true || true));
            Console.WriteLine("false OR false " + (true || true));
            Console.WriteLine();

            Console.WriteLine("true XOR true " + (true ^ true));
            Console.WriteLine("true XOR false " + (true ^ false));
            Console.WriteLine("false XOR false " + (false ^ false));
            Console.WriteLine();
        }
    }
}
