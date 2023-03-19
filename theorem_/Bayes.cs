using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.theorem_
{
	 class Bayes
	{
		/// <summary>
		/// P(H)
		///		where H means hypothesis;
		///	eg:
		///		P(a person is a librarian, supposing that that person is either librarian or farmer)
		/// </summary>
		double prior;

		/// <summary>
		/// P(E|H)
		///	eg:
		///		supposing a person is librarian, then the likelyhood that he is meek;
		/// </summary>
		double likelyhoodOverHypothesis;

		/// <summary>
		/// P(E|-H)
		/// eg:
		///		supposing a person is not librarian, the probability that he is meek;
		/// </summary>
		double likelyhoodOverAntihypothesis;

		/// <summary>
		/// P(E)
		///		where E means evidence;
		/// further information about that person;
		/// persons with such information would occupy a probability of all persons;
		/// 
		/// eg:
		///		the person in interest is meek; so meek ones occupy a proportion of all persons;
		/// </summary>
		double evidence {
			get {
				return partitional_.Dich._Prob_assumesValid(prior,likelyhoodOverHypothesis,likelyhoodOverAntihypothesis) ;
			}
		}

		public double posterior() {

			var evidence = partitional_.Dich._Prob_assumesValid(
				prior,likelyhoodOverHypothesis,likelyhoodOverAntihypothesis, out double hypoLikely
			);
			return hypoLikely / evidence;
		}

	}
}
