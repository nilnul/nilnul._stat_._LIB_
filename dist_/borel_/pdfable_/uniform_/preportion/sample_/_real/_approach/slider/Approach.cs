using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using Quotient = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul._prob.rnd._real._approach.slider
{

	public class Approach : nilnul.num.RealI
	{
		

		public Approach()
		{
			_series1 = new _approach.slider.Series();
		}

		

		private _approach.slider.Series _series1;

		public _approach.slider.Series series1
		{
			get { return _series1; }
			set { _series1 = value; }
		}


		public Nonempty.En bound
		{
			get
			{
				
				return  _series1.accumulated+Nonempty.En.CreateClopen(
					0
					,
					_series1.positionalWeight
				);

				//throw new NotImplementedException();
			}
		}

		public void clamp(Positive1.En diameter)
		{
			while (bound.notSpanLessThan(diameter))
			{

				_series1.moveNext();
			}


		//	throw new NotImplementedException();
		}
	}
}
