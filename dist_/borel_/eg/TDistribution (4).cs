using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real.set;
using IntegerSet=nilnul.math.complex.real.rational.integer.set.Set;
using ICInterval=nilnul.math.complex.real.rational.integer.set.ClosedInterval;
using IPI=nilnul.math.complex.real.rational.integer.PositiveInfinite;
using IntPosInf = nilnul.math.complex.real.rational.integer.PositiveInfinite;
using IntInterval = nilnul.math.complex.real.rational.integer.set.Interval;
using RealSet=nilnul.math.complex.real.set.Set;
using RealInterval = nilnul.math.complex.real.set.Interval;
using RealInf = nilnul.math.complex.real.Infinite;
using nilnul.math.complex.real.rational.integer;
using nilnul.math.complex.real;
using nilnul.math.complex.real.function;
using IntInf=nilnul.math.complex.real.rational.integer.IntegerInfinite;

using nilnul.math.calculus;
using nilnul.math.statistics.distribution;

namespace nilnul.math.statistics.distribution
{
	public partial class TDistribution:DistributionFunction
	{

		public Integer degrees { 
		}


		public TDistribution(Integer degrees ) { 
			if(DegreesDomain.contains(degrees)){
				this.degrees = degrees;


			}else{
				throw new Exception();
			}
		}

		public NonnegativeReal density(Real x) {
			if (Domain.contains(x))
			{
				return
					new GammaFunction((degrees+1)/2) 
					/
					(
						(Pi.Instance * degrees).Power(1/2) * new GammaFunction(degrees/2)
					)
					*
					(1+ x.Power(2)/degrees).Power(-(degrees+1)/2)
					;
			}
			else {
				return 0;
			}

		}

		/// <summary>
		/// At which the probability is not trivia.
		/// </summary>
		static public RealSet Domain{
			get{
				return new RealInterval(new RealInf(true), new RealInf(false));
			}
		}

		static public IntegerSet DegreesDomain{
			get{
				return new IntInterval(1,IPI.Instance,IntInterval.Type.leftClosedRightOpen);
			}

		}
		/// <summary>
		/// Note:for small degrees, t-distribution has big difference with normal distribution.
		/// </summary>
		static public Function[][] Equations = new Function[][]{
			new Function[]{
				new StudentTDistribution(IntInf.Positive),
				new Normal()
			}
		};

	}//class

}//namespace
