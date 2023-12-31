using nilnul.num.real;
using nilnul.num.real.bound_;
using nilnul.num.real.ext;
using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;




namespace nilnul.stat.dist_.borel_.pdfable_
{

	/// <summary>
	/// Consider a Poisson Process, X is the time till the n-th events occur.
	/// P(X<=x)=1-P(X>x)=1-Sum (
	///            k=0 -> n-1,
	///            (lamda * x)^k * e^(-lamda *x) / k!
	/// )
	/// 
	/// f(x)=
	/// 
	/// </summary>
	public class Gamma4dbl
		:
		Gamma4dblI
	{
		/// <summary>
		/// Shape Parameter
		/// </summary>
		private num.real_.PositiveDbl _indicPlus;
		/// <summary>
		/// Scale parameter
		/// </summary>
		private num.real_.PositiveDbl _scale;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="indicPlus"></param>
		/// <param name="scale">strech the density, such that we need to divide the stretched complete gamma;</param>
		public Gamma4dbl(PositiveDbl indicPlus, PositiveDbl scale)
		{

			this._indicPlus = indicPlus;
			this._scale = scale;
			this._densityCached = new num.real.ext.func_.unary_.gamma._scaled.integrand.Denominated4dbl(indicPlus,scale);
			this._cdfCached = new num.real.ext.func_.unary_.gamma._scaled.integrand.denominated.Incomplete4dbl(indicPlus,scale);
			this._rndCached = borel_.pdfable_.uniform_.Preportion4dblEs.Get0th();

		}

		public double shape2dbl
		{
			get
			{
				return _indicPlus.ee;
			}
		}

		public PositiveDbl shape
		{
			get
			{
				return _indicPlus;
			}
		}

		/// <summary>
		/// x/scale;
		/// for the complete gamma: scale *gamma;
		/// </summary>

		public double scale2dbl
		{
			get
			{
				return _scale.ee;
			}
		}
		public PositiveDbl scale
		{
			get
			{
				return _scale;
			}
		}

		public double mean
		{
			get
			{
				return shape2dbl* scale;
			}
		}

		public double variance
		{
			get
			{
				return shape.ee * scale * scale;
			}
		}

		public nilnul.num.real.Interval4dbl scope => num.real.Interval4dbl.CreateClopen(0);

		public nilnul.num.real.ext.Bound4dbl scope4ext => num.real.ext.Bound4dbl.CreateClose(0, double.PositiveInfinity);






		nilnul.num.real.ext.func_.unary_.gamma._scaled.integrand.Denominated4dbl _densityCached;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sample">
		/// [0,+inf]
		/// </param>
		/// <returns>
		/// posInf when indic lt 1, and <paramref name="sample"/> is 0;
		/// </returns>
		public double _density_0extNonneg(double sample)
		{
			return _densityCached._op_0extNonneg(sample);


			if (sample == 0)
			{
				if (this.shape2dbl <= 1)
				{
					return double.PositiveInfinity; //the limit of 0+, even for shape=1;
				}

				//x ^ (shape - 1) * e ^ (-x / scale) / ( GammaFunction.Gamma(shape)  *  scale ^ shape );
			}

			return _densityCached._op_0positive(sample);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sample"></param>
		/// <returns></returns>
		public double _density_0ext(double sample)
		{

			if (sample < 0)
			{
				return 0;
			}
			return _density_0extNonneg(sample); // in support;

		}

		public double density(Ext4dblI sample)
		{

			return _density_0ext(sample.errable);

		}
		public double density(Ext4dbl sample)
		{

			return _density_0ext(sample.errable);

		}

		public double density(double sample)
		{
			return density( new Ext4dbl(sample) );

			if (sample < 0)
			{
				return 0;
			}
			return _density_0extNonneg(sample); // in support;

		}


		nilnul.num.real.ext.func_.unary_.gamma._scaled.integrand.denominated.Incomplete4dbl _cdfCached;

		public double _cdf_0finite(double upperBound)
		{
			if (upperBound < 0)
			{
				return 0;
			}
			return _cdfCached._op_0nonneg(upperBound);
		}

		public double _cdf_0ext(double upperBound)
		{
			if (upperBound < 0)
			{
				return 0;
			}
			if (upperBound == double.PositiveInfinity)
			{
				return 1;
			}
			return _cdf_0finite(upperBound);
		}
		public double cumulatedProb(double upperBound)
		{
			if (double.IsNaN(upperBound))
			{
				return double.NaN;
			};
			return _cdf_0ext(upperBound);
		}

		borel_.pdfable_.uniform_.Preportion4dbl _rndCached;

		public double sample()
		{
			return invert(
			 _rndCached	.sample()
			);
		}

		public double invert(double cdf)
		{
			return _cdfCached.inverse(cdf);
		}
		public double _invert_0prob(double cdf)
		{
			return _cdfCached._inverse_0prob(cdf);
		}


		public double prob(Interval4dbl sample)
		{
			return cumulatedProb(sample.upper.mark.errable) - cumulatedProb(sample.lower.mark.errable);
		}

		public double prob(Bound4dbl sample)
		{
			return cumulatedProb(sample.upper.mark.errable) - cumulatedProb(sample.lower.mark.errable);
		}



		//static public theorem.Theorem theorem = new nilnul.math.theorem.Theorem();

		///If Xi ~ Gamma Distribution(ai,b), i=1,2,...
		///Then Sum(Xi) ~ GammDist(Sum(ai),b)
		///

		///if x1~Gamma Dist.(a1,b), x2~GammaDist(a2,b),
		///Then x1/(x1+x2) ~ BetaDist(a1,a2).
		///

		///if xi~chiSquareDist, 
		///Then Sum(Xi)~ Gammadist(n,1)








	}//class





}//namespace
