using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace String_Variable_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            //New data type: String - holds a message consisting of letters, numbers, other ASCII characters, and/or escape sequences. Defined with quotation marks


            //declare some string variables
            string str1 = "Bibbidy";
            string str2 = "Bobbidy";
            string str3 = "Bebbidy";

            //New data type: Char - holds a single ASCII character. Defined with single quotes
            char ch1 = 'T';
            char ch2 = '9';
            char ch3 = '(';

            //Strings can be concatinated (put together) using the + operator.
            //Concatination
            Console.WriteLine(str1 + " " + str2 + " " + str3);
            Console.WriteLine(ch1 + ch2 + ch3);
            //Because + does more than 1 thing in C# it is called an overloaded operator. (Must add spaces unless you'll get a number)
            Console.WriteLine(ch1 + " " + ch2 + " " + ch3);

            str1 = str3 + str2 + str1;
            Console.WriteLine(str1);
            str2 += str1 + str1;
            Console.WriteLine(str2);

            //string class has a built in attribute called the length that holds the length of the string (as an int) automatically and can be accessed through dot notation: MyString.Length
            Console.WriteLine("Length of that: " + str2.Length);
            str3 = "Talking during lecture leads to immediate execution!";
            Console.WriteLine("Length of str3" + str3.Length);

            //Documentation for every aspect of C# is stored in the API(Application program interface) on the microsoft page. To find this google 

        }
    }
}
