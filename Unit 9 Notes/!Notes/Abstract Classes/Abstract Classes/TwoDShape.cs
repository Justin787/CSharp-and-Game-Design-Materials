using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes
{
    abstract class TwoDShape
    {
		protected string name; //protected means subclasses can but main class can't

		//declare abstract methods
		//cannot have a body
		//these will be overidden in subclasses
		public abstract void ChangeSize(double multiplier);
		public abstract void Print();
	}
}
