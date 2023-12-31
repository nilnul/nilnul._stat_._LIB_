using nilnul.obj.str;
using nilnul.rel_.dict;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.num.natural.Natural_bigInteger;


namespace nilnul.stat.dist_.borel_.pdfable_.empiric.of_.occurs_
{
	/// <summary>
	/// For a str of samples, we imagine that there is a sample of prob=0 before and after.
	/// thicken each sample from a line to a bar, resulting adjacenting bars. then prepend a null (prob being nil) sample at the left border of the heading bar.
	/// </summary>
	/// <remarks>
	/// for two samples, the width of each bar shall be the distance between the two samples;
	/// for n samples, the width of each bar shall be scope/(n-1) ; here we assume the scope is not nil.
	/// </remarks>
	static public class _ByThickening1stX
	{


		static public Dictionary<double, int> _AsNil4first_0spanPositive(
			Dictionary<double,int> samples_totalPlural
		)
		{

			var count = samples_totalPlural.Select(a=>a.Value).Sum(); 

			var maxSample = samples_totalPlural.Aggregate(samples_totalPlural.First(), (a, c) => c.Key > a.Key ? c : a).Key;      
			var minSample = samples_totalPlural.Aggregate(samples_totalPlural.First(), (a, c) => c.Key < a.Key ? c : a).Key;      

			var countMinus = count - 1; 

			var sampleSpan = maxSample - minSample; 

			var avgSpan = sampleSpan/ countMinus;



			var append = maxSample + avgSpan;   
			var prepend = minSample - avgSpan;  
			return empiric._of.occur._ConvertX._PrependNulSample(samples_totalPlural,prepend);

		
		}
		static public Dictionary<double, int> _AsNil4first_0spanPositive(
			Dictionary<double,Num1> samples_totalPlural
		)
		{
			var r = new Dictionary<double, int>();

			samples_totalPlural.Each(
				x=>r.Add(x.Key,(int)x.Value.en)
			);
			
			return _AsNil4first_0spanPositive(r);

		
		}

		static public Finite4dbl ToPmf(Dictionary<double, int> samples_countPlural) {

			return nilnul.stat.dist_.Finite4dbl.OfOccurences(
				_AsNil4first_0spanPositive(samples_countPlural)
			);
		}
		static public finite_.cmf_.Dbl2dbl AsCpf(
			Dictionary<double, int> samples_countPlural
		) {

			return new finite_.cmf_.Dbl2dbl(
				stat.dist_.finite_.cmf.of_._PmfX.CmfAsDict2prob(
					ToPmf(
						samples_countPlural
					)
				)
			);
		}

		static public Empirical4dbl ToEmpiric(
			Dictionary<double, int> samples_countPlural
		) {
			return _OfPmfX.ToEmpiric(
				 ToPmf(
					
						samples_countPlural
					
				)
			);
		}

	}
}
