using nilnul.math.calculus.betaFunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.prob.rationalProb.rationalSample.cdf.contains
{


	/// <summary>
	/// if u~ beta dist. then U = (m / n)X / [1 + (m / n)X] ~ F distr.
	/// f(U) du.
	/// 
	///If    B~B(m/2,n/2), then F=nB/m(1-B)     ~ F(m,n)

	/// </summary>
	/// <remarks>
	/// p>1,q>1
	/// </remarks>
	public class SpanBetaFirstType
		: 
		SpanBeta,

		CdfAndInverseI
	{


		//public R a
		//{
		//	get {
		//		return R.ToRational( _regularizedIncompleteSpanBeta.a);
		//	}
			
		//}
		//public R b
		//{
		//	get {
		//		return R.ToRational( _regularizedIncompleteSpanBeta.b);
		//	}
			
		//}

		//public R min {
		//	get {
		//		return R.ToRational( _regularizedIncompleteSpanBeta.min);
		//	}
		//}
		//public R max {
		//	get {
		//		return R.ToRational( _regularizedIncompleteSpanBeta.max);
		//	}
		//}

		//private nilnul.math.calculus.betaFunc.RegularizedIncompleteSpanBeta _regularizedIncompleteSpanBeta;

		//public RegularizedIncompleteSpanBeta regularizedIncompleteSpanBeta
		//{
		//	get { return _regularizedIncompleteSpanBeta; }
		//	set
		//	{

		//		_regularizedIncompleteSpanBeta = value.EnsureNotNull();

		//	}
		//}



		public SpanBetaFirstType(NotNull2<RegularizedIncompleteSpanBeta> regularizedIncompleteSpanBeta)
			:base(regularizedIncompleteSpanBeta)
		{
			nilnul.bit.AssertionNullaryFunc.Assert(regularizedIncompleteSpanBeta.val.a > 1 && regularizedIncompleteSpanBeta.val.b>1);
			

			
		}

		//public void ctor(
		//	double a,
		//	double b,
		//	double min,
		//	double max

		//)
		//{

		//	if (a <= 0 || b <= 0)
		//	{
		//		throw new Exception();
		//	}

		//	this.a = a;
		//	this.b = b;

		//	if (min >= max)
		//	{
		//		throw new Exception();

		//	}

		//	this.min = min;
		//	this.max = max;
		//}


		public SpanBetaFirstType( R a, R b, R min, R max)
			: this(new RegularizedIncompleteSpanBeta(a.toDouble(), b.toDouble(), min.toDouble(), max.toDouble()))
		{
			

			

			

		}

	


		static public SpanBetaFirstType Create(R a,R b,R min, R max) {

			return new SpanBetaFirstType(a, b, min, max);
		
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
		//	return nilnul.math.calculus.BetaFunction.Density2(a, b, x) / nilnul.math.calculus.BetaFunction.Eval(a, b);

		//}



	}
}
