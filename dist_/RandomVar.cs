using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.bySampleSpace.finite
{

	public partial class RandomVar<TSamplePoint>
	{
		private Func<TSamplePoint,double> _func;

		public Func<TSamplePoint,double> func
		{
			get { return _func; }
			set { _func = value; }
		}
		public RandomVar(Func<TSamplePoint,double> func)
		{

			this.func = func;

		}
		
		
	}
}
