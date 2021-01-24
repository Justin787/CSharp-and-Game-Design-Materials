using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Hierarchy
{
	class Character
	{
		string name;
		string type;
		int money;
		string[] dialogue = new string[3];

		public Character(string name, string type, int money, string[] dialogue)
		{
			this.name = name;
			this.type = type;
			this.money = money;
		}
	}
}
