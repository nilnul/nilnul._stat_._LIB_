using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite
{

	/// <summary>
	/// expectation of info needed to eliminate the uncertainty. or an event will bring us how many info on avg
	/// </summary>
	/// <remarks>
	///	when the distribution is random, entropy is the bigest.
	/// </remarks>
	static public class _EntropyX
	{

		static public double Entropy_ofAssumeDistribution(IEnumerable<double> _dist_sumIsOne)
		{
			return _dist_sumIsOne.Sum(p => prob._InfoDiscountedX._InfoDiscounted_assumeProb(p));
		}

		static public double Entropy_ofAssumeDistribution(params double[] _dist_sumIsOne)
		{
			return Entropy_ofAssumeDistribution((IEnumerable<double>)_dist_sumIsOne);
		}

		public static double Dbl<TKey1>(FiniteDbl<TKey1> item2)
		{
			return Dbl_ofAssumeDistribution(item2.Values.Cast<ProbDbl>());
		}

		public static double Dbl_ofAssumeDistribution(IEnumerable<ProbDbl> enumerable)
		{
			return Entropy_ofAssumeDistribution(enumerable.Select(x => x._val));
		}

		static public double Entropy_ofAssumeOccurrences(params int[] _occurrences_assumeSumPositive)
		{
			return Entropy_ofAssumeDistribution(
				finite_._OccurrenceX.Dist_ofAssumeOccurences(_occurrences_assumeSumPositive)
			);
		}


	}
}
