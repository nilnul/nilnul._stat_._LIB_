using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;
using nilnul.num.rational;
using System.Numerics;

namespace nilnul.prob.rationalProb
{
	/// <summary>
	/// prob in quotient;
	/// </summary>
	[Obsolete(nameof(stat._dist.Prob8quotient))]
	public partial class Prob
		:nilnul.num.rational.Rational_InheritFraction
	{
		//public nilnul.num.rational.Rational_InheritFraction val;

		public Prob(nilnul.num.rational.Rational_InheritFraction val)
			:base(val)
		{
			new nilnul.interval.ClosedInterval<Rational_InheritFraction>(0,1).assertContains(val);
			//this.val = val;


		}

		public Prob(nilnul.num.rational.Rational_InheritFraction2 val)
			:this(val.numerator,val.denominator)
		{

		}

		public Prob(
			BigInteger a,
			BigInteger b
			)
			:this(new Rational_InheritFraction(a,b))
		{

		}

		public Prob(int a,int b)
			:this(new Rational_InheritFraction(a,b))
		{
		}

		public Prob(int a)
			:this(a,1)
		{

		}


					

		public doubleProb.Prob toDoubleProb() {

			return ToDoubleProb(this);
		
		}

		

		static public doubleProb.Prob ToDoubleProb(Prob prob) {
			var d = prob.toDouble();
			d = d < 0 ? 0 : d;
			d = d > 1 ? 1 : d;
			return new doubleProb.Prob( d);
		}

		static public Prob FromApproximateDouble(double x,int denominatorLowerBound=1000) {

			if (x<=0)
			{
				return Prob.One;
				
			}
			if (x>=1)
			{
				return Prob.Zero;
				
			}

			var r = nilnul.num.rational.cf.ContinuedFraction2.ToRational_tillDenominator(x, denominatorLowerBound);
			if (r<=0)
			{
				return Prob.Zero;
				
			}
			if (r>1)
			{
				return Prob.One;
				
			}
			return new Prob(r);
		
		}

		static public Prob Zero = new Prob(0);
		static public Prob One = new Prob(1);
		static public Prob Half = new Prob(new Rational_InheritFraction(1,2));


					

	}
}
