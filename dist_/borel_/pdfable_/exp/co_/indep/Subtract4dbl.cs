using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdfable_.exp.co_.indep
{
	/// math.stackexchange.com/questions/115022/pdf-of-the-difference-of-two-exponentially-distributed-random-variables/1523349#1523349
	/// Aaron Hendrickson, et al;
	/// <summary>
	///  the density of the difference of independent gamma random variables Z=X−Y with X∼Gamma(α1,λ1) and Y∼Gamma(α2,λ2) is given; Substituting α1=α2=1 into this expression;
	/// </summary>
	public class Subtract4dbl
		:
		//borel_.Pdfable4dblA
		//,
		borel_._pdfable_.Density4dblI
	{
		private borel_.pdfable_.Exp4dbl _exp1st;

		public borel_.pdfable_.Exp4dbl exp1st
		{
			get { return _exp1st; }
			set { _exp1st = value; }
		}

		private borel_.pdfable_.Exp4dbl _exp2nd;

		public borel_.pdfable_.Exp4dbl exp2nd
		{
			get { return _exp2nd; }
			set { _exp2nd = value; }
		}
		public Subtract4dbl(
			borel_.pdfable_.Exp4dbl exp1st
			,
			borel_.pdfable_.Exp4dbl exp2nd
		)
		{
			_exp1st = exp1st;
			_exp2nd = exp2nd;
			var _coefCalced = exp1st.mean * exp2nd.mean / (exp1st.mean + exp2nd.mean);
			_coef4exp2ndCalced = _coefCalced * Math.Exp(exp2nd.mean);

			_coef4exp1stCalced = _coefCalced * Math.Exp(-exp1st.mean);

		}


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
				return _coef4exp2ndCalced * Math.Exp(sample);
			}
			return _coef4exp1stCalced * Math.Exp(sample);
		}


	}
}
