using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real;
using Rx = nilnul.num.Real;
using Quotient = nilnul.num.Quotient1;

namespace nilnul.prob.continuum_
{
	/// <summary>
	/// [0,1]
	/// </summary>
	public class UniformEnclosedZeroOne
		:_continuum_.CdfI
	{
		public Rx density(Rx x) {
			if (x<=0)
			{
				return 0;
			}
			if (x>=1)
			{
				return 0;
			}
			return 1;
		}

		

		public Rx cdf(Rx x)
		{
			if (x<=0)
			{
				return 0;
			}
			if (x>=1)
			{
				return 1;
			}

			return x;

			//throw new NotImplementedException();
		}

		public Rx variance {
			get {
				return new Rx( num.real_.Quotient.CreateUnitFrac(12) );
			}			 
		}

		public Rx mean {
			get {
				return new Rx( Quotient.CreateHalf() );
			}
		}

	}
}
