using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.statistics.randomVariable
{


	/// <summary>
	/// Distribution Function is continous, whether it's derivable or not.
	/// While DiscreteRv is not continous; it has jumps and dashs.
	/// </summary>
	public interface  IContinuousRv:IRandomVariable
	{

	}
	public class ContinousRv : IContinuousRv { 

	}
}
