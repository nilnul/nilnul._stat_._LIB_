using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;
using nilnul.math.complex.real.set;
using nilnul.math.complex.real.rational.integer;
using nilnul.math.complex.real.rational.integer.set;
namespace nilnul.math.statistics.distribution
{
	/// <summary>
	/// the only discrete distribution that Memoryless property:
	/// Memoryless property:Given that X> 2,the r.v. X–2 has same geometric PMF.
	/// 
	/// E(X|X>=2)=2+EX
	/// 
	/// The event occurs x times in row till the compiment occurs.
	/// </summary>
	public class GeometricDistribution:DiscreteDistribution
	{

		private double _p;

		public GeometricDistribution(Real p) {
			if (domainP.contains(p))
			{
				_p = p;
			}
			else {
				throw new Exception();
			}
		}

		/// <summary>
		/// the probability of the event which will occur in row.
		/// </summary>
		public Real p {
			get {
				return _p;
			}
			set{

				_p = value;
			}
		}
	
		/// <summary>
		/// x=0,1,2,...+inf
		/// 
		/// after taking x times, the next time(i.e., the x+1 time) get the expected result.
		/// So x=0 means after taking 0 times, the first time, we get the right one.
		/// </summary>
		public Func<double, double> densityFunc {
			get {
				return x => p*(1 - p)^x ;
			}
		}

		public double expectation {
			get {
				return 1 / p;
			}
		}

		public 

		

	}
}
