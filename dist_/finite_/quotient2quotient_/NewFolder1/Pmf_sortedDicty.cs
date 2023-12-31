using nilnul.num.rational;
using nilnul.prob.discrete;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.prob.rationalProb.rationalSample
{
	/// <summary>
	/// subtype of <see cref="stat.dist_.finite_.IQuotient2quotient"/>;
	/// a map from quotient to quotient;
	/// </summary>
	/// tODO:
	///		finite distribution
	[Obsolete(nameof(stat.dist_.finite_.quotient2quotient_.PmfBySortedDict))]
	public class Pmf_sortedDict
	{

		private SortedDictionary<Rational_InheritFraction,Prob> _sortedList=new SortedDictionary<Rational_InheritFraction,Prob>(nilnul.num.rational.order.Comparer.Instance);

		/// <summary>
		/// pmf
		/// </summary>
		public SortedDictionary<Rational_InheritFraction,Prob> sortedList
		{
			get { return _sortedList; }
			private set {
				_sortedList = value; 
			}
		}

		public Pmf_sortedDict(
			NotNull2<
				IEnumerable<Event>
			> samples
		)
		{
			nilnul.prob.rationalProb.DensityFunctionX.SumIsOneAssert(samples.val);
			foreach (var item in samples.val)
			{
				_sortedList.Add(item.sample, item.probability);
			}
		}

		public Pmf_sortedDict(
			IEnumerable<Event> samples
		)
		:this(samples.ToNotNull())
		{
		}

		public Rational_InheritFraction mean
		{
			get
			{
				return num.rational.set.SumX.Sum(   sortedList.Select(c => c.Key * c.Value));
			}
		}

		public double meanInDouble
		{
			get
			{
				return nilnul.num.real.double_.SumX.Sum(
					sortedList.Select(c => c.Key.toDouble() * c.Value.toDouble())
				);
			}
		}

		public Rational_InheritFraction min
		{
			get
			{
				return this.sortedList.First().Key;
			}
		}

		public Rational_InheritFraction max
		{
			get
			{
				return this.sortedList.Last().Key;
			}
		}

		public Rational_InheritFraction span
		{
			get
			{
				return max - min;
			}
		}
	}
}