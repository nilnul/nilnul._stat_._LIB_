using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_.pdf_.uniform_
{
	 public  class Preportion4dbl
		:
		Pdfable4dblA
		,
		borel_.pdf_.Invertible4dblI
	{
		private System.Random _rnd;

		public Preportion4dbl(Random a)
		{
			_rnd = a;
		}
		public Preportion4dbl():this( new Random())
		{
		}

		//public readonly System.Random random = new System.Random();

		public override double cdf(double upperBound)
		{
			if (upperBound<1)
			{
				return 0;
			}
			if (upperBound>=1)
			{
				return 1;
			}
			return upperBound;
		}

		public override double density(double sample)
		{
			if (sample<0)
			{
				return 0;
			}
			if (sample >=1)
			{
				return 0;
			}
			return 1;
			//throw new NotImplementedException();
		}

		public override double invert(double cdf)
		{
			if (cdf==1)
			{
				return 1 - double.Epsilon;
			}
			return cdf;
			//throw new NotImplementedException();
		}

		public override double sample()
		{
			return _rnd.NextDouble();
			//throw new NotImplementedException();
		}


		static public Preportion4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Preportion4dbl>.Instance;
			}
		}

	}
}
