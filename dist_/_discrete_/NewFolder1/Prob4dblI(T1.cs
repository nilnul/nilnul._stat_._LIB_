using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_._discrete_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TSample">
	/// for discrete, we only need to specifify basicEvent or sample; Note the typePar here means sample, whileas in <see cref="_dist_.Prob4dblI{TEvent}"/>, the typePar means event;
	/// </typeparam>
	///
	[Obsolete()]
	public interface Prob4dblI<TSample>
		:
		_dist_.Prob4dblI<TSample>

		//_dist_.Prob4dblI<TSample>
	{
		//double prob(T sample);
	}
}
