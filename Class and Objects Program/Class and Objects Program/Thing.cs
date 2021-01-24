using System;
using System.Collections.Generic;
using System.Text;

namespace Class_and_Objects_Program
{
    class Thing
    {
		//Variables
		string name;
		string purpose;

		public Thing()
		{

		}

		public void SetName(string name)
		{
			this.name = name;
		}

		public void SetPurpose(string purpose)
		{
			this.purpose = purpose;
		}

		public string GetName() { return name; }
		public string GetPurpose() { return purpose; }

	}
}
