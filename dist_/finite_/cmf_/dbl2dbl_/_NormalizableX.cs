using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.cmf_.dbl2dbl_
{
	/// <summary>
	/// normalize a started str, each member of which is nonneg, but sum of which is positive;
	/// </summary>
	/// <see cref="_finite.pmf.of_._feasible.IFidence"/>
	static public class _NormalizableX
	{
		static public IEnumerable<double> _Stdize_0normalizable(IEnumerable< double> x) {
			var sum=x.Sum();
			return x.Select( t=>t/sum );
		}
	}
}
