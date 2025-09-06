using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob._prob
{
	public partial class RandomX
	{
		static public readonly System.Random random = new System.Random();

	
		static public double NextDouble()
		{
			return random.NextDouble();
		}

		
		static public int Next()
		{
			return random.Next();
		}

		
		
	}
}
