using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace nilnul.prob.dist.inst
{


	/// <summary>
	/// if u~ beta dist. then U = (m / n)X / [1 + (m / n)X] ~ F distr.
	/// f(U) du.
	/// 
	///If    B~B(m/2,n/2), then F=nB/m(1-B)     ~ F(m,n)

	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	public class Beta2
		:DistributionI
	{
		public double a
		{
			get;
			set;
		}
		public double b
		{
			get;
			set;
		}

		public Beta2(double a, double b)
		{
			if (a <= 0 || b <= 0)
			{
				throw new Exception();
			}

			this.a = a;
			this.b = b;


		}

		public double mean()
		{
			return a / (a + b);
		}
		public double var()
		{
			return a * b / ((a + b) * (a + b) * (a + b + 1));
		}

		static public double Density(double x, double a, double b)
		{

			if (a <= 0 || b <= 0)
			{
				throw new Exception();
			}

			if (x <= 0 || x >= 1)
			{
				return 0;

			}
			return nilnul.math.calculus.BetaFunction.Density2(a,b,x) / nilnul.math.calculus.BetaFunction.Eval(a, b);

		}

		public double density(double x)
		{

			if (x <= 0 || x >= 1)
			{
				return 0;

			}
			return Math.Pow(x, (a - 1)) * Math.Pow((1 - x), (b - 1)) / nilnul.math.calculus.BetaFunction.Eval(a, b);



		}

		public double cumulativeDensity(double x)
		{
			if (x <= 0)
			{
				return 0;
			}
			if (x >= 1)
			{
				return 1;
			}

			return nilnul.math.calculus.BetaFunction.RegularizedIncomplete(a, b, x);
		}


		public double modeOrAnti()
		{
			return (a - 1) / (a + b - 2);
		}

		public double mode()
		{
			if (a > 1 && b > 1)
			{
				return modeOrAnti();

			}
			throw new Exception();
		}



		public double invert(double probability)
		{
			return nilnul.math.calculus.BetaFunction.Inverse(probability,a,b);
		}

		public double sample()
		{
			throw new NotImplementedException();
		}
	}
}
