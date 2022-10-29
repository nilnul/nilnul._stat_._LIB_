using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat._dist
{
	/// <summary>
	/// a str of prbs. the sum is not necessarily one.
	/// due to the str is finite, this can only be used as the measure for finite omega (in case that the sum is one)
	/// </summary>
	public interface IProbs
	{
	}
	public interface Probs4dblI
		:
		nilnul.ObjsI3<Prob4dbl>
		,
		IProbs
	{ }

	public class Probs4dbl
		:
		nilnul.Objs_arr<Prob4dbl>
		,
		Probs4dblI
	{
		public Probs4dbl(Prob4dbl[] val) : base(val)
		{
		}

		public Probs4dbl(IEnumerable<Prob4dbl> tail) : base(tail)
		{
		}
	}
}
