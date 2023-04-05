using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat
{
	/// <summary>
	/// distribution, which is the join from lower "nilnul.collection.set.Field" to "nilnul.prob._prob.Prob"
	/// </summary>
	/// <remarks>
	/// for classic finite distribution, the basic event's prob is enough to describe the distribution;
	/// for <see cref="dist_.IBorel"/>, the density of each basic point is zero; to use only the point's distribution is not enough to describe the distribution; only the meansure of the sigma-field of the real numbers can desribe it; but the sigma filed is infinite , and the logic there is hard to logic; So we ommit that in our overal definition, and defer it to subtype like <see cref="stat.dist_.IFinite"/>, and <see cref="stat.dist_.IBorel"/>;
	/// </remarks>
	public interface DistI<T>
		:
		_dist_.SampleI<T>
		,
		IDist
	{

	}


}
