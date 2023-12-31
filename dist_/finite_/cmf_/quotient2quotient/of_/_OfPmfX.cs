using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;
using nilnul.num.rational;
using nilnul.stat.dist_.finite_.cmf_.quotient2quotient_;
using nilnul.stat.dist_.finite_.quotient2quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.quotient_.DenomNonnil;//.Rational_InheritFraction;

namespace nilnul.stat.dist_.finite_.cmf_.quotient2quotient.of_
{
	/// <summary>
	/// the first sample's prob can be nil.
	/// </summary>
	static public class _OfPmfX
	{


		static public SortedDictionary<R, R> AsSortedDict(
			PmfBySortedDict pmfBySortedDict
		)
		{

			var r = new SortedDictionary<DenomNonnil, DenomNonnil>( nilnul.num.quotient_.denomNonnil.Comp.Singleton);
			DenomNonnil totalProb = 0;
			foreach (var item in pmfBySortedDict.sorted4pmf)
			{
				totalProb += item.Value.en.ToDenomNonnil();

				r.Add(item.Key, (totalProb));

			}


			return r;


		}


		static public CpfBySortedDict AsCpf(
			PmfBySortedDict pmfBySortedDict
		)
		{
			return new CpfBySortedDict(
				AsSortedDict(pmfBySortedDict)
			);


		}

	}



}



