using nilnul.num;
using nilnul.obj.str;
using nilnul.stat._dist;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.stat.dist_.finite_.cmf_._binomial
{
	/// <summary>
	/// at least one el
	/// </summary>
	public class Cmf4frac :
		nilnul.obj.Box_pub<SortedDictionary<uint, Prob8quotient>>
		,

		ICmfable
	{
		public Cmf4frac(SortedDictionary<uint, Prob8quotient> val) : base(val)
		{

			nilnul.stat._dist.prob.str.be_.nondecrement._VowX.Vow(val.Values);
			nilnul.stat._dist.prob.be_.one._VowX.Vow(val.Values.Last());

		}
		public Cmf4frac(SortedDictionary<uint, Quotient1> sortedDict):this(
			_Cmf4fracX.SortedDict(sortedDict)
		)
		{
		}

		


		public Cmf4frac(SortedDictionary<uint, double> val) : this(
			_Cmf4fracX.SortedDict(val)
		)
		{

			

		}


		public Prob8quotient cmf(uint el)
		{
			return this.boxed[el];
		}
	}


}
