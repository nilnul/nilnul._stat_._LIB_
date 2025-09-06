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
	///	when the distribution is egal, entropy is the bigest. So uncertainty is a special case of entropy. Hence, we can use entropy to denote uncertainty(egal entropy) and non-egal entropy; we here extended the notion of uncertainty into "entropy"
	///	eg:
	///		a parent comes to the classroom to find one student. The door of the classroom is closed such that the parent cannot look inside.
	///		The teacher is puzzled at what gender the student is; So there is some "unsettledness" (this is different from <seealso cref="nameof(_info.stateful._UncertaintyX)"/>; in fact later we will define this as "Entropy"). When the parent tells the teacher what gender the student is, this "unsettledness" is eliminated. The eliminated "unsettledness" is the same as the info given by the parent.
	///		But the info given by the parent is different in two cases:
	///			when the parent says the student is female, the info is Lb(p), where p is the proportion of female students.
	///			otherwise, Lb(q), where q=1-p
	///		among all parents, p*n would give info of Lb(p), q*n would give info of Lb(q), where n is the count of students. on average, the info is  p*Lb(p)+q*Lb(q).
	///		This averaged info is how much the unsettledness is. We call this amount as "Entropy".
	///		Here the entropy means the teacher's unsettledness(extension of uncertainty) about the students gender.
	///		Knowing the gender(when the entropy is eliminated by the avg info given by the parent), doesnot entail pinpoint the student. But it helps reduce the overall entropy (the teacher's unsettledness about which student is the student to be found). After knowing the gender, the remained entropy would not include the gender's entropy anymore. The remained entropy is about the students' other traits, such as age, placeOfBirth, appearance, etc.
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

		public static double Dbl<TKey1>(
			Finite4dbl<TKey1> item2
			//FiniteDbl<TKey1> item2

		)
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

				finite.of_.occurs_._IndexAsSampleX.Dist_ofAssumeOccurences(_occurrences_assumeSumPositive)
				//finite_._OccurrenceX.Dist_ofAssumeOccurences(_occurrences_assumeSumPositive)

			);
		}


	}
}
