using nilnul.num.real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace nilnul.stat.dist_.borel_.pdf_.normal_._std_._cdf
namespace nilnul.num.real.ext.func_.unary_.erf_
{
	/// <summary>
	/// half of error function; in 0quadrant and also including origion
	/// </summary>
	/// <remarks>
	/// range is [0,1];
	///  this can be a cdf;
	/// 
	/// </remarks>
	public class OfNonneg4dbl
		:
		nilnul.num.real.ext.of_.unary_.OfNonneg4dblA
	{
		_erf.IncompletAboutNil4Dbl _incomplete;
		public _erf.IncompletAboutNil4Dbl incomplete
		{
			get { return _incomplete; }
		}



		public OfNonneg4dbl(_erf.IncompletAboutNil4Dbl incomplete)
		{
			_incomplete = incomplete;
		}


		public nilnul.num.real_.PositiveDbl accuracy
		{
			get { return _incomplete.accuracy; }
		}





		public OfNonneg4dbl(nilnul.num.real_.PositiveDbl accuracy) : this(new _erf.IncompletAboutNil4Dbl(accuracy))
		{
		}



		public OfNonneg4dbl(double v)
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
		/// <exception cref="NotImplementedException"></exception>
		public override double _op_0extNonneg(double x)
		{
			return _incomplete._op_0extNonneg(x);
			


		}



	}
}
