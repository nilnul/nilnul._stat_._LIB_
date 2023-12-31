//using nilnul.prob.doubleProb.doubleSample;
using nilnul.num.real.ext;
using nilnul.num.real.ext.func_.binary_.beta._spanned_;
using nilnul.prob.doubleProb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace nilnul.stat.dist_.borel_.pdfable_
{

	/// <summary>
	/// if u~ beta dist, then U = (m / n)X / [1 + (m / n)X] ~ F distr.
	/// f(U) du.
	/// 
	///If    B~B(m/2,n/2), then F=nB/m(1-B)     ~ F(m,n)

	/// </summary>
	/// <remarks>
	/// the span cannot be zero, as we need it to be a denominator;
	/// </remarks>
	public class Beta4dbl
		:nilnul.prob.DistributionI
		,
		nilnul.num.real.ext.func_.binary_.beta.Spanned4dblI
		,
		Beta4dblI
		//, 
		//borel_.pdf_.Invertible4dblI

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

		/// <summary>
		/// implicity spanned;
		/// </summary>
		private nilnul.num.real.ext.func_.binary_.beta._spanned.integrand.incomplete.Regularized4dbl _spannedRegularized;

		public Beta4dbl(nilnul.num.real.ext.func_.binary_.beta._spanned.integrand.incomplete.Regularized4dbl regularized0)
		{
			this._spannedRegularized = regularized0;
			this._densityCached = new num.real.ext.func_.binary_.beta._spanned.integrand.incomplete._regularized.Density4dbl(
				 regularized0.index,regularized0.indexOfComplement,regularized0.min,regularized0.max
			);
		}

		private nilnul.num.real.ext.func_.binary_.beta._spanned.integrand.incomplete._regularized.Density4dbl _densityCached;


		public double indicPlus => _spannedRegularized.index;

		public double indic4complementPlus => _spannedRegularized.indexOfComplement;

		public double min => _spannedRegularized.min;

		public double max => _spannedRegularized.max;


		public Beta4dbl(double a, double b, double min, double max):this(
			new num.real.ext.func_.binary_.beta._spanned.integrand.incomplete.Regularized4dbl(a,b,min,max)
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


		public double invert(double prob)
		{

			return _spannedRegularized.inverse(prob);// *span + min;
			//return new nilnul.math.calculus.IncompleteBetaFunctionSpanned(a, b, min, max).inverse(prob);

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

		//	//return new nilnul.num.real.ext.func_.binary_.beta._spanned.integrand.incomplete.Regularized4dbl()
		//	return nilnul.math.calculus.BetaFunction.Density2(a, b, x) / nilnul.math.calculus.BetaFunction.Eval(a, b);

		//}

		public double density(double x)
		{

			if (x <= min || x >= max)
			{
				return 0;

			}

			return _densityCached.op(x);

			//return Math.Pow(x - min, (a - 1))
			//	*
			//	Math.Pow((max - x), (b - 1))
			//	/
			//	(nilnul.math.calculus.BetaFunction.Eval(a, b)
			//	* Math.Pow(max - min, a + b - 1)
			//	)
			//	;

		}

		public double span
		{
			get
			{
				return _spannedRegularized.span;// max - min;
			}

		}



		static public double CumulativeDensity(double a, double b, double min, double max, double x)
		{
			return new Beta4dbl(a, b, min, max).cumulativeDensity(x);

			//return nilnul.math.calculus.BetaFunction.Incomplete(a, b, (x - min) / (max-min));

		}


		public double modeOrAnti()
		{
			return (a - 1) / (a + b - 2);
		}

		public double mode0anti()
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




		public double sample()
		{
			return invert(
				nilnul.stat.dist_.borel_.pdfable_.uniform_.prob.sample_._RandomX.Next4dbl()
			);
		}

		public double cumulatedProb(double x)
		{

			if (x <= min)
			{
				return 0;

			}
			if (x >= max)
			{
				return 1;


			}
			return _spannedRegularized.op(x);

			//return nilnul.math.calculus.BetaFunction.Incomplete(a, b, (x - min) / span);


		}


		public double cumulativeDensity(double x)
		{
			return cumulatedProb(x);

		}

		public double prob(Bound4dbl sample)
		{
			throw new NotImplementedException();
		}
	}
}
