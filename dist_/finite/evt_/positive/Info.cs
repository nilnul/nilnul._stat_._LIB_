
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite.evt_.positive
{
	/// <summary>
	/// observing the event has happened, by :
	///		seeing it self, eg: see the result of a coin toss by oneself's eyes
	///		told by others, eg:
	///			others watched the result of a coint toss, and forward that result as a message to you.
	///			weather report
	/// </summary>
	static public class _InfoX
	{
		/// <summary>
		/// when observing by oneself or told by others one evt has happend, the info one get is:
		/// </summary>
		/// <param name="_prob_assumePositive"></param>
		/// <returns></returns>
		static public double _Info_evtProbAssumePositve(double _prob_assumePositive) {
			return nilnul.num.real_.positive._LbX.Lb(1 / _prob_assumePositive);
		}
	}
}
