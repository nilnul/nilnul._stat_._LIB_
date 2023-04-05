using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat._dist.evt_
{

	/// as we define a <see cref="IDist{ThisAssembly}"/>, we need to specifiy
	/// <summary>
	/// Subset of sampleSpace that contains only one point.
	/// for <see cref="dist_.IBorel"/>, the basic event is an interval;
	/// </summary>
	/// 
	/// alias:
	///		simple
	///		basic
	public interface IBasicEvent:IEvent
	{

	}
}
