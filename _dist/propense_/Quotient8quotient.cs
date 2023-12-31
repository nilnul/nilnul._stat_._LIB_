using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;
using nilnul.num.rational;
using nilnul.stat._dist;
using nilnul.stat._dist.propense_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat._dist.propense_
{
	/// <summary>
	/// a vista of quotient sample and quotient prob;
	/// </summary>
	public class Quotient8quotient
		:
		Prob8quotient<num.quotient_.DenomNonnil>
		,
		stat._dist.IMap
		,
		nilnul.stat._dist.propense_.IQuotient2quotient

	{

		public Quotient8quotient(NotNull2<DenomNonnil> sample
			
			,
			NotNull2<_dist.Prob8quotient> prob
			)
			:base(sample,prob)
		{
		}
					

		public Quotient8quotient(
			DenomNonnil sample,
			_dist.Prob8quotient prob
		)
			:base(sample,prob)
			
			
		{

		}

		public Quotient8quotient(
						DenomNonnil sample,

						DenomNonnil prob

			)
			:base(sample,new _dist.Prob8quotient(prob))
		{
		}
		public Quotient8quotient((DenomNonnil, DenomNonnil) x):this(x.Item1,x.Item2)
		{
		}

		public Quotient8quotient(DenomNonnil min, DenomNonnilI eeByRef):this(
			min,eeByRef.ToImpl()
		)
		{
		}
	}
}
