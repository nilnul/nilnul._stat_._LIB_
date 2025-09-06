using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.cmf_.dbl2dbl_
{
	/// <summary>
	/// <see cref="stat.dist_._finite.probs.of_.ITally"/>
	/// </summary>
	///
	[Obsolete(nameof(nilnul.stat.dist_._finite.probs.of_.tally_._SoftmaxX))]
	static public class _SoftmaxX
	{

		static public IEnumerable<double> _Softmax_0started(IEnumerable< double> x) {
			return _NormalizableX._Stdize_0normalizable(
				x.Select(
					t => Math.Exp(t)
				)
			);
		}
	}
}
