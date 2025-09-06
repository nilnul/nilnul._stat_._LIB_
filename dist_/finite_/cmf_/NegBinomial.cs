using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.cmf_
{
	/// <summary>
	/// number of trials, till k successes.
	/// </summary>
	/// alias:
	///		geometric
	///		
	public class NegBinomial

	{
		private nilnul.num.integer_.int_.Positive _successes;

		public nilnul.num.integer_.int_.Positive successes
		{
			get { return _successes; }
			set { _successes = value; }
		}

		private nilnul.num.real_.positive_.LeOneDbl _prob;

		public nilnul.num.real_.positive_.LeOneDbl prob4bernouli
		{
			get { return _prob; }
			set { _prob = value; }
		}

		 double _probPowCached;

		public NegBinomial(
			nilnul.num.integer_.int_.Positive success
			,
			//nilnul.stat._dist.prob_.
			nilnul.num.real_.positive_.LeOneDbl prob
		)
		{
			_successes = success;
			_prob = prob;
			_probPowCached = Math.Pow(prob.ee, success.eeByRef);
		}

		double prob(
			int x
		) {
			return (double) (nilnul.num.co_.ge._CombinateX._assumeNumGe(
				x-1,_successes.eeByRef-1
			) )* Math.Pow(1-_prob.ee, _probPowCached  );
		}

	}
}
