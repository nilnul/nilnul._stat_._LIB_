using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat
{
	/// <summary>
	/// dist is a measure.
	/// a measure(
	///		from sigma-field
	///		
	/// ), where the measure of omega is one.
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	public interface IDist
		//:nilnul.collection.family_.field_.sigma.IMeasure
	{
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TSample">
	/// the type of the sample; note:<see cref="_dist.IEvent"/> is not sample, it's a set of samples; according to measure theory, we in fact are dealing with sets, from a family of sets;
	/// </typeparam>
	public interface IDist<TSample> { }
}
