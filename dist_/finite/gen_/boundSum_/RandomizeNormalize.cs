using nilnul.prob.dist._finite.intDouble;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob_.fininte.gen_.boundSum_
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	public partial class RandomizeThenNormalize
	{
		static public Random random = new Random();

		/// <summary>
		/// "if you amplify uniformly, some may exceed bound. if you shrink uniformly, no problem";

		/// </summary>
		/// <param name="countOfItems_positive"></param>
		/// <param name="sumTarget_nonNeg"></param>
		/// <param name="bound"></param>
		/// <returns></returns>
		/// <remarks>
		/// if the sum exceeds, shrink them.
		/// If the sum insuffice, shrink the complement of each.
		///  </remarks>


		static public double[] Exe(int countOfItems_positive, double sumTarget_nonNeg, double bound)
		{
			var random = new Random();
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

			// if the sum insuffice, shrink the complent of each.
			
			
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countOfItems_positive"></param>
		/// <param name="sumTarget_nonNeg"></param>
		/// <param name="bound_nonNeg"></param>
		/// <returns></returns>
		/// 
		[Obsolete("due to precision problems, this will throw exception",true)]

		static public int[] Exe_ceilingByDistribution(int countOfItems_positive, int sumTarget_nonNeg, int bound_nonNeg) {

			var doubleResult = Exe(countOfItems_positive, (double)sumTarget_nonNeg, (double)bound_nonNeg);

			var tails = doubleResult.Select(t => num.real_.floored._TailX.Doub(t)).ToArray();
			var sum = tails.Sum();
			var epsilon=0.0001d / sumTarget_nonNeg;
			var distributed = sum;
			while (distributed>epsilon)
			{
				sum = tails.Sum();		
				var dict = new SortedDictionary<int, nilnul.prob._prob.InDouble>();

				for (int i = 0; i < tails.Length; i++)
				{
					if (tails[i]!=0)
					{
						dict.Add(i, new nilnul.prob._prob.InDouble( tails[i]/sum));
					}
				}



				var cdfPacked = Cdf.Packed.Create( new nilnul.prob.dist._finite.intDouble.Pmf.Packed(dict));


				var selected=cdfPacked.randomSelect();

				doubleResult[selected] = Math.Ceiling(doubleResult[selected]);
			
				tails = doubleResult.Select(t => num.real_.floored._TailX.Doub(t)).ToArray();
				distributed--;

			}

			return doubleResult.Select(t=>(int)Math.Floor(t)).ToArray();



			throw new NotImplementedException();
		}


	}
}
