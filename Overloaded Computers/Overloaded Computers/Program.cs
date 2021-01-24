using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Overloaded_Computers
{
    class Program
    {
        static void Main(string[] args)
        {
			Computer iPad = new Computer("IPad", 150);
			Computer IBMPC = new Computer("IBM Personal Computer", "Ancient artifact", 1981, 4313);
			Computer govCom = new Computer("FBI Icepieonyu");

			//iPad
			iPad.CompareTo();
			iPad.CompareTo(2015);
			iPad.CompareTo(500);
			iPad.CompareTo(IBMPC);

			//govCom
			govCom.CompareTo();
			govCom.CompareTo(2006);
			govCom.CompareTo(4500);
			govCom.CompareTo(iPad);

			//IBMPC
			IBMPC.CompareTo();
			IBMPC.CompareTo(2018);
			IBMPC.CompareTo(1200);
			IBMPC.CompareTo(govCom);
		}
    }
}
