using nilnul.num.real.func_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdfable_.normal_.std
{
	/// <summary>
	/// centralfuge;
	/// </summary>
	/// alias:
	///		centripetal
	public class Centripetal4Dbl
		:
		nilnul.num.real.ext.of_.unary_.OfNonneg4dblA


	{
		 nilnul.num.real.ext.func_.unary_.Erf4dbl _incomplete;
		public nilnul.num.real.ext.func_.unary_.Erf4dbl incomplete
		{
			get { return _incomplete; }
		}



		public Centripetal4Dbl(nilnul.num.real.ext.func_.unary_.Erf4dbl incomplete)
		{
			_incomplete = incomplete;
		}


		public nilnul.num.real_.PositiveDbl accuracy
		{
			get { return _incomplete.accuracy; }
		}





		public Centripetal4Dbl(nilnul.num.real_.PositiveDbl accuracy) : this(new num.real.ext.func_.unary_.Erf4dbl (accuracy))
		{
		}



		public Centripetal4Dbl(double v)
			: this(

				new num.real_.PositiveDbl(v)
		)
		{
		}


		/// <summary>
		/// eg: for 3, the possibility lies within [-3Sigma, 3sigma]; for std [-3,3]
		/// </summary>
		/// <param name="par"></param>
		/// <returns></returns>
		public override double _op_0extNonneg(double par)
		{
			return	 _incomplete._op_0ext(
				par /

				Math.Sqrt(2)
			);
		}
	}
}
