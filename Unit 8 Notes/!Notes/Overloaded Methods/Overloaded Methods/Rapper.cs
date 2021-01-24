using System;
using System.Collections.Generic;
using System.Text;

namespace Overloaded_Methods
{
    class Rapper
    {
		string name;
		int wpm;

		//overloaded constructors
		public Rapper(string name, int wpm)
		{
			this.name = name;
			this.wpm = wpm;
		}

		public Rapper(string name)
		{
			this.name = name;
			wpm = 0; //default value
		}

		//Print()
		public void Print()
		{
			Console.WriteLine(name + " can rap at " + wpm + " words per minute.");
		}

		//CompareTo()
		//one compares this rappers wpm to an int
		public void CompareTo(int target)
		{
			if (wpm > target)
				Console.WriteLine(name + " raps faster than " + target + " wpm.");

			else if (wpm < target)
				Console.WriteLine(name + " raps slower than " + target + " wpm.");

			else
				Console.WriteLine(name + " raps exactly " + target + " wpm.");

		}

		//one compares this rappers wpm to another rappers wpm
		public void CompareTo(Rapper other)
		{
			if (wpm > other.wpm)
				Console.WriteLine(name + " raps faster than " + other.name);

			else if (wpm < other.wpm)
				Console.WriteLine(name + " raps slower than " + other.name);

			else
				Console.WriteLine(name + " raps at the same rate as " + other.name);
		}
	}
}
