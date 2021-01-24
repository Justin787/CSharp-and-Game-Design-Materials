using System;
/*
*Written by Justin Decru
*I don't care if you plagiarize and take credit for my work, as long as I get cool points
*Check out my Github: https://github.com/Justin787
*/
namespace Library_Fine
{
    class Program
    {
        static void Main(string[] args)//I am so sorry for the lack of pseudocode
        {
			//Variables          
			string name = "";
			string firstname = "";
			string lastname = "";
			string firstnameL = "";
			string lastnameL = "";
			string whole_name = "";
			string phone_number = "";
			string book_name = "";
			string day_checked_out = "";
			string day_checked_outN = "";
			string email = "";
			int name_index = (0);
			int days_late = (0);
			double daily_fine = (0);
			double fine = (0);

			//User Input       
			Console.Write(" Enter the name (Last, First): ");//Firstname/Lastname
			name = Console.ReadLine();
			firstname = name.Substring(name.IndexOf(',') + 2);
			lastname = name.Substring(0, name.IndexOf(','));
			whole_name = firstname + " " + lastname;
			name_index = name.IndexOf(name);
			Console.WriteLine();

			Console.Write(" Enter the phone number (###) ###-####: ");//Phone Number
			phone_number = Console.ReadLine();
			Console.WriteLine();

			Console.Write(" Enter the title of the book: ");//Book Title
			book_name = Console.ReadLine();
			Console.WriteLine();

			Console.Write(" Enter the date checked out (mm/dd/yyyy): ");//Date Checked Out
			day_checked_out = Console.ReadLine();
			day_checked_outN = day_checked_out.Replace('/', '-');
			Console.WriteLine();

			Console.Write(" Days Late: ");//Days Late
			days_late = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			Console.Write(" Daily Fine: ");//Daily Fine
			daily_fine = Convert.ToDouble(Console.ReadLine());
			fine = days_late * daily_fine;//Fine


			//Email Address                           
			firstnameL = firstname.ToLower();
			lastnameL = lastname.ToLower();
			email = firstnameL.Substring(0, 1) +
					lastnameL.Substring(0, 4) +
					phone_number.Substring(phone_number.IndexOf('-') + 1, 4) + "@lc-ps.org";


			//Email Message
			Console.WriteLine("\n\n\n Email Message: ");
			Console.WriteLine("\n To: " + whole_name + "\t(" + email + ")\n"); //To
			Console.WriteLine(" From: The Library Lady\t(thelibrarylady@thelibrary.net)\n"); //From
			Console.WriteLine(" Subject: Overdue Book Notice"); //Subject
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine(" " + book_name + " was checked out on: " + day_checked_outN);
			Console.WriteLine(" This book is currently " + days_late + " day(s) late.");
			Console.WriteLine(" Your fine has accumulated to: $" + fine + " dollar(s)");

			Console.WriteLine("\n\n\n");
		}
    }
}
