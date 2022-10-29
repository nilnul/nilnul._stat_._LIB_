using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient.bound_;
using Quotient = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul._prob.rnd._real

{

	/// <summary>
	/// this infact is not an approach but an apporch randomizer for it contains random factors in the process to approach to the limit whileas a normal approach will definitely approach to a constant limit.
	/// 
	/// </summary>
	public class Approach : nilnul.num.RealI
	{
		

		public Approach()
		{
			_series1 = new _approach.rndStreamWtSlider.Series();
		}

		

		private _approach.rndStreamWtSlider.Series _series1;

		

		public Closed current { 
			get
			{
				return nilnul.num.quotient.bound_.closed.op_.unary_._ShiftX.Op( new num.Quotient1( _series1.accumulated.numerator, _series1.accumulated.denominator ), new Closed(
					0
					,
					new num.Quotient1(
					_series1.positionalWeight.numerator
					,
					_series1.positionalWeight.denominator

					)
				));

				//throw new NotImplementedException();
			}
		}


		public void squeeze(num.quotient_.Positive1 diameter)
		{
			while (current.notIsDiameterLe(diameter))
			{

				_series1.moveNext();
			}


		//	throw new NotImplementedException();
		}

		
	}
}
