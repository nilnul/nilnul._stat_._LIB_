using nilnul.num.real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace nilnul.stat.dist_.borel_.pdf_.normal_._std_._cdf._erf
namespace nilnul.num.real.ext.func_.unary_._erf

{
	/// <summary>
	/// from 0 to x, where x is in [-inf, +inf], so the range is [-1,1]
	/// </summary>
	public class IncompletAboutNil4Dbl
		:
		nilnul.num.real.ext.of_.unary_.OfExt4dblA
	{


		public nilnul.num.real_.PositiveDbl accuracy
		{
			get { return _sqNegExpIncomplete.accuracy; }
		}

		private nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_.OriginatedAround4Dbl _sqNegExpIncomplete;

		public nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_.OriginatedAround4Dbl sqNegExpIncomplete
		{
			get { return _sqNegExpIncomplete; }
			set { _sqNegExpIncomplete = value; }
		}

		public IncompletAboutNil4Dbl(nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_.OriginatedAround4Dbl accuracy)
		{
			_sqNegExpIncomplete = accuracy;
		}

		public IncompletAboutNil4Dbl(nilnul.num.real_.PositiveDbl accuracy) : this(
			new sq_.neg_.exp.incomplete_.OriginatedAround4Dbl(accuracy)
		)
		{
		}

		public IncompletAboutNil4Dbl(double v) : this(new real_.PositiveDbl(v))
		{
		}


		/// <summary>
		/// an integral of exp(-t^2)|<see cref="Integrand4dbl"/>; from 0 to x;
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public  double _op_0extNonneg(double par)
		{
			return _op_0ext(par);
			//return 2/ nilnul.num.real_.unison_.tau.half._SqrtX.AsDbl * _sqNegExpIncomplete._op_0ext(par);
			/// todo:
			//throw new NotImplementedException();
		}

		public override double _op_0ext(double par)
		{
			return 2/ nilnul.num.real_.unison_.tau.half._SqrtX.AsDbl
				* _sqNegExpIncomplete._op_0ext(par);
			/// todo:
			//throw new NotImplementedException();
		}


		

	}
}
