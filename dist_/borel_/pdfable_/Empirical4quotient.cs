using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;
using nilnul.num.rational;
using nilnul.stat.dist_.borel_.pdfable_._empiric.cmf.be_.nil4first.vow;
using nilnul.stat.dist_.finite_.cmf_;
using nilnul.stat.dist_.finite_.cmf_.quotient2quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdfable_
{
	/// <summary>
	/// 
	/// </summary>
	public class Empirical4quotient
	   : nilnul.obj.Box1<
			nilnul.stat.dist_.borel_.pdfable_._empiric.cmf.be_.nil4first.vow.Ee4quotient
		>
		,
		IEmpirical
		,
		nilnul.stat.dist_._cpfable_.Cpf4quotientI
		,
		nilnul.stat.dist_.borel_._pdfable_.Density4quotientI
	{
		public nilnul.stat.dist_.borel_.pdfable_._empiric.cmf.be_.nil4first.vow.Ee4quotient cmfee {
			get {
				return boxed;
			}
		}

		public CpfBySortedDict cmf {
			get {
				return cmfee.eeByRef;
			}
		}

		public Empirical4quotient(Ee4quotient val) : base(val)
		{
		}

		public Empirical4quotient(CpfBySortedDict val) : this(new Ee4quotient(val))
		{
		}

		/// <summary>
		/// differnt from <see cref="nilnul.stat.dist_.finite_.cmf_.quotient2quotient_.CpfBySortedDict"/>, here the points in between two pickets has nonnil density.
		/// </summary>
		/// <remarks>
		/// we also need the pdf for what's before the 1st point. so the 1st point in cdf is supposed to have zero as it's cpf.
		/// </remarks>
		/// <param name="el"></param>
		/// <returns></returns>
		public nilnul.num.quotient_.DenomNonnil cumulatedProb(nilnul.num.quotient_.DenomNonnil el)
		{
			var indexRange = nilnul.num.quotient.sortie._FindX._IndexRange_assumeSortie(
				this.boxed.eeByRef.Keys
				//.Select(
				//	x=> nilnul.num.quotient_.denomNonnil._RegressionsX.ToStd( x)
				//)
				,
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

			var lower = this.boxed.eeByRef.Keys.ElementAt((int)(indexRange.Item1));
			if (indexRange.Item1 == indexRange.Item2)
			{
				return this.boxed.eeByRef.cumulatedProb(
						lower
					)
				;
			}

			var upper = this.boxed.eeByRef.Keys.ElementAt((int)(indexRange.Item2));

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

		public DenomNonnil density(DenomNonnil sample)
		{

			//find the interval.

			var interval = nilnul.obj.sortie._FindX._IndexRange
				//.interval.BinarySearchX.BinarySearchX_ListBiSearch_index
				<DenomNonnil>(
				this.boxed.eeByRef.Keys.ToList()
				,
				sample
				,
				nilnul.num.quotient_.denomNonnil.Comp.Singleton
			);

			if (interval.Item2 == null)
			{
				return  DenomNonnil.Nil;
			}

			if (interval.Item1 == null)
			{
				return DenomNonnil.Nil;
				//return new NonNegX.NonNegRational(Rational_InheritFraction.Zero);

			}
			if (interval.Item2 == 0) // the index
			{
				return DenomNonnil.Nil;
				//return new NonNegX.NonNegRational(Rational_InheritFraction.Zero);

			}

			if (interval.Item1 == interval.Item2)
			{
				interval = (interval.Item1 - 1, interval.Item2);
			}

			return (
				this.boxed.eeByRef.ElementAt(interval.Item2.Value).Value
				-
				this.boxed.eeByRef.ElementAt(interval.Item1.Value).Value
			)
			/
			(
				this.boxed.eeByRef.ElementAt(interval.Item2.Value).Key - this.boxed.eeByRef.ElementAt(interval.Item1.Value).Key
			);

		}

	}
}
