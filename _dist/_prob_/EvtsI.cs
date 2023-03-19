using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._prob_
{
	public interface EvtsI<T>
	{
		/// <summary>
		/// the collection of all events, each evt is a set.
		/// </summary>
		T evts { get; }
	}
}
