using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.multivar_.bival
{
	public class Observation<TVarVal> :
		nilnul.obj.Set1<TVarVal>
	{
		public Observation(HashSet<TVarVal> hashSet) : base(hashSet)
		{
		}

		public Observation(IEqualityComparer<TVarVal> eq) : base(eq)
		{
		}

		public Observation(TVarVal[] vars, IEqualityComparer<TVarVal> elementEq) : base(vars, elementEq)
		{
		}

		public Observation(IEqualityComparer<TVarVal> elementEq, TVarVal[] vars) : base(elementEq, vars)
		{
		}

		public Observation(IEnumerable<TVarVal> vars, IEqualityComparer<TVarVal> elementEq) : base(vars, elementEq)
		{
		}

		public Observation(IEqualityComparer<TVarVal> elementEq, IEnumerable<TVarVal> vars) : base(elementEq, vars)
		{
		}
	}
}
