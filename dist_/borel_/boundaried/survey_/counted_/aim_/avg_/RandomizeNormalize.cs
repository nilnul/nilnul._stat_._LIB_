using nilnul.prob.dist._finite.intDouble;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_.boundaried.survey_.counted_.aim_.avg_
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
		/// <param name="sumTarget_nonNeg"></param>
		/// <param name="span"></param>
		/// <returns></returns>
		/// <remarks>
		/// if the sum exceeds, shrink them.
		/// If the sum insuffice, shrink the complement of each.
		///  </remarks>
		static public double[] _Arr(
			int _countOfItems_positive
			,
			double _avgTarget_leBound
			,
			double _upperBound_nonneg
		)
		{
			var random = new Random();
			var r = new double[_countOfItems_positive];

			if (_avgTarget_leBound == 0)
			{
				return r;
			}
			//now avgTgt gt 0. Then spanNoneg gt 0

			for (int i = 0; i < _countOfItems_positive; i++)
			{
				r[i] =  random.NextDouble() * _upperBound_nonneg;
			}

			var sumTargetPositive = _avgTarget_leBound * _countOfItems_positive;

			var currentSum = r.Sum();
			if (currentSum == sumTargetPositive)
			{
				return r;
			}

			if (currentSum > sumTargetPositive)
			{
				var scale = sumTargetPositive / currentSum;

				for (int i = 0; i < _countOfItems_positive; i++)
				{
					r[i] *= scale;
				}
				return r;
			}

			/// if the sum insuffice, shrink the complent of each.
			var maxSum = _upperBound_nonneg * _countOfItems_positive;

			var capacitySumTarget = maxSum - sumTargetPositive; 

			var scale4complement = capacitySumTarget / (maxSum - currentSum);
			for (int i = 0; i < _countOfItems_positive; i++)
			{
				r[i] = _upperBound_nonneg - (_upperBound_nonneg - r[i]) * scale4complement;

			}

			return r;

		}



		static public double[] _Arr(
			int _countOfItems_positive
			,
			double _lowerBorder_nonneg
			,
			double _upperBorder_geLower
			,
			double _avgTarget_InBound
		)
		{
			var anchoredResult = _Arr(
				_countOfItems_positive
				,
				_avgTarget_InBound-_lowerBorder_nonneg
				,
				_upperBorder_geLower-_lowerBorder_nonneg
			);

			for (int i = 0; i < anchoredResult.Length; i++)
			{
				anchoredResult[i] += _lowerBorder_nonneg;
			}
			return anchoredResult;
		}
	}
}