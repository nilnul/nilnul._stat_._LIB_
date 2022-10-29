using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.real;

namespace nilnul.statistics.distributions
{
	public partial class ChiSquareDistribution
	{
		/// <summary>
		/// R.A.Fisher proved: when n is big enough, ChiSquareDistribution's upper diving point of alpha=1/2(Za+(2n-1)^.5))^2
	
		/// </summary>
		/// <returns>x:such that p(x,+inf)=input</returns>
		static public double UpperDividingPoint(double upperProb,uint degreesOfFreedom) { 
			if(degreesOfFreedom<46){
				throw new Exception("only when n is big enough can this approximate formula be used.");
			}
			
			return .5 *
				(
					(
						NormalDistribution.UpperDividePoint(upperProb)
						+
						(2*degreesOfFreedom-1).Sqrt()
					).Square()
				);
		}
	}
}
