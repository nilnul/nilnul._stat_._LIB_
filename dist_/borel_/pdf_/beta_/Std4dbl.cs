using nilnul.num.real.ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace nilnul.stat.dist_.borel_.pdf_.beta_
{


	/// <summary>
	/// in the interval of [0,1]
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// if u~ beta dist. then U = (m / n)X / [1 + (m / n)X] ~ F distr.
	/// f(U) du.
	/// 
	///If    B~B(m/2,n/2), then F=nB/m(1-B)     ~ F(m,n)
	public class Std4dbl
		:
		borel_.Pdfable4dblA
		,
		nilnul.prob.DistributionI
		//,
		//nilnul.stat.IDist
		//,
		//dist_.IBorel
		,
		borel_.pdf_.Beta4dblI

		//,
		//borel_.pdf_.Invertible4dblI
		,
		nilnul.num.real.ext.func_.binary_.Beta4dblI
	{
		

		public double indicPlus => _regularized.indicPlus;

		public double indic4complementPlus => _regularized.indic4complementPlus;

		public double min => 0;

		public double max => 1;

		nilnul.num.real.ext.func_.binary_._beta.integrand.incomplete.Regularized4dbl _regularized;

		nilnul.num.real.ext.func_.binary_._beta.integrand.incomplete._regularized.Density4dbl _densityCached;


		public Std4dbl(
nilnul.num.real.ext.func_.binary_._beta.integrand.incomplete.Regularized4dbl density0
		)
		{
			this._regularized = density0;
			this._densityCached = new num.real.ext.func_.binary_._beta.integrand.incomplete._regularized.Density4dbl(density0.indicPlus, indic4complementPlus);
		}


		public Std4dbl(double a, double b)
			:this(
				 new num.real.ext.func_.binary_._beta.integrand.incomplete.Regularized4dbl(a,b)
			)
		{
			//if (a <= 0 || b <= 0)
			//{
			//	throw new Exception();
			//}

			//this.a = a;
			//this.b = b;



		}

		/// <summary>
		/// the avergage;
		/// </summary>
		/// <returns></returns>
		public double mean()
		{
			return indicPlus / (indicPlus + indic4complementPlus);
		}

		/// <summary>
		/// variance
		/// </summary>
		/// <returns></returns>
		public double var()
		{
			return indicPlus * indic4complementPlus / ((indicPlus + indic4complementPlus) * (indicPlus + indic4complementPlus) * (indicPlus + indic4complementPlus + 1));
		}

		static public double Density(double x, double a, double b)
		{

			return new Std4dbl(a, b).density(x);

			//if (a <= 0 || b <= 0)
			//{
			//	throw new Exception();
			//}

			//if (x <= 0 || x >= 1)
			//{
			//	return 0;
			//}
			//return new nilnul.num.real.ext.func_.binary_._beta.integrand.incomplete._regularized.Density4dbl(a, b).op(x);

			////return nilnul.math.calculus.BetaFunction.Density2(a,b,x)
			//	/
			//	nilnul.math.calculus.BetaFunction.Eval(a, b);

		}

		public override double density(double x)
		{

			if (x <= 0 || x >= 1)
			{
				return 0;

			}
			return this._densityCached.op(x);

			//return Math.Pow(x, (indicPlus - 1)) * Math.Pow((1 - x), (indic4complementPlus - 1)) / nilnul.math.calculus.BetaFunction.Eval(indicPlus, indic4complementPlus);



		}



		public double modeOrAnti()
		{
			return (indicPlus - 1) / (indicPlus + indic4complementPlus - 2);
		}

		public double mode()
		{
			if (indicPlus > 1 && indic4complementPlus > 1)
			{
				return modeOrAnti();

			}
			///convex
			throw new Exception();
		}



		public override double invert(double probability)
		{
			return this._regularized.inverse(probability);
			//return nilnul.math.calculus.BetaFunction.Inverse(probability,indicPlus,indic4complementPlus);
		}

		public override double sample()
		{
			return invert(
				borel_.pdf_.uniform_.Preportion4dblEs.Get0th().sample() //._Preportion4dblX.Sample()
			);
		}

		public override double cdf(double x)
		{
			if (x <= 0)
			{
				return 0;
			}
			if (x >= 1)
			{
				return 1;
			}
			return _regularized.op(x);

			//return nilnul.math.calculus.BetaFunction.RegularizedIncomplete(indicPlus, indic4complementPlus, x);

		}

		[Obsolete(nameof(cdf))]
		public double cumulativeDensity(double x)
		{

			return cdf(x);
		}

		
	}
}
