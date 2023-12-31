using nilnul.num.real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdfable_.normal_._std_
{
	public class CdfByErf4Dbl
		:
		nilnul.num.real.ext.of_.unary_.OfExt4dblA
	{
		private nilnul.num.real_.PositiveDbl _accuracy;

		public nilnul.num.real_.PositiveDbl accuracy
		{
			get { return _accuracy; }
			set { _accuracy = value; }
		}





		public CdfByErf4Dbl(nilnul.num.real_.PositiveDbl accuracy)
		{
			_accuracy = accuracy;
		}



		public CdfByErf4Dbl(double v)
			: this(

				new num.real_.PositiveDbl(v)
		)
		{
		}

		/// <summary>
		/// calculate by <see cref="num.real.ext.func_.unary_.Erf4dbl"/>;
		/// to calculate this use series that is integrated by parts, <see cref="cdf_.bySeries_.Calculi8partwise4dbl"/>
		/// </summary>
		/// <param name="par"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public  double _op_0extNonneg(double par)
		{
			return 
				1/2 // the left half
				+
				new num.real.ext.func_.unary_.Erf4dbl(_accuracy)._op_0ext(
					par
					/
					//nilnul.num.real_.nonneg.op_.unary_._sqrt.Ret.
					Math.Sqrt(2)
				)/2
			;
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="par"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public override double _op_0ext(double par)
		{
			return 0.5	/// as <see cref="num.real.ext.func_.unary_.Erf4dbl"/> is from 0 to x; we need to add the from -inf to 0
				+
				
				new num.real.ext.func_.unary_.Erf4dbl(_accuracy)._op_0ext(
					par
					/
					Math.Sqrt(2)
				)	// the value is one
				/2;
			
		}

		static public CdfByErf4Dbl OfThousandth() {
			return new CdfByErf4Dbl(
				//nilnul.num.quotient_.radix_.dec
				.001
			);
		}

	}
}
