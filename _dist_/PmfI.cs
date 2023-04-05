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
	/// event: sample or interval;
	/// </typeparam>
	/// <remarks>
	/// consider to defer this to <see cref="stat.dist_._finite_"/> and <see cref="stat.dist_._discrete_"/>
	/// </remarks>
	///
	public interface PmfI<TEvent,TMeasure>
		:_PmfI<TEvent,TMeasure>
		where TMeasure:nilnul.num.IReal //according to measure theory;
	{
		//TMeasure prob(TEvent sample);
	}

	public interface PmfI<TSample> { }
}
