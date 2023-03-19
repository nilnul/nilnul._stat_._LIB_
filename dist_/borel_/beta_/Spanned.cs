//using nilnul.prob.doubleProb.doubleSample;
using nilnul.num.real.func_.binary_.beta._spanned_;
using nilnul.prob.doubleProb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace nilnul.stat.dist_.borel_.beta_
{


	/// <summary>
	/// if u~ beta dist, then U = (m / n)X / [1 + (m / n)X] ~ F distr.
	/// f(U) du.
	/// 
	///If    B~B(m/2,n/2), then F=nB/m(1-B)     ~ F(m,n)

	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	public class Spanned4dbl
		:nilnul.prob.DistributionI
		,
		nilnul.num.real.func_.binary_.beta.Spanned4dblI
	{
		public double a
		{
			get {
				return this.indicPlus;
			}
			//set;
		}
		public double b
		{
			get { return this.indic4complementPlus; }
			//set;
		}

		//public double min;
		//public double max;


		private nilnul.num.real.func_.binary_.beta._spanned.integrand.incomplete.Regularized4dbl _regularized;

		public Spanned4dbl(nilnul.num.real.func_.binary_.beta._spanned.integrand.incomplete.Regularized4dbl regularized0)
		{
			this._regularized = regularized0;
			this._densityCached = new num.real.func_.binary_.beta._spanned.integrand.incomplete._regularized.Density4dbl(
				 regularized0.index,regularized0.indexOfComplement,regularized0.min,regularized0.max
			);
		}

		private nilnul.num.real.func_.binary_.beta._spanned.integrand.incomplete._regularized.Density4dbl _densityCached;


		public double indicPlus => _regularized.index;

		public double indic4complementPlus => _regularized.indexOfComplement;

		public double min => _regularized.min;

		public double max => _regularized.max;


		public Spanned4dbl(double a, double b, double min, double max):this(
			new num.real.func_.binary_.beta._spanned.integrand.incomplete.Regularized4dbl(a,b,min,max)
		)
		{
			//if (a <= 0 || b <= 0)
			//{
			//	throw new Exception();
			//}

			//this.a = a;
			//this.b = b;

			//if (min >= max)
			//{
			//	throw new Exception();

			//}

			//this.min = min;
			//this.max = max;


		}


		public double inverseCdf(double prob)
		{

			return _regularized.inverse(prob);
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

		//static public double Density(double x, double a, double b)
		//{

		//	if (a <= 0 || b <= 0)
		//	{
		//		throw new Exception();
		//	}

		//	if (x <= 0 || x >= 1)
		//	{
		//		return 0;

		//	}

		//	//return new nilnul.num.real.func_.binary_.beta._spanned.integrand.incomplete.Regularized4dbl()
		//	return nilnul.math.calculus.BetaFunction.Density2(a, b, x) / nilnul.math.calculus.BetaFunction.Eval(a, b);

		//}

		public double density(double x)
		{

			if (x <= min || x >= max)
			{
				return 0;

			}

			return _densityCached.op(x);

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
				return _regularized.span;// max - min;
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
			return _regularized.op(x);

			return nilnul.math.calculus.BetaFunction.Incomplete(a, b, (x - min) / span);



		}

		static public double CumulativeDensity(double a, double b, double min, double max, double x)
		{
			return new Spanned4dbl(a, b, min, max).cumulativeDensity(x);

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
			///convex
			throw new Exception();
		}




		public double inverseCdf()
		{
			return inverseCdf(
				nilnul.prob.RandomX.next()
			);
		}
	}
}
