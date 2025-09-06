using nilnul.num.real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.func_.unary_
{
	/// <summary>
	/// x=> 1-<see cref="Erf4dbl"/>(x)
	/// </summary>
	/// image is:
	///		(-1,1)
	///	parity:odd
	public class Erfc4dbl
		:
		nilnul.num.real.ext.of_.unary_.OfExt4dblA
	{
		Erf4dbl _erf;
		public Erf4dbl erf
		{
			get { return _erf; }
		}

		public nilnul.num.real_.PositiveDbl accuracy
		{
			get { return _erf.accuracy; }
		}


		public Erfc4dbl(Erf4dbl incomplete)
		{
			_erf = incomplete;
		}



		public Erfc4dbl(nilnul.num.real_.PositiveDbl accuracy) : this(new Erf4dbl(accuracy))
		{
		}



		public Erfc4dbl(double v)
			: this(
				new num.real_.PositiveDbl(v)
		)
		{
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="par"></param>
		/// <returns></returns>
		public override double _op_0ext(double x)
		{
			return 1-   _erf._op_0ext(x);
			
			
		}



	}
}
