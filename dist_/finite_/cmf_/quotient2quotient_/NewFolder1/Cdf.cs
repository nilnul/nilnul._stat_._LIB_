using nilnul.prob.rationalProb.rationalSample;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LessThan = nilnul.num.rational.order.LessThan;

namespace nilnul.prob.rationalProb.rationalSample
{
	/// <summary>
	/// a dist (map event to prob).
	/// </summary>
	///
	[Obsolete()]
	public  class Cdf
	{

		private NotNull<CumulativeDensitySequence> _cumulativeDensitySequence;

		public NotNull<CumulativeDensitySequence> cumulativeDensitySequence
		{
			get { return _cumulativeDensitySequence; }
			set { _cumulativeDensitySequence = value; }
		}

		private NotNull<LessThan.SortedSet> _samples;

		/// <summary>
		/// Each sample is a quotient;
		/// </summary>
		public NotNull<LessThan.SortedSet> samples
		{
			get { return _samples; }
			set { _samples = value; }
		}

		public bool validate(
			NotNull<CumulativeDensitySequence> cumulativeDensitySequence
			,
			NotNull<LessThan.SortedSet> samples
			)
		{
			return cumulativeDensitySequence.val.cumulativeDensities.list.Count() == samples.val.Count();
		}

		public void binaryAssert(
			NotNull<CumulativeDensitySequence> cumulativeDensitySequence
			,
			NotNull<LessThan.SortedSet> samples)
		{

			if (!validate(cumulativeDensitySequence, samples))
			{
				throw new ArgumentException();
			}
		}

		public Cdf(
			NotNull<CumulativeDensitySequence> cumulativeDensitySequence
			,
			NotNull<LessThan.SortedSet> samples

		)
		{
			binaryAssert(cumulativeDensitySequence, samples);
			this.cumulativeDensitySequence = cumulativeDensitySequence;
			this.samples = samples;
		}
	}
}