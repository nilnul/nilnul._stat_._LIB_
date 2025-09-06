using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.prob._prob;

using M = nilnul.prob._measure.Double;

namespace nilnul.prob._measure.doubl.be
{
	public class Positive : nilnul.BeI<M>
	{
		public bool be(Double obj)
		{
			return obj._val > 0;
			throw new NotImplementedException();
		}


		public class En:nilnul.be.Asserted<M,Positive>
		{
			public En(M measure):base(measure)
			{

			}


		}
	}
}
