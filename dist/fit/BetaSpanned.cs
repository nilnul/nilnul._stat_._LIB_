using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.fit
{
	public partial class BetaSpanned
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="samples"></param>
		/// <returns></returns>
		/// <remarks>
		///	if X~BetaSpanned(min,max,p,q) then
		///	 Y=(X-min)/(max-min) ~ BetaSpanned(0,1,p,q)=Beta(p,q)
		///	accourding to std Beta,
		///  E(Y)= p/(p+q), D(Y)=a * b / ((a + b) * (a + b) * (a + b + 1))
		///  So 
		///  (E(X)-min)/(max-min)=p/(p+q), so E(x)=p/(p+q)*span+min
		///   so E(x)= (aq+bp) / (p+q)
		///   D(Y)=D(X)/span^2, so D(X)=D(Y)*span^2
		///  
		/// </remarks>
		static public Tuple<double, double> ComputeParas(
			IEnumerable<double> samples
		)
		{
			var min = samples.Min();
			var max = samples.Max();
			var span = max - min;
			var meanVar = Observations.GetMeanVar(samples);
			var mean = meanVar.Item1;
			var var = meanVar.Item2;

			var lambda=(mean-min)*(max-mean)/var -1;





			var p = lambda * (mean - min) / span;	
			var q = lambda*(max-min)/span;
			return new Tuple<double, double>(p, q);

		}
	}
}
