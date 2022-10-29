using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.random.continuum.probD.expNormal
{
	public class Pdf
	{
		private double _sigma;

		public double sigma
		{
			get { return _sigma; }
			set { _sigma = value; }
		}

		private double _mu;

		public double mu
		{
			get { return _mu; }
			set { _mu = value; }
		}

		public double density(double x) {
			return x <= 0 ? 0 : 
				
				Math.Exp(
					-nilnul.num.real.double_.op.SquareX.Square( Math.Log(x)	) /2
				)   
				/ 
				(Math.Sqrt(nilnul.num.real_.TauX.IntoDouble) * x);
		}

		
	}
}
