using nilnul.obj.str;
using nilnul.rel_.dict;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.num.natural.Natural_bigInteger;


namespace nilnul.stat.dist_.borel_.pdfable_.empiric._of.occur
{
	static public class _ConvertX
	{

		/// <summary>
		/// to make this pdfable, there must be nulSample some distance before.
		/// </summary>
		/// <param name="samples_totalPlural">
		/// at least one sample
		/// </param>
		/// <param name="nulSamplePrepended">
		/// this is intended to be some distance before min sample.
		/// </param>
		/// <returns></returns>
		static public Dictionary<double, int> _PrependNulSample(
			Dictionary<double, int> samples_totalPlural
			,
			double nulSamplePrepended
		)
		{
			var r= new Dictionary<double, int>(
			);
			r.Add(nulSamplePrepended,0);
			r.AddRange(samples_totalPlural);
			return r;

		}


	}
}
