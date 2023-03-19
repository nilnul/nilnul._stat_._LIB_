using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.fit
{
	/// <summary>
	/// the standard distribution
	/// </summary>
	/// <remarks>
	/// http://stats.stackexchange.com/questions/12232/calculating-the-parameters-of-a-beta-distribution-using-the-mean-and-variance
	/// 
	/// for standard beta distribution,
	/// 
	/// due to:
	///		mean= a / (a + b)
	///		var =a * b / ((a + b) * (a + b) * (a + b + 1))
	///	solve to get:
	///	 p=( (1-mean)/var-1/mean )*mean^2;
	///	 q=p*(1/mean-1)
	///	
	/// </remarks>
	public partial class Beta
	{
		static public Tuple<double, double> ComputeParas(
			IEnumerable<double> samples	
		) {
			var meanVar = Observations.GetMeanVar(samples);
			var mean=meanVar.Item1;
			var var=meanVar.Item2;

			var p = ((1 - mean) / var - 1 / mean) / Math.Pow(mean,2);
			var q = p * (1 / mean - 1);
			return new Tuple<double, double>(p, q);
		
		}


	}
}
