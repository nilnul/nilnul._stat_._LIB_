using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat._dist.probs.be
{
	public class Vow4dbl
		: nilnul.obj.be.Vow4<
			Probs4dblI
		>
	{
		public Vow4dbl(BeI1<Probs4dblI> be) : base(be)
		{
		}

		public Vow4dbl(Predicate<Probs4dblI> predicate) : base(predicate)
		{
		}

		public Vow4dbl(Func<Probs4dblI, bool> func) : base(func)
		{
		}
	}
}
