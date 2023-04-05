using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.doubleSample.cdf.contains
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
	public class Beta3
		:DistributionA
		,
		CdfAndInverseI
	{
		public double shapPara1
		{
			get;
			set;
		}
		public double shapPara2
		{
			get;
			set;
		}

		public Beta3(double shapPara1, double shapPara2)
		{
			if (shapPara1 <= 0 || shapPara2 <= 0)
			{
				throw new Exception();
			}

			this.shapPara1 = shapPara1;
			this.shapPara2 = shapPara2;


		}



		public double mean()
		{
			return shapPara1 / (shapPara1 + shapPara2);
		}
		public double var()
		{
			return shapPara1 * shapPara2 / ((shapPara1 + shapPara2) * (shapPara1 + shapPara2) * (shapPara1 + shapPara2 + 1));
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
			return Math.Pow(x, (shapPara1 - 1)) * Math.Pow((1 - x), (shapPara2 - 1)) / nilnul.math.calculus.BetaFunction.Eval(shapPara1, shapPara2);



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

			return nilnul.math.calculus.BetaFunction.RegularizedIncomplete(shapPara1, shapPara2, x);
		}

		public double antiMode() {
			nilnul.bit.AssertionNullaryFunc.True(shapPara1 < 1 && shapPara2 < 1);
			return modeOrAnti();
		}


		public double modeOrAnti()
		{
			return (shapPara1 - 1) / (shapPara1 + shapPara2 - 2);
		}

		public double mode()
		{
			if (shapPara1 > 1 && shapPara2 > 1)
			{
				return modeOrAnti();

			}
			throw new Exception();
		}



		public double inversePdf(double probability)
		{
			return nilnul.math.calculus.BetaFunction.Inverse(probability,shapPara1,shapPara2);
		}

	

		public override Prob probability(double  upperBound)
		{
			if (upperBound <= 0)
			{
				return Prob.Zero;
			}
			if (upperBound >= 1)
			{
				return Prob.One;
			}

			return new Prob( nilnul.math.calculus.RegularizedIncompleteBetaFunction.Eval(shapPara1, shapPara2, upperBound));
		}

		public override double inverse(Prob prob)
		{
			return nilnul.math.calculus.RegularizedIncompleteBetaFunction.Inverse( shapPara1, shapPara2,prob._val);
		}
	}
}
