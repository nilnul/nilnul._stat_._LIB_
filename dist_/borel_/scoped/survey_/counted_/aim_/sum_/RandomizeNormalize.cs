using nilnul.prob.dist._finite.intDouble;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_.boundaried.survey_.counted.sum_
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	static public class _RandomizeThenNormalizeX
	{

		/// <summary>
		/// "if you amplify uniformly, some may exceed bound. if you shrink uniformly, no problem";
		/// </summary>
		/// <param name="_countOfItems_positive"></param>
		/// <param name="_sumTarget_leBoundSum"></param>
		/// <param name="_bound_nonNeg"></param>
		/// <returns></returns>
		/// <remarks>
		/// if the sum exceeds, shrink them.
		/// If the sum insuffice, shrink the complement of each.
		///  </remarks>
		static public double[] _Arr(
			int _countOfItems_positive
			,
			double _bound_nonNeg
			,
			double _sumTarget_leBoundSum
		)
		{
			var random = new Random();
			var r = new double[_countOfItems_positive];

			if (_sumTarget_leBoundSum == 0)
			{
				return r;
			}

			for (int i = 0; i < _countOfItems_positive; i++)
			{
				r[i] = random.NextDouble() * _bound_nonNeg;

			}

			var sum = r.Sum();
			if (sum == _sumTarget_leBoundSum)
			{
				return r;
			}

			if (sum > _sumTarget_leBoundSum)
			{
				var scale = _sumTarget_leBoundSum / r.Sum();

				for (int i = 0; i < _countOfItems_positive; i++)
				{
					r[i] *= scale;
				}
				return r;
			}

			/// if the sum insuffice, shrink the complent of each.
			var maxSum = _bound_nonNeg * _countOfItems_positive;
			var capacitySumTarget = maxSum - _sumTarget_leBoundSum; 

			var scale4complement = capacitySumTarget / (maxSum - sum);
			for (int i = 0; i < _countOfItems_positive; i++)
			{
				r[i] = _bound_nonNeg - (_bound_nonNeg - r[i]) * scale4complement;

			}

			return r;
		}
	}
}