

using System;
//using MathNet.Numerics.RandomSources;

namespace nilnul.prob.continuum.eg
{
	/// <summary>
	/// Provides generation of cauchy distributed random numbers.
	/// </summary>
	/// <remarks>
	/// The implementation of the <see cref="CauchyLorentzDistribution"/> type bases upon information presented on
	///   <a href="http://en.wikipedia.org/wiki/Cauchy_distribution">Wikipedia - Cauchy distribution</a> and
	///   <a href="http://www.xycoon.com/cauchy2p_random.htm">Xycoon - Cauchy Distribution</a>.
	/// </remarks>
	///The Cauchy distribution is often used in statistics as the canonical example of a "pathological" distribution since both its mean and its variance are undefined. 
	public sealed class Cauchy  
    {
		static public double Pdf(double x) {

			return 1d / (Math.PI* (1 + x * x));

		}

		static public double Cdf(double x) {
			return 1d / (Math.PI) * Math.Atan(x) + .5d;
		}
       
    }
}
