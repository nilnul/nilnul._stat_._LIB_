using nilnul.obj.str;
using nilnul.stat._dist;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.stat.dist_.finite_.cmf_._binomial
{
	/// <summary>
	/// at least one el
	/// </summary>
	public class Cmf4dbl :
		nilnul.obj.Box_pub<SortedDictionary<uint, Prob4dbl>>
		,

		ICmfable
	{
		public Cmf4dbl(SortedDictionary<uint, Prob4dbl> val) : base(val)
		{

			nilnul.stat._dist.prob.str.be_.nondecrement._VowX.Vow(val.Values);
			nilnul.stat._dist.prob.be_.one._VowX.Vow(val.Values.Last());

		}

		static public SortedDictionary<uint, Prob4dbl> SortedDict(
SortedDictionary<uint, double> val
		) {
			var r = new SortedDictionary<uint, Prob4dbl>(

			);
			val.Each(
				X=> r.Add( X.Key, new Prob4dbl(X.Value) )
			);
			return r;
		}

		public Cmf4dbl(SortedDictionary<uint, double> val) : this(
			SortedDict(val)
		)
		{

			

		}

		public double cmf(uint el)
		{
			return this.boxed[el];
		}
	}


}
