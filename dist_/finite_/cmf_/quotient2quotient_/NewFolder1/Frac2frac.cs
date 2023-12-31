using nilnul.stat._dist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.cmf_
{

	public class Frac2frac :
		nilnul.obj.Box_pub<SortedDictionary<nilnul.num.Quotient1, Prob8quotient>>
		,

		ICmfable
	{
		public Frac2frac(SortedDictionary<nilnul.num.Quotient1, Prob8quotient> val) : base(val)
		{

			nilnul.stat._dist.prob.str.be_.nondecrement._VowX.Vow(val.Values);
			nilnul.stat._dist.prob.be_.one._VowX.Vow(val.Values.Last());
		}

		public Prob8quotient cumulativeDensity(nilnul.num.Quotient1 el) {
			return this.boxed[el];
		}


	}


}
