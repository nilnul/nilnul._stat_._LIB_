using nilnul.num.real;
using nilnul.num.real.bound_;
using nilnul.num.real.ext;
using nilnul.num.real_;
using nilnul.stat.dist_.borel_;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;




namespace nilnul.stat.dist_.borel_
{

	public abstract class Pdfable4dblA
		:
		borel_.pdfable_.Invertible4dblI
		,
		_borel_.prob_.OfExt4DblI
		,
		Pdf4dblI
	{
		public abstract double cumulatedProb(double upperBound);
		public abstract double density(double sample);
		public abstract double invert(double cdf);

		public double prob(Interval4dbl sample)
		{
			return cumulatedProb(sample.upper.mark.errable) - cumulatedProb(sample.lower.mark.errable);
		}

		public double prob(Bound4dbl sample)
		{
			return _BorelX.Pmf(this,sample);
			/// as we disregard whether border is closed or not, hence we can only do the following on <see cref="IPdf"/>
			//return cpf(sample.upper.mark.errable) - cpf(sample.lower.mark.errable);

		}

		public abstract double sample();

		//static public theorem.Theorem theorem = new nilnul.math.theorem.Theorem();

		///If Xi ~ Gamma Distribution(ai,b), i=1,2,...
		///Then Sum(Xi) ~ GammDist(Sum(ai),b)
		///

		///if x1~Gamma Dist.(a1,b), x2~GammaDist(a2,b),
		///Then x1/(x1+x2) ~ BetaDist(a1,a2).
		///

		///if xi~chiSquareDist, 
		///Then Sum(Xi)~ Gammadist(n,1)

	}//class
}//namespace
