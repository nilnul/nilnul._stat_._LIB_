using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.num.natural.Natural_bigInteger;


namespace nilnul.stat.dist_.borel_.pdfable_.empiric.of_
{
	static public class _OfSurveyX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="survey"></param>
		/// <returns></returns>
		static public Empirical4dbl ToEmpiric(
			IEnumerable<double> survey

		) {

			var occurs = new nilnul.num.real.BagOfDbl(survey) ;
			var occursPrepended = empiric.of_.occurs_._ByThickening1stX._AsNil4first_0spanPositive(occurs);


			var pmf = stat.dist_.finite.of_._OfOccursX._AsDict4dbl_0occurs(occursPrepended);



			var e = empiric.of_._OfPmfX.ToEmpiric(pmf);

			return e;

		}

	}
}
