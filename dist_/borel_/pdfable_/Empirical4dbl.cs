using nilnul.num.quotient_;
using nilnul.num.rational;
using nilnul.num.real.ext;
using nilnul.stat._dist;
using nilnul.stat.dist_.borel_.pdfable_._empiric.cmf.be_.nil4first.vow;
using nilnul.stat.dist_.finite_.cmf_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdfable_
{

	/// <summary>
	/// from discrete measure to continuous measure 
	/// </summary>
	public class Empirical4dbl
	   : nilnul.obj.Box1<
		   _empiric.cmf.be_.nil4first.vow.Ee4dbl
	   //  nilnul.stat.dist_.finite_.cmf_.Dbl2dbl
	   >
		,
		borel_.Pdf4dblI
	{
		public Empirical4dbl(Ee4dbl val) : base(val)
		{
		}

		public Empirical4dbl(Dbl2dbl val) : this(new Ee4dbl(val))
		{
		}

		public Empirical4dbl(SortedDictionary<double, double> sortedDictionary)
		:this(
			 new Dbl2dbl(sortedDictionary)
		)
		{
		}

		public double min { get {
				return boxed.eeByRef.min;
		} }
		public double max { get {
				return boxed.eeByRef.max;
		} }
		public double span { get {
				return boxed.eeByRef.span;
		} }

		/// <summary>
		/// we need this to be continous and piecewise derivable;
		/// so the first sample's prob shall be nil;
		/// </summary>
		/// <param name="el"></param>
		/// <returns></returns>
		public double cumulatedProb(double el)
		{
			var indexRange = nilnul.num.real.sortie._FindX._IndexRange(
				this.boxed.eeByRef.sortedDict.Keys,
				el
			);

			if (indexRange.Item1 is null)
			{
				return 0;
			}
			if (indexRange.Item2 is null)
			{
				return 1;
			}

			var lower = this.boxed.eeByRef.sortedDict.Keys.ElementAt(
				(int)(indexRange.Item1)
			);

			if (indexRange.Item1 == indexRange.Item2)
			{
				return this.boxed.eeByRef.cumulatedProb(
					lower
				);
			}

			var upper = this.boxed.eeByRef.sortedDict.Keys.ElementAt((int)(indexRange.Item2));

			return this.boxed.eeByRef.cumulatedProb(lower)
				+
				(
					this.boxed.eeByRef.cumulatedProb(
						lower
					)
					-
					this.boxed.eeByRef.cumulatedProb(
						upper

					)
				)
				*
				(
					el - lower
				)
				/
				(upper - lower)
			;
		}

		public double density(double sample)
		{
			//find the interval.

			var interval = nilnul.obj.sortie._FindX._IndexRange<double>(
					this.boxed.eeByRef.sortedDict.Keys.ToList()
					,
					(sample)
					,
					nilnul.num.real.ComparerDbl.Singleton
			);

			if (interval.Item2 == null)
			{
				return 0;
			}

			if (interval.Item1 == null)
			{
				return 0;

			}
			if (interval.Item2 == 0) // the index
			{
				return 0;

			}

			if (interval.Item1 == interval.Item2)
			{
				interval = (interval.Item1 - 1, interval.Item2);
			}

			return (
				this.boxed.eeByRef.sortedDict.ElementAt(interval.Item2.Value).Value
				-
				this.boxed.eeByRef.sortedDict.ElementAt(interval.Item1.Value).Value
			)
			/
			(
				this.boxed.eeByRef.sortedDict.ElementAt(interval.Item2.Value).Key
				-
				this.boxed.eeByRef.sortedDict.ElementAt(interval.Item1.Value).Key

			);
		}

		public double prob(Bound4dbl sample)
		{
			return _BorelX.Pmf(this, sample); // cpf(sample.upper.mark.errable) - cpf(sample.lower.mark.errable);
		}

		public double sample()
		{

			var rnd = nilnul.stat.dist_.borel_.pdfable_.uniform_.prob.sample_._RandomX.Next4dbl();

			var slid = this.boxed.eeByRef.boxed.GetEnumerator();

			slid.MoveNext();    //the first's prob is nil. so we have at least two;
			var lower = slid.Current;

			#region logically this can be omitted; efficiency-wise, this is kept
			if (rnd <= 0)
			{
				return lower.Key;
			}
			#endregion

			while (slid.MoveNext())
			{
				KeyValuePair<double, Prob4dbl> upper = slid.Current;

				if (rnd <= upper.Value)
				{
					return lower.Key + (rnd - lower.Value) / (upper.Value - lower.Value) * (upper.Key - lower.Key);
				}

				lower = upper;

			}

			return lower.Key;

		}


	}
}
