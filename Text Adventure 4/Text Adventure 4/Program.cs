using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Text_Adventure_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int StrengthV = 9;     //#1
            int EnduranceV = 4;    //#2
            int KnowledgeV = 5;    //#3
            int SensesV = 7;       //#4
            double MoneyV = 87.25; //#5


            //Gnome ASCII Art
            string Gnome_ASCII = "                        ^                          \n" +
                                 "                       / \\                        \n" +
                                 "       The            /   \\                       \n" +
                                 "     Forest...       /_____\\                      \n" +
                                 "                    /VVVVVVv\\                     \n" +
                                 "                   | (@) (@) }>                    \n" +
                                 "                   \\  # < #  /                    \n" +
                                 "                    \\__vv___/                     \n" +
                                 "                      /     \\                     \n" +
                                 "------------------------------------------------------\n";

            Console.WriteLine(Gnome_ASCII);




            //User Interaction
            Console.WriteLine("Hello, survivor! Before we begin, what is your name?");
            string User_Name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Also, who is your best friend?");
            string Friend_Name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("And lastly, what is your favorite body part?");
            string Body_Part = Console.ReadLine();//I don't take credit for anything that the user types here..

            Console.WriteLine();

            //Strings 
            string Stats = " Strength:" + StrengthV +
                           "\n Endurance:" + EnduranceV +
                           "\n Knowledge:" + KnowledgeV +
                           "\n Senses:" + SensesV +
                           "\n Money:" + MoneyV + "\n";

            string Paragraph_1 = "  A plane has crashed deep within a forest, you and your" +
                                 "\n best friend, " + Friend_Name + ", are the only survivors.  " + Friend_Name + " has  " +
                                 "\n been severly injured during the crash. Their " + Body_Part + " was" +
                                 "\n completely ripped off and they're losing blood fast. You must" +
                                  "\n wait for help while surviving the dangers of the forest...\n";

            string Paragraph_2 = "   In a panic, you quickly use your shirt to slow the bleeding" +
                                 "\n of your friend's wound. You leave to search for food or water." +
                                 "\n Heading north, you come to a small river, as you kneel to take a" +
                                 "\n sip, you suddenly get an unsettling feeling, like you're being watched." +
                                 "\n You look around for a few moments, but you see nothing except the trees." +
                                 "\n As you make your way back to the crash site, you see the sun" +
                                 "\n setting along the horizon.\n";

            string Paragraph_3 = "  You find " + Friend_Name + " unconscious in the grass, blood surrounded them." +
                                 "\n Their shirt was missing. Three scratch marks could be seen across" +
                                 "\n their chest. You check their pulse...   Nothing...     " + Friend_Name + "'s dead." +
                                 "\n You sit alone as the darkness consumes you. Voices can be heard" +
                                 "\n coming from the forest. After investigating, you find nothing." +
                                 "\n You decide to try and get some sleep...\n";

            string Paragraph_4 = "   You wake up to a sharp pain across your " + Body_Part + ". You had been scratched." +
                                 "\n After standing up, you hear small, fast, footsteps. The darkness" +
                                 "\n made it nearly impossible to see. You feel another scratch on your left leg!" +
                                 "\n Where was it coming from? And then another one across your neck!" +
                                 "\n You're losing blood fast! without any medical equipment, you fall" +
                                 "\n to the ground...\n";

            string You_Died_ASCII = " -    -   ---   -    -        ----  ----  ----  ----     " +
                                  "\n  -  -   -   -  -    -        -   -  --   --    -   -    " +
                                  "\n   --    -   -  -    -        -   -  --   --    -   -    " +
                                  "\n   --     ---    ----         ----  ----  ----  ----     \n";






            //Everything Printed
            Console.WriteLine(Stats);
            Console.WriteLine(Paragraph_1);
            Console.WriteLine(Paragraph_2);
            Console.WriteLine(Paragraph_3);
            Console.WriteLine(Paragraph_4);
            Console.WriteLine(You_Died_ASCII);
        }
    }
}
