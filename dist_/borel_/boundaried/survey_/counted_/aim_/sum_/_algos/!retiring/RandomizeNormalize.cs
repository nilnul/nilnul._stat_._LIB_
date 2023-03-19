using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.continuum._sample._constrained._boundSum._algos
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete()]
	public partial class RandomizeThenNormalize
	{
		static public Random random = new Random();

		/// <summary>
		/// 			"if you amplify uniformly, some may exceed bound. if you shrink uniformly, no problem";

		/// </summary>
		/// <param name="countOfItems_positive"></param>
		/// <param name="sumTarget_nonNeg"></param>
		/// <param name="bound"></param>
		/// <returns></returns>

		static public double[] Exe(int countOfItems_positive, double sumTarget_nonNeg, double bound)
		{
			var r=new double[countOfItems_positive];


			if (sumTarget_nonNeg==0)
			{
				return r;

			}

			for (int i = 0; i < countOfItems_positive; i++)
			{
				r[i] = random.NextDouble() * bound;
			
			}

			var sum = r.Sum();
			if (sum==sumTarget_nonNeg)
			{
				return r;
			}

			if (sum>sumTarget_nonNeg)
			{
				var scale = sumTarget_nonNeg / r.Sum();

				for (int i = 0; i < countOfItems_positive; i++)
				{
					r[i] *= scale;
				}
				return r;
			
			}


			
			
				var maxSum = bound * countOfItems_positive;
				var capacitySumTarget = maxSum - sumTarget_nonNeg;	//>=0, or exception
				//var capacities = new double[countOfItems_positive];
				//for (int i = 0; i < countOfItems_positive; i++)
				//{
				//	capacities[i] = bound - r[i];
				//}

				var scale1 = capacitySumTarget / (maxSum-sum);
				for (int i = 0; i < countOfItems_positive; i++)
				{
					//capacities[i] *= scale;
					r[i] = bound - (bound-r[i]) * scale1;

				}


			
			return r;




		}

		static public int[] Exe_ceilingByDistribution(int countOfItems_positive, int sumTarget_nonNeg, int bound_nonNeg) {

			var doubleResult = Exe(countOfItems_positive, (double)sumTarget_nonNeg, (double)bound_nonNeg);

			var tails = doubleResult.Select(t => num.real_.floored._TailX.Doub(t)).ToArray();




			throw new NotImplementedException();
		}


	}
}
