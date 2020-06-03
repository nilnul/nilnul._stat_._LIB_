using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_
{

	/// <summary>
	/// a prob on finite set such that we can measure the elements in the set.
	/// </summary>
	public class FiniteDbl<T>
		: Dictionary<T, ProbDbl>

	{

		public FiniteDbl(Dictionary<T, ProbDbl> dict)
			: base(dict)
		{
			nilnul.stat.prob.str.be_.totalOne._VowX.Vow(this.Values);
		}

		static public FiniteDbl<T> Create( IEqualityComparer<T> eq, IEnumerable<KeyValuePair<T, ProbDbl>> enumerable)
		{
			var r = new
			 Dictionary<T, ProbDbl>(eq);
			nilnul.obj.DictX.AddRange(
				r,
				enumerable
			);
			return new FiniteDbl<T>(r);
		}
	}

}