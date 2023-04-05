using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_.pdf_.uniform_
{
	 public  class Prob4dbl
		:
		Pdfable4dblA
		,
		borel_.pdf_.Invertible4dblI
	{
		private System.Random _rnd;
		private System.Random _bit;


		public Prob4dbl(Random a,Random bit)
		{
			_rnd = a;
			_bit = bit;
		}
		public Prob4dbl():this( new Random(), new Random())
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
			double d;
			int i;
			var r1 = dist.survey_._RndsX.Get0th();

			do
			{
				d = dist.survey_._RndX.Rnd.NextDouble();
				i = r1.Next(2);
			} while (i == 1 && d > 0);

			return d + i;// [0,1) and [1,2), we just discard the gt 1 part;
		}

		static public Prob4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Prob4dbl>.Instance;
			}
		}

		static public Prob4dbl _OfStatic() {
			return new Prob4dbl(
				dist.survey_._RndX.Rnd
				,
				dist.survey_._RndsX.Get0th()
			);
		}

		static public readonly Prob4dbl StaticInstance = _OfStatic();
	}
}
