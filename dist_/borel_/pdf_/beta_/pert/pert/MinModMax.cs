
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob.doubleProb.doubleSample.cdf.contains.pert
{



	public partial struct MinModMax_Struct
	{
		public double min;
		public double max;
		public double mod;



		public double span
		{
			get
			{
				return max - min;
			}
		}



		public MinModMax_Struct(double min, double mod, double max)
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

