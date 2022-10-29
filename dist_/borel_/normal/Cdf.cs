using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.random.continuum.probD.normal
{
	public class Cdf
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

		public double inflexionPoinDeviation{
			get {
				return 0; 
			}
		}

		public Cdf()
		{

		}
	}
}
