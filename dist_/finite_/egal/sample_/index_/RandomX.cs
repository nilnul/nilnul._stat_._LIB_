using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob
{
	public  class RandomX
	{
		static public readonly System.Random random = new System.Random();

		static public double next()
		{
			return random.NextDouble();
		}
		static public double NextDouble()
		{
			return random.NextDouble();
		}
		static public double _NextDouble_nonNeg(double x)
		{
			return random.NextDouble()*x;
		}

		static public int next2()
		{
			return random.Next();
		}
		static public int Next()
		{
			return random.Next();
		}

		
		
	}
}
