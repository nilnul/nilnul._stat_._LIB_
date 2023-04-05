using nilnul.stat._dist;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.stat.dist_.finite_.cmf_
{
	/// <summary>
	/// at least one el
	/// </summary>
	public class Dbl2dbl :
		nilnul.obj.Box_pub<SortedDictionary<double, Prob4dbl>>
		,

		ICmfable
	{
		public Dbl2dbl(SortedDictionary<double, Prob4dbl> val) : base(val)
		{

			nilnul.stat._dist.prob.str.be_.nondecrement._VowX.Vow(val.Values);
			nilnul.stat._dist.prob.be_.one._VowX.Vow(val.Values.Last());

		}

		public double cumulativeDensity(double el)
		{
			return this.boxed[el];
		}
	}


}
