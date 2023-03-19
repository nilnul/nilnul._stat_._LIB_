using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.theorem_.partitional_
{
	public class Dich
	{
		double _hypo;

		/// <summary>
		/// P(E|H)
		///	eg:
		///		supposing a person is librarian, then the likelyhood that he is meek;
		/// </summary>
		double _likelyhoodOverHypothesis;

		/// <summary>
		/// P(E|-H)
		/// eg:
		///		supposing a person is not librarian, the probability that he is meek;
		/// </summary>
		double _likelyhoodOverAntihypothesis;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static  double __Prob_assumesValid(
			double _probOfHypo1likely
			,
			double _hypo
			,
			double _likelyOverContrahypo
		) {
			return _probOfHypo1likely + (1 - _hypo) * _likelyOverContrahypo;
		}

		static public double _Prob_assumesValid(
			double _hypo
			,
			double _likelihoodOverHypo
			,
			double _likelyOverContrahypo
		) {
			return __Prob_assumesValid(
				_hypo * _likelihoodOverHypo
				,
				_hypo
				, _likelyOverContrahypo
			);
		}

		static public double _Prob_assumesValid(
			double _hypo
			,
			double _likelihoodOverHypo
			,
			double _likelyOverContrahypo
			,
			out double _probOfHypo1likely
		) {
			_probOfHypo1likely = _hypo * _likelihoodOverHypo;
			return __Prob_assumesValid(_probOfHypo1likely, _hypo, _likelyOverContrahypo);
			//return _probOfHypo1likely + (1 - _hypo) * _likelyOverContrahypo;
		}



		/// <summary>
		/// P(E)
		///		where E means evidence;
		/// further information about that person;
		/// persons with such information would occupy a probability of all persons;
		/// 
		/// eg:
		///		the person in interest is meek; so meek ones occupy a proportion of all persons;
		/// </summary>
		double likelihood {
			get {
				return _Prob_assumesValid( _hypo, _likelyhoodOverHypothesis,_likelyhoodOverAntihypothesis) ;
			}
		}
	}
}