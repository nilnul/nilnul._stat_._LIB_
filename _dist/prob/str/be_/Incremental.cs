using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M= nilnul.stat.ProbDbl;



namespace nilnul.stat._dist.prob.str.be_
{
	static public class _NonDecreaseX
	{

		static public bool Be(IEnumerable<M> measures)
		{
			
			return nilnul.obj.seq._AsCosX.AsCos(measures).All(
				co => co.Item2 >= co.Item1
			);

		}

		static public bool Be(IEnumerable<Prob4dbl> measures)
		{
			
			return nilnul.obj.seq._AsCosX.AsCos(measures).All(
				co => co.Item2 >= co.Item1
			);

		}

		static public bool Be(IEnumerable<ProbQuotient> measures)
		{
			
			return nilnul.obj.seq._AsCosX.AsCos(measures).All(
				co => co.Item2 >= co.Item1
			);

		}

	}
}
