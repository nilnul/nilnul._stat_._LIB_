using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.prob.rationalMeasure
{
	public class SampleCountPositive
		:SampleCountPositive<Rational_InheritFraction>
	{
		

	


		public SampleCountPositive(NotNull2<R> sample, NotNull2<nilnul.num.natural.PositiveNatural_inheritNatural> count)
			:base(sample,count)
		{
			
		}

		public SampleCountPositive(R sample,PositiveNatural_inheritNatural count)
			:this(NotNullX.ToNotNull(sample),NotNullX.ToNotNull(count))
		{
		}

		public SampleCountPositive(R sample, PositiveNatural_inheritNatural2 count)
			: this(NotNullX.ToNotNull(sample), NotNullX.ToNotNull(new PositiveNatural_inheritNatural( count.val)))
		{
		}

		public SampleCountPositive(R sample, int count)
			: this((sample), new PositiveNatural_inheritNatural(count))
		{
		}
					

		public class EqualityComparer :
	IEqualityComparer<SampleCountPositive>
		{


			public bool Equals(SampleCountPositive x, SampleCountPositive y)
			{
				return object.Equals(x.sample.val, y.sample.val);
			}

			public int GetHashCode(SampleCountPositive obj)
			{
				return obj.sample.val.GetHashCode();
			}


		}




	}

}
