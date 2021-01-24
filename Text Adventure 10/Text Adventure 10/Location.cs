using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Adventure_10
{
    class Location
    {
		string map;
		string name;
		string description;
		List<string> contents = new List<string>();

		public Location(string map, string name, string description)
		{
			this.map = map;
			this.name = name;
			this.description = description;
		}

		public void Print()
		{
			Console.WriteLine(name);
			Console.WriteLine(map);
			Console.WriteLine(description);
		}
	}
}
