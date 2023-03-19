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
	/// p>1,q>1
	/// </remarks>
	public class SpanBetaFirstType
		: SpanBeta
		,
		CdfAndInverseI
	{



		public SpanBetaFirstType(NotNull2<RegularizedIncompleteSpanBeta> regularizedIncompleteSpanBeta)
			:base(regularizedIncompleteSpanBeta)
		{
			nilnul.bit.AssertionNullaryFunc.Assert(regularizedIncompleteSpanBeta.val.a > 1 && regularizedIncompleteSpanBeta.val.b>1);
			

			
		}

		

		public SpanBetaFirstType( double a, double b, double min, double max)
			: this(new RegularizedIncompleteSpanBeta(a, b, min, max))
		{
			

			

		}

		static public SpanBetaFirstType Create(double a, double b, double min, double max)
		{
			return new SpanBetaFirstType(a, b, min, max);
		
		}



	
	}
}
