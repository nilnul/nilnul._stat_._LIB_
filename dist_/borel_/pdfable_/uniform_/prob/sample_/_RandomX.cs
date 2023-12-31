using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_.pdfable_.uniform_.prob.sample_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		rnd
	static public class _RandomX
	{


		static public _dist.Prob8quotient Next4frac()
		{
			return new stat._dist.Prob8quotient(
				new nilnul.num.Quotient1(

					//nilnul.stat.dist_.borel_.pdf_.uniform_.Preportion4dblEs.Get0th().
					_Preportion4dblX.random.Next()
				//	nilnul.prob.RandomX.next2()
				,
				int.MaxValue - 1

				)
			);
		}
		static public double Next4dbl()
		{
			double d;
			int i;
			var r1 = dist.survey_._RndsX.Get0th();

			do
			{
				d = dist.survey_._RndX.Rnd.NextDouble();
				i = r1.Next(2);
			} while (i == 1 && d > 0);  

			return d + i;// [0,1) and [1,2), we just discard the gt 1 part;
		}


	}

}
