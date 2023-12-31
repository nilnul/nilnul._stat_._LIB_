using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace nilnul.stat.dist_.borel_.pdfable_.gamma.co_.indep
{
	/// math.stackexchange.com/questions/115022/pdf-of-the-difference-of-two-exponentially-distributed-random-variables/1523349#1523349
	/// Aaron Hendrickson, et al;
	///
	/// Aaron Hendrickson, The inverse gamma-difference distribution and its first moment in the Cauchy principal value sense, Stat. Interface 12(2019), no. 3, 467-478, DOI 10.4310/19-SII564
	/// 
	/// <summary>
	///  the density of the difference of independent gamma random variables Z=X−Y with X∼Gamma(α1,λ1) and Y∼Gamma(α2,λ2) is given; 
	/// </summary>
	public class Subtract4dbl
		:
		//borel_.Pdfable4dblA
		//,
		borel_._pdfable_.Density4dblI
	{
		private borel_.pdf_.Gamma4dbl _gamma1st;

		public borel_.pdf_.Gamma4dbl gamma1st
		{
			get { return _gamma1st; }
			set { _gamma1st = value; }
		}

		private borel_.pdf_.Gamma4dbl _gamma2nd;

		public borel_.pdf_.Gamma4dbl gamma2nd
		{
			get { return _gamma2nd; }
			set { _gamma2nd = value; }
		}
		public Subtract4dbl(
			borel_.pdf_.Gamma4dbl gamma1st
			,
			borel_.pdf_.Gamma4dbl gamma2nd
		)
		{
			_gamma1st = gamma1st;
			_gamma2nd = gamma2nd;

			_addOfScale = gamma1st.scale2dbl + gamma2nd.scale2dbl;
			_addOfShape = gamma1st.shape2dbl + gamma2nd.shape2dbl;

			var _coefCalced = Pow(gamma1st.scale2dbl, gamma1st.shape2dbl)
				* Pow(gamma2nd.scale2dbl, gamma2nd.shape2dbl)
				/ Pow(_addOfScale, 1 - _addOfShape);




			_coef4exp2ndCalced = _coefCalced * Math.Exp(gamma2nd.scale2dbl);

			_coef4exp1stCalced = _coefCalced * Math.Exp(-gamma1st.scale2dbl);

		}

		public double _addOfScale;

		public double _addOfShape;


		public double _coef4exp1stCalced;

		public double _coef4exp2ndCalced;


		///https://math.stackexchange.com/questions/115022/pdf-of-the-difference-of-two-exponentially-distributed-random-variables/1523349#1523349
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sample"></param>
		/// <returns></returns>
		public double density(double sample)
		{
			if (sample <= 0)
			{
				return _coef4exp2ndCalced * Math.Exp(sample) * nilnul.num.real.ext.of_.ternary_.HyperGeometric2nd(
					1 - gamma2nd.shape2dbl
					,
					2 - _addOfShape
					,
					-_addOfScale * sample
				);
			}

			return _coef4exp1stCalced * Math.Exp(sample) * nilnul.num.real.of_.ternary_.HyperGeometric2nd(
				1 - gamma1st.shape2dbl
				,
				2 - _addOfShape
				,
				_addOfScale * sample
			);

		}


	}
}
