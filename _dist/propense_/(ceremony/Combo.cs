using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob._dist
{
	
	[
		Obsolete(
			nameof(
				nilnul.stat._dist.IPropense
			)
		)
	]
	public class Combo<TEvent,TProb>
	{
		private TEvent  _evt;

		public TEvent  evt
		{
			get { return _evt; }
			set { _evt = value; }
		}

		private TProb _prob;

		public TProb prob
		{
			get { return _prob; }
			set { _prob = value; }
		}





	}
}
