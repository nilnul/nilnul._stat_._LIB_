using nilnul.num.real.ext;
using nilnul.num.real.ext.func_.binary_.beta._spanned_;
using nilnul.prob.dist.inst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdf_.beta_
{
	public class Pert4dbl
		:
		borel_.Invertible4dblA
		,
		borel_.pdf_.Beta4dblI
		
		,
		borel_.Pert4dblI
	{
		private double _min;
		public double min { get => _min; set => _min = value; }

		private double _mod;
		public double mod { get => _mod; set => _mod = value; }

		private double _max;
		public double max { get => _max; set => _max = value; }


		public double lambda = 4;

		public double span
		{
			get
			{
				return _max - _min;
			}
		}

		public Pert4dbl(double min, double mod, double max, double lambda = 4)
		{
			this._min = min;
			this._max = max;
			this._mod = mod;
			this.lambda = lambda;
		}


		//public Pert4dbl(double definite)
		//	: this(definite, definite, definite)
		//{
		//}

		public nilnul.stat.dist_.borel_.pdf_.Beta4dbl toBetaGeneralizedDist
		{
			get
			{
				return new nilnul.stat.dist_.borel_.pdf_.Beta4dbl(a, b, min, _max);
			}

		}
		public override double invert(double cdf)
		{
			return toBetaGeneralizedDist.invert(cdf);


		}


		public double inverseCdf(double prob)
		{
			return toBetaGeneralizedDist.invert(prob);
		}
		public double inverseCdf()
		{
			return inverseCdfRandomly();
		}



		public double inverseCdfRandomly()
		{
			System.Random random = new System.Random();

			return toBetaGeneralizedDist.invert(random.NextDouble());
		}





		public double cumulativeDensity(double x)
		{
			return toBetaGeneralizedDist.cumulativeDensity(x);
		}


		public override double cdf(double x)
		{

			return toBetaGeneralizedDist.cumulativeDensity(x);
		}

		public double a
		{
			get
			{
				return 1 + lambda * (mod - min) / span;
			}
		}


		public double b
		{
			get
			{
				return 1 + lambda * (_max - mod) / span;
			}

		}

		public double indicPlus => a;

		public double indic4complementPlus => b;


		public double density(double x)
		{

			return toBetaGeneralizedDist.density(x);

		}


		static public double Density(double min, double mod, double max, double x)
		{

			if (x <= min)
			{
				return 0;

			}
			if (x >= max)
			{
				return 0;

			}



			double mean = Mean(min, mod, max);
			double a = A(min, mod, max, mean);
			double b = B(min, max, mean, a);

			return Beta2.Density(a, b, x);
		}

		static public double Mean(double min, double mod, double max)
		{

			return (min + 4 * mod + max) / 6;
		}

		static public dist_.borel_.pdf_.Beta4dblI ToBetaGeneralized(double min, double mod, double max, double lambda = 4)
		{

			return new Pert4dbl(min, mod, max, lambda).toBetaGeneralizedDist;
		}

		static public double A(double min, double mod, double max, double mean)
		{
			return (mean - min) * (2 * mod - min - max) / ((mod - mean) * (max - min));

		}
		static public double A(double min, double mod, double max)
		{
			return A(min, mod, max, Mean(min, mod, max));

		}

		static public double B(double min, double max, double mean, double a)
		{
			return a * (max - mean) / (mean - min);

		}

		public override double pmf(Bound4dbl sample)
		{
			return cdf(sample.upper.mark.errable) - cdf(sample.lower.mark.errable);
			//throw new NotImplementedException();
		}
	}
}
