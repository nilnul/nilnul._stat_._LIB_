using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;
using nilnul.num.rational;
using nilnul.prob.discrete;
using nilnul.prob.rationalProb.rationalSample;
using nilnul.set;
using nilnul.stat._dist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.stat.dist_.finite_.quotient2quotient_
{
	/// <summary>
	/// a map from quotient to quotient;
	/// </summary>
	public class PmfBySortedDict
		:
		stat.dist_.finite_.cmf_.IQuotient2quotient
	{

		private SortedDictionary<num.quotient_.DenomNonnil,Prob8quotient> _sorted4pmf=new SortedDictionary<DenomNonnil,Prob8quotient>(nilnul.num.quotient_.denomNonnil.Comp.Singleton);

		public SortedDictionary<DenomNonnil,Prob8quotient> sorted4pmf
		{
			get { return _sorted4pmf; }
			private set {
				_sorted4pmf = value; 
			}
		}

		public PmfBySortedDict(
			NotNull2<
				IEnumerable<stat._dist.propense_.Quotient8quotient>
			> samples
		)
		{
			nilnul.stat._dist.prob_.quotients.be_.sum2one.Vow.Unison.vow(samples.val);
			foreach (var item in samples.val)
			{
				_sorted4pmf.Add(item.sample, item.probability); // if there are repetitive keys, xpn is thrown;
			}
		}

		public PmfBySortedDict(
			IEnumerable<stat._dist.propense_.Quotient8quotient> samples
		)
		:this(samples.ToNotNull())
		{
		}

		public PmfBySortedDict(
			List<stat._dist.propense_.Quotient8quotient> samples
		)
		:this((IEnumerable<stat._dist.propense_.Quotient8quotient>)samples)
		{
		}

		public PmfBySortedDict(IEnumerable<(DenomNonnil, DenomNonnil)> enumerable)
			:this(
				 enumerable.Select(
					 x=> new stat._dist.propense_.Quotient8quotient(x)
				)
			)
		{
		}

		public num.quotient_.DenomNonnil mean
		{
			get
			{
				return  nilnul.num.quotient.str._SumX.Sum(
					sorted4pmf.Select(
						c => c.Key * num.quotient_.denomNonnil._RegressionsX.ToDenomNonnil(
								c.Value.en
						)
					)
				);
			}
		}

		public double meanInDouble
		{
			get
			{
				return mean.ToDbl();
			}
		}

		public DenomNonnil min
		{
			get
			{
				return this.sorted4pmf.First().Key;
			}
		}

		public num.quotient_.DenomNonnil max
		{
			get
			{
				return this.sorted4pmf.Last().Key;
			}
		}

		public num.quotient_.DenomNonnil span
		{
			get
			{
				return max - min;
			}
		}
	}
}