using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.rational.Rational_InheritFraction;


namespace nilnul.prob.rationalProb.rationalSample.cdf.contains.pert
{



	public partial struct MinModMax_Struct
	{
		public R min;
		public R max;
		public R mod;



		public R span
		{
			get
			{
				return max - min;
			}
		}



		public MinModMax_Struct(R min, R mod, R max)
		{
			nilnul.bit.Assert.True(min < max);
			nilnul.bit.Assert.True(min <= mod);
			nilnul.bit.Assert.True(mod <= max);
			this.min = min;
			this.mod = mod;
			this.max = max;


		}







	}

}

