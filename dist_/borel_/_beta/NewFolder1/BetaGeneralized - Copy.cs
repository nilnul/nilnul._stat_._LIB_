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
	///
	[Obsolete()]
	public class BetaGeneralized
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

		public double min;
		public double max;

		public BetaGeneralized(double a, double b, double min, double max)
		{
			if (a <= 0 || b <= 0)
			{
				throw new Exception();
			}

			this.a = a;
			this.b = b;

			if (min >= max)
			{
				throw new Exception();

			}

			this.min = min;
			this.max = max;


		}

		public double inverseCdf(double prob) {

			return new nilnul.math.calculus.IncompleteBetaFunctionSpanned(a, b, min, max).inverse(prob);
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
			return nilnul.math.calculus.BetaFunction.Density2(a, b, x) / nilnul.math.calculus.BetaFunction.Eval(a, b);

		}

		public double density(double x)
		{

			if (x <= min || x >= max)
			{
				return 0;

			}


			return Math.Pow(x - min, (a - 1))
				*
				Math.Pow((max - x), (b - 1))
				/
				(nilnul.math.calculus.BetaFunction.Eval(a, b)
				* Math.Pow(max - min, a + b - 1)
				)
				;

		}

		public double span
		{
			get
			{
				return max - min;
			}

		}

		public double cumulativeDensity(double x)
		{

			if (x <= min)
			{
				return 0;

			}
			if (x >= max)
			{
				return 1;


			}

			return nilnul.math.calculus.BetaFunction.Incomplete(a, b, (x - min) / span);



		}

		static public double CumulativeDensity(double a, double b, double min, double max, double x)
		{

			return nilnul.math.calculus.BetaFunction.Incomplete(a, b, (x - min) / (max-min));

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




		public double inversePdf()
		{
			return inverseCdf(
			RandomX.next());
		}
	}
}
