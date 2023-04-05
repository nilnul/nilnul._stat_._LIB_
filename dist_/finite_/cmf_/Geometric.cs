using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace nilnul.prob.finite
{
	/// <summary>
	/// the only discrete distribution that Memoryless property:
	/// Memoryless property:Given that X> 2,the r.v. X–2 has same geometric PMF.
	/// 
	/// E(X|X>=2)=2+EX
	/// 
	/// The event occurs x times in row till the compiment occurs.
	/// </summary>
	/// <remarks>
	/// 几何分布（Geometric distribution）是离散型概率分布。其中一种定义为：在n次伯努利试验中，试验k次才得到第一次成功的机率。详细的说，是：前k-1次皆失败，第k次成功的概率。
	/// </remarks>
	public partial class Geometric
	{

		private double _p;

		public Geometric(double p) {
			if (p<0 || p>1)
			{
				throw new Exception();
			}
			_p = p;
		}
		/// <summary>
		/// the probability of the event which will occur in row.
		/// </summary>
		public double p {
			get {
				return _p;
			}
			set{
				_p = value;

			}
		}
	

		/// <summary>
		/// take x times, till get the right one at the x+1 times.
		/// </summary>
		public Func<uint, double> densityFunc {
			get {
				return k => Math.Pow( (1 - p),(k))*p;
			}
		}

		public double cumulativeProb(uint sample) {

			return 1 - Math.Pow(1-p,sample+1);
		
		}

		public double expectation {
			get {
				return 1/p-1;
			}
		}

		public double variance {

			get {
				return (1 - p) / p /p;
			}

		}

		public uint mode {
			get {
				return 0;
			}
		}


	}
}
