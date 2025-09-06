using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite.conditional
{
	/// <summary>
	/// expectation of entropy of univariate,  bivariate or multivariate distribution
	/// </summary>
	static public class _BoltzmannX
	{

		static public double Boltzmann<TKey, TKey1>(
			finite.ConditionalInDbl<TKey, TKey1> conditional
		)
		{
			return conditional.Select(
					kv => kv.Value.Item1 * finite._EntropyX.Dbl(kv.Value.Item2)
				).Sum();
		}
	}
}
