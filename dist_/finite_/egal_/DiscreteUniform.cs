using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.distributions
{
	public partial class DiscreteUniform<T>
	{
		private List<T> _space;

		public List<T> space
		{
			get { return _space; }
			set { _space = value; }
		}

		
	}
}
