using nilnul.math.calculus.betaFunc;
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
	public class SpanBeta
		: 
		CdfAndInverseI
	{


		public double a
		{
			get
			{
				return _regularizedIncompleteSpanBeta.a;
			}

		}
		public double p
		{
			get
			{
				return _regularizedIncompleteSpanBeta.a;
			}

		}
		public double b
		{
			get
			{
				return _regularizedIncompleteSpanBeta.b;
			}
		}
		public double q
		{
			get
			{
				return _regularizedIncompleteSpanBeta.b;
			}
		}

		public double min {
			get {
				return _regularizedIncompleteSpanBeta.min;
			}
		}
		public double max {
			get {
				return _regularizedIncompleteSpanBeta.max;
			}
		}

		private nilnul.math.calculus.betaFunc.RegularizedIncompleteSpanBeta _regularizedIncompleteSpanBeta;

		public RegularizedIncompleteSpanBeta regularizedIncompleteSpanBeta
		{
			get { return _regularizedIncompleteSpanBeta; }
			set
			{

				_regularizedIncompleteSpanBeta = value.EnsureNotNull();

			}
		}



		public SpanBeta(NotNull2<RegularizedIncompleteSpanBeta> regularizedIncompleteSpanBeta)
		{
			this.regularizedIncompleteSpanBeta = regularizedIncompleteSpanBeta;
		}


		public SpanBeta(double p, double q, double min, double max)
			: this(new RegularizedIncompleteSpanBeta(p, q, min, max))
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <remarks>
		/// 		///	if X~BetaSpanned(min,max,p,q) then
		///	 Y=(X-min)/(max-min) ~ BetaSpanned(0,1,p,q)=Beta(p,q)
		///	accourding to std Beta,
		///  E(Y)= p/(p+q), D(Y)=a * b / ((a + b) * (a + b) * (a + b + 1))
		///  So 
		///  (E(X)-min)/(max-min)=p/(p+q), so E(x)=p/(p+q)*span+min
		///   so E(x)= (aq+bp) / (p+q)

		/// </remarks>

		public double mean()
		{
			return a / (a + b)*span+min;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <remarks>
		///	///	if X~BetaSpanned(min,max,p,q) then
		///	 Y=(X-min)/(max-min) ~ BetaSpanned(0,1,p,q)=Beta(p,q)
		///	accourding to std Beta,
		///   D(Y)=a * b / ((a + b) * (a + b) * (a + b + 1))
		///   So D(Y)=D(X/(p+q)), so D(X)=(p+q)^2 * D(Y)
	
		/// </remarks>
		public double var()
		{
			return a * b / ((a + b) * (a + b) * (a + b + 1)) *(span*span) ;
		}


		static public SpanBeta Create(double a,double b,double min, double max) {

			return new SpanBeta(a, b, min, max);
		
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
				(
					nilnul.math.calculus.BetaFunction.Eval(a, b)
					*
					span
				//Math.Pow(span, a + b - 1)
				)
				;

		}

		public double density2(double x)
		{

			if (x <= min || x >= max)
			{
				return 0;

			}


			return Math.Pow((x - min) / span, (a - 1))
				*
				Math.Pow((max - x) / span, (b - 1))
				/
				(
					nilnul.math.calculus.BetaFunction.Eval(a, b)
					*
					span
				//Math.Pow(span, a + b - 1)
				)
				;

		}
		public double density_spanMerged(double x)
		{

			if (x <= min || x >= max)
			{
				return 0;

			}


			return Math.Pow(x - min , a - 1)
				*
				Math.Pow(max - x , b - 1)
				/
				(
					nilnul.math.calculus.BetaFunction.Eval(a, b)
					*
					
					Math.Pow(span, a + b - 1)
				)
				;

		}

		public double span
		{
			get
			{
				return _regularizedIncompleteSpanBeta.span;
			}

		}

	

		//static public double CumulativeDensity(double a, double b, double min, double max, double x)
		//{

		//	return nilnul.math.calculus.BetaFunction.Incomplete(a, b, (x - min) / (max - min));

		//}


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



		public  Prob probability(double x)
		{
			if (x <= min)
			{
				return Prob.Zero;

			}
			if (x >= max)
			{
				return Prob.One;


			}

			return Prob.CreateByNormalize(_regularizedIncompleteSpanBeta.eval(x));
			;
		}


		public Prob cumulativeProbability(double x)
		{
			if (x <= min)
			{
				return Prob.Zero;

			}
			if (x >= max)
			{
				return Prob.One;


			}

			return Prob.CreateByNormalize(_regularizedIncompleteSpanBeta.eval(x));
			;
		}

		public  double inverse(Prob prob)
		{
			return _regularizedIncompleteSpanBeta.inverse(prob._val);
				
				
		}
	}
}
