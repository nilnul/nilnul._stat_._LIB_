using nilnul.obj.str;
using nilnul.stat.dist_.finite_.cmf_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.num.natural.Natural_bigInteger;


namespace nilnul.stat.dist_.borel_.pdfable_.empiric.of_
{
	static public class _OfPmfX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="samples_countPlural"></param>
		/// <returns></returns>
		/// <exception cref="">
		/// if the pmf's first entry is not impossible event, <see cref="Empirical4quotient"/> would throw exception;
		/// </exception>
		static public Empirical4quotient ToEmpiric(
			finite_.quotient2quotient_.PmfBySortedDict samples_countPlural
		) {
			return new Empirical4quotient(
				 stat.dist_.finite_.cmf_.quotient2quotient.of_._OfPmfX.AsCpf(
					samples_countPlural
				)
			);
		}

		static public Empirical4dbl ToEmpiric(
			stat.dist_.Finite4dbl 
			 samples_countPlural
		) {
			return new Empirical4dbl(
				new Dbl2dbl(
					stat.dist_.finite_.cmf.of_._PmfX.CmfAsDict4dbl(
						samples_countPlural
					)
				 )
			);
		}
		static public Empirical4dbl ToEmpiric(
			Dictionary<double,double> samples_countPlural
		)
		{
			var cmfAsSorted = stat.dist_.finite_.cmf.of_._PmfX.CmfAsDict4dbl(samples_countPlural);

			finite_.cmf_._bySortedDict.sortedDict._LastProb2oneX.LastProb2one(
				ref cmfAsSorted
			)	;
			return  new Empirical4dbl(
				
					cmfAsSorted
				
			);
		}



	}
}
