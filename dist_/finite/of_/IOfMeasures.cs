using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite.of_
{
	/// <summary>
	/// <see cref="_finite.pmf.of_.IMeasure"/>;
	/// </summary>
	/// <remarks>
	/// the measure cannot be the trivia, or the all nils measure.
	/// also the measure cannot be infinite;
	/// </remarks>
	public interface IOfMeasures:metric_.IOfMetricInMeasure
	{
	}
}
