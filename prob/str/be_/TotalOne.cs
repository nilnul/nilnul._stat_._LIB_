using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M= nilnul.stat.ProbDbl;


namespace nilnul.stat.prob.str.be_
{
	static public class _TotalOneX
	{

		


		static public bool Be(IEnumerable<M> measures)
		{

			return measures.Select(t => t._val).Sum() == 1;

		}

		




	}
}
