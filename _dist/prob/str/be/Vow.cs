using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat._dist.prob.str.be
{
	public class Vow4dbl
		: nilnul.obj.be.Vow4<
			IEnumerable<Prob4dbl>
		>
	{
		public Vow4dbl(BeI1<IEnumerable<Prob4dbl>> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<IEnumerable<Prob4dbl>> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<IEnumerable<Prob4dbl>, bool> func) : base(func)
		{
		}
	}
}
