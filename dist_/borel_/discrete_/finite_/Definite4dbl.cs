using nilnul.num.real;
using nilnul.num.real.ext;
using nilnul.stat.dist_._borel_;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.discrete_.finite_
{
	public class Definite4dbl
		:
		dist_._discrete_.Pmf4dblI

		,
		dist_.IBorel
		,
		dist_._borel_.Sample4dblI
		,
		dist_.Borel4dblI
		,
		dist_.borel_.Invertible4dblI
		,
		Pert4dblI
		//,
		//dist_._borel_.Cdf4dblI
		
	{
		private double _sample;

		public double single
		{
			get { return _sample; }
			set { _sample = value; }
		}

		public Definite4dbl(double sample)
		{
			this._sample = sample;
		}

		public double prob(double sample)
		{
			return sample == _sample ? 1 : 0;
		}

		public double sample()
		{
			return _sample;
			//throw new NotImplementedException();
		}

		public double cumulatedProb(double upperBound)
		{
			if (upperBound<_sample)
			{
				return 0;
			}
			return 1;
		}

		public double invert(double cdf)
		{
			if (cdf ==1) {
				return _sample;
			}
			throw new borel.sample_.xpn_.NoSuchCdf(
				$"{cdf} can only be 1;"
			);
		}

		public double prob(Bound4dbl sample)
		{
			if (sample.has(
				new Ext4dbl(this.single)
			))
			{
				return 1;

			}return 0;
		}
	}
}
