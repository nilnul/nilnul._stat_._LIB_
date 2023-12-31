using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat._dist.propense_
{
	public class Prob8quotient<TSample>
		:
		stat._dist.IPropense
	{
		private TSample _sample;

		public TSample sample
		{
			get { return _sample; }
			set
			{
				_sample = NotNull2<TSample>.EnsureNotNull(value);
			}
		}

		private NotNull2<_dist.Prob8quotient> _probability;

		public NotNull2<_dist.Prob8quotient> probability
		{
			get { return _probability; }
			set { _probability = value; }
		}



		public _dist.Prob8quotient probabilityNotNull
		{
			get { return _probability; }

		}




		public Prob8quotient(
			NotNull2<TSample> sample,
			NotNull2<_dist.Prob8quotient> prob

		)
		{


			_sample = sample;
			_probability = prob;

		}

		public Prob8quotient(
			TSample sample
			,
			_dist.Prob8quotient prob
		)
			: this(NotNull2<TSample>.ToNotNull(sample), NotNull2<_dist.Prob8quotient>.ToNotNull(prob))
		{
		}

		public Prob8quotient(
			TSample sample
			,
			nilnul.num.rational.Rational_InheritFraction2 prob

		)
			: this(sample, new _dist.Prob8quotient(prob.numerator, prob.denominatorAsBigInt))
		{
		}
		public Prob8quotient(
			TSample sample
			,
			nilnul.num.quotient_.DenomNonnil prob

		)
			: this(sample, new _dist.Prob8quotient(prob.numerator, prob.denominator))
		{
		}


		/// <summary>
		/// 
		/// </summary>
		/// moved to nilnul.obj;

		public class EqualityComparer :

			IEqualityComparer<Prob8quotient<TSample>>


		{


			public bool Equals(Prob8quotient<TSample> x, Prob8quotient<TSample> y)
			{
				return object.Equals(x.sample, y.sample);
			}

			public int GetHashCode(Prob8quotient<TSample> obj)
			{
				return obj.sample.GetHashCode();
			}


		}


	}
}
