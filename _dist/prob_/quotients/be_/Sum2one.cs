using nilnul.set;
using nilnul.stat._dist.propense_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.stat._dist.prob_.quotients.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// tODO: finitedistribution
	
	public class Sum2one
		:
		nilnul.obj.BeI_ofIn<IEnumerable<Prob8quotient>>
		,
		nilnul.obj.BeI1<IEnumerable<Prob8quotient>>


	{

		//static public nilnul.bit.Predicate<IEnumerable<Prob8quotient>> SumIsOnePredicate = new bit.Predicate<IEnumerable<Prob8quotient>>(SumIsOne);

		static public bool SumIsOne(IEnumerable<Prob8quotient> probs)
		{
			return nilnul.num.quotient.str._SumX.Sum(probs.Select(p=>p.en)) == 1;

		}


		static public bool SumIsOne<T>(IEnumerable<Prob8quotient<T>> events)
		{
			return SumIsOne( events.Select(c => c.probabilityNotNull));

		}

		static public void SumIsOneAssert<T>(IEnumerable<Prob8quotient<T>> events)
		{
			 nilnul.bit.Assert.True(SumIsOne(events));

		}

		public bool be(in IEnumerable<Prob8quotient> val)
		{
			return nilnul.num.quotient.str._SumX.Sum(val.Select(p => p.en)) == 1;
		}

		public bool be(IEnumerable<Prob8quotient> obj)
		{
			return be(in obj);
		}

		static public Sum2one Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Sum2one>.Unison;
			}
		}

	}
}
