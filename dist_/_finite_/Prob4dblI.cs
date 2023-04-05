using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_._finite_
{
	/// <summary>
	/// probability for an event;
	/// note for <see cref="dist_.IBorel"/>, the event is an interval;
	/// </summary>
	/// <typeparam name="TSample">
	/// for discrete, we only need to specifify basicEvent or sample; Note the typePar here means sample, whileas in <see cref="_dist_.Prob4dblI{TEvent}"/>, the typePar means event;
	/// </typeparam>
	/// <remarks>
	/// consider to defer this to <see cref="stat.dist_._finite_"/> and <see cref="stat.dist_._discrete_"/>;
	/// for nonsample, the probability is xpn; for sample, some probability might be nil;
	/// </remarks>
	/// 
	public interface Prob4dblI<TSample>
		:_dist_.Prob4dblI<TSample>
	{
		//	double prob(TEvent sample);
	}
}
