using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_.pdf_.uniform_.portion.sample_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		rnd
	static public class _RandomX
	{


		static public double Next4dbl()
		{
			double d;
			do
			{
				d = dist.survey_._RndX.Rnd.NextDouble();
			} while ( d == 0);  

			return d ;// [0,1) , we just discard the 0;
		}


	}

}
