using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Shop_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            double CtnCndy = 5.99;   //Cotton Candy
            double Cokcola = 2.75;  //Cocacola
            double PigToes = 100.99;  //Pig Toes
            double Skttles = 3.75;  //Skittles
            double AplJuic = 6.25;  //Apple Juice
            double Pepsi = 3.55;  //Pepsi

            int CtnCndyS = 51; //Cotton Candy Sold
            int CokcolaS = 47; //Cocacola Sold
            int PigToesS = 21; //Pig Toes Sold
            int SkttlesS = 65; //Skittles Sold
            int AplJuicS = 85; //Apple Juice Sold
            int PepsiS = 27; //Pepsi Sold

            double CostT = 0; //Cost Total
            double AmountSoldT = 0; //Sold Total
            double TotalT = 0; //Overall Total

            CostT = CtnCndy + Cokcola + PigToes + Skttles + AplJuic + Pepsi;
            AmountSoldT = CtnCndyS + CokcolaS + PigToesS + AplJuicS + PepsiS;

            //Title and Labels
            Console.WriteLine("\t\t\t    Justin's Shoppe\n\n");
            Console.WriteLine(" Item Name\t\tCost\t\tAmount Sold\t\tTotal");

            //Cotton Candy Line
            Console.Write("\n Cotton Candy\t\t$" + CtnCndy);
            Console.Write("\t\t51"); //51 Sold
            CtnCndy *= CtnCndyS;
            Console.Write("\t\t\t$" + CtnCndy);

            //Cocacola Line
            Console.Write("\n\n Cocacola\t\t$" + Cokcola);
            Console.Write("\t\t47"); //47 Sold
            Cokcola *= CokcolaS;
            Console.Write("\t\t\t$" + Cokcola);

            //Pig Toes Line
            Console.Write("\n\n Pig Toes\t\t$" + PigToes);
            Console.Write("\t\t21"); //21 Sold
            PigToes *= PigToesS;
            Console.Write("\t\t\t$" + PigToes);

            //Skittles Line
            Console.Write("\n\n Skittles\t\t$" + Skttles);
            Console.Write("\t\t65"); //65 Sold
            Skttles *= SkttlesS;
            Console.Write("\t\t\t$" + Skttles);

            //Apple Juice Line
            Console.Write("\n\n Apple Juice\t\t$" + AplJuic);
            Console.Write("\t\t85"); //85 Sold
            AplJuic *= AplJuicS;
            Console.Write("\t\t\t$" + AplJuic);

            //Pepsi Line
            Console.Write("\n\n Pepsi\t\t        $" + Pepsi);
            Console.Write("\t\t27"); //27 Sold
            Pepsi *= PepsiS;
            Console.Write("\t\t\t$" + Pepsi);

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            //Totals...
            TotalT = CtnCndy + Cokcola + PigToes + Skttles + AplJuic + Pepsi;
            Console.Write("\nTOTALS");
            Console.Write("\t\t\t$" + CostT + "\t\t" + AmountSoldT + "\t\t\t$" + TotalT);
            Console.Write("\n\nTotal amount collected: $" + TotalT + "\n");
        }
    }
}
