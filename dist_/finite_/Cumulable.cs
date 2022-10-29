using nilnul.stat._dist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_
{
	/// <summary>
	/// the samples are comparable.
	/// So we can transform the elements to intervals.
	/// </summary>
	public interface ICumulable
	{
	}

	/// <summary>
	/// at least one el
	/// </summary>
	public class CumulableDbl :
		nilnul.obj.Box_pub<SortedDictionary<double, Prob4dbl>>
		,

		ICumulable
	{
		public CumulableDbl(SortedDictionary<double, Prob4dbl> val) : base(val)
		{

			nilnul.stat._dist.prob.str.be_.nondecrement._VowX.Vow(val.Values);
			nilnul.stat._dist.prob.be_.one._VowX.Vow(val.Values.Last());

		}

		public double cumulativeDensity(double el)
		{
			return this.boxed[el];
		}
	}

	public class CumulableQuotient :
		nilnul.obj.Box_pub<SortedDictionary<nilnul.num.Quotient1, ProbQuotient>>
		,

		ICumulable
	{
		public CumulableQuotient(SortedDictionary<nilnul.num.Quotient1, ProbQuotient> val) : base(val)
		{

			nilnul.stat._dist.prob.str.be_.nondecrement._VowX.Vow(val.Values);
			nilnul.stat._dist.prob.be_.one._VowX.Vow(val.Values.Last());
		}

		public ProbQuotient cumulativeDensity(nilnul.num.Quotient1 el) {
			return this.boxed[el];
		}


	}


}
