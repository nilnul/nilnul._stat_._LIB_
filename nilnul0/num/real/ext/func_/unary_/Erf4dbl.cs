using nilnul.num.real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace nilnul.stat.dist_.borel_.pdf_.normal_._std_._cdf
namespace nilnul.num.real.ext.func_.unary_
{
	/// <summary>
	/// error function;
	/// gives the probability of a random variable, with normal distribution of mean 0 and variance 1/2 falling in the range [-x,x]
	/// </summary>
	/// <remarks>
	/// note this is not a cdf, as x can be negative, and the tgt can be in (0,-1];
	/// 
	/// </remarks>
	/// image is:
	///		(-1,1)
	///	parity:odd
	///	shape:
	///		sigmoid | s-shaped;
	public class Erf4dbl
		:
		nilnul.num.real.ext.of_.unary_.OfExt4dblA
	{
		_erf.IncompletAboutNil4Dbl _incomplete;
		public _erf.IncompletAboutNil4Dbl incomplete
		{
			get { return _incomplete; }
		}



		public Erf4dbl(_erf.IncompletAboutNil4Dbl incomplete)
		{
			_incomplete = incomplete;
		}


		public nilnul.num.real_.PositiveDbl accuracy
		{
			get { return _incomplete.accuracy; }
		}





		public Erf4dbl(nilnul.num.real_.PositiveDbl accuracy):this(new _erf.IncompletAboutNil4Dbl(accuracy))
		{
		}



		public Erf4dbl(double v)
			: this(

				new num.real_.PositiveDbl(v)
		)
		{
		}

		/// <summary>
		/// todo:
		/// </summary>
		static public readonly double OfTwo4Dbl = Math.Sqrt(2);


		/// <summary>
		/// 
		/// </summary>
		/// <param name="par"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public override double _op_0ext(double x)
		{
			return 
					_incomplete._op_0ext(
						x 
					)
				
			;

			if (x >= 0)
			{

			}

			return .5 - _incomplete._op_0ext(-x / Math.Sqrt(2));


		}

		static public Erf4dbl OfThousandth() {
			return new Erf4dbl(.001);
		}
		

	}
}
