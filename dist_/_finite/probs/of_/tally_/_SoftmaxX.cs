using nilnul.stat.dist_._finite.probs.of_.fidence_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_._finite.probs.of_.tally_
{
	/// <summary>
	/// <see cref="stat.dist_._finite.probs.of_.ITally"/>
	/// </summary>
	static public class _SoftmaxX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public IEnumerable<double> _Softmax_0started(IEnumerable< double> x) {
			return _NormalizableX._Stdize_0normalizable(
				x.Select(
					t => Math.Exp(t)
				)
			);
		}
	}
}
