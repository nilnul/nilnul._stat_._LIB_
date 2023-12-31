using nilnul.prob.dist._finite.intDouble;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_.boundaried.survey_.counted_.aim_.avg_
{
	/// <summary>
	/// shrink or amplify the complement when necessary;
	/// </summary>
	/// 
	static public class _RandomizeThenNormalizeX
	{

		/// <summary>
		/// "if you amplify uniformly, some may exceed bound. if you shrink uniformly, no problem";
		/// </summary>
		/// <param name="_upperBound_nonneg">
		/// upper bound that is nonneg. the lowerbound is 0;
		/// </param>
		/// <param name="_countOfItems_positive">
		/// positive; 
		/// </param>
		/// <param name="_avgAimed_nonneg1leBound">
		/// the aimed avergage. This must be nonneg, and  le <paramref name="_upperBound_nonneg"/>
		/// </param>
		/// <returns></returns>
		/// <remarks>
		/// if the sum exceeds, shrink them.
		/// If the sum insuffice, shrink the complement of each.
		///  </remarks>
		static public double[] _Arr(
			double _upperBound_nonneg
			,
			int _countOfItems_positive
			,
			double _avgAimed_nonneg1leBound
		)
		{
			//var random =  new Random();
			var r = new double[_countOfItems_positive];

			if (_avgAimed_nonneg1leBound == 0)
			{
				return r;
			}



			//now avgTgt gt 0. Then spanNoneg gt 0

			for (int i = 0; i < _countOfItems_positive; i++)
			{
				r[i] = nilnul.stat.dist_.borel_.pdfable_.uniform_.prob.sample_._RandomX.Next4dbl()
					

					* _upperBound_nonneg;
			}

			var sumTargetPositive = _avgAimed_nonneg1leBound * _countOfItems_positive;

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


		/// <summary>
		/// 
		/// </summary>
		/// <param name="_lowerBorder">
		/// can be neg;
		/// </param>
		/// <param name="_upperBorder_geLower"></param>
		/// <param name="_countOfItems_positive"></param>
		/// <param name="_avgTarget_InBound"></param>
		/// <returns></returns>

		static public double[] _Arr(
			double _lowerBorder
			,
			double _upperBorder_geLower
			,
			int _countOfItems_positive
			,
			double _avgTarget_InBound
		)
		{
			var anchoredResult = _Arr(
				_upperBorder_geLower-_lowerBorder
				,
				_countOfItems_positive
				,
				_avgTarget_InBound-_lowerBorder
			);

			for (int i = 0; i < anchoredResult.Length; i++)
			{
				anchoredResult[i] += _lowerBorder;
			}
			return anchoredResult;
		}
	}
}