using nilnul.math.calculus.betaFunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace nilnul.stat.dist_.borel_.pdfable_.beta_
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
	public class Concave4dbl
		: dist_.borel_.pdfable_.Beta4dbl
		
	{



		public Concave4dbl(NotNull2<nilnul.num.real.ext.func_.binary_.beta._spanned.integrand.incomplete.Regularized4dbl> regularizedIncompleteSpanBeta)
			:base(regularizedIncompleteSpanBeta)
		{
			nilnul.bit.AssertionNullaryFunc.Assert(regularizedIncompleteSpanBeta.val.indicPlus> 1 && regularizedIncompleteSpanBeta.val.indic4complementPlus>1);
			

			
		}

		

		public Concave4dbl( double a, double b, double min, double max)
			: this(new nilnul.num.real.ext.func_.binary_.beta._spanned.integrand.incomplete.Regularized4dbl(a, b, min, max))
		{
			

			

		}

		static public Concave4dbl Create(double a, double b, double min, double max)
		{
			return new Concave4dbl(a, b, min, max);
		
		}



	
	}
}
