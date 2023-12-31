using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat._dist_
{
	/// <summary>
	/// probability for an event;
	/// note for <see cref="dist_.IBorel"/>, the event is an interval;
	/// </summary>
	/// <typeparam name="TEvent">
	/// event: sample(for discrete) or interval(for borel);
	/// </typeparam>
	/// <remarks>
	/// consider to defer this to <see cref="stat.dist_._finite_"/> and <see cref="stat.dist_._discrete_"/>
	/// </remarks>
	/// <see cref="_dist_.Pmf4dblI{T}"/>
	[Obsolete("this can only be applied to classis|discrete distributions; for borel, the prob of any point is nil, and we need interval, not the sample,  as the event;",true)]
	public interface Prob4dblI<TEvent>
		:_PmfI<TEvent,double>
	{
		//double prob(TEvent sample);
	}


}
