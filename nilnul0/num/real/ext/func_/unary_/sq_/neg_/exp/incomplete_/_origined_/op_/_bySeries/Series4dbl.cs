using nilnul.num.real.bound_;
using nilnul.num.real.stream.cumulus_;
using nilnul.num.real_;
using nilnul.obj._stream_._next;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_._origined_.op_._bySeries._series
{
	public class Series4dbl
		:
		//nilnul.obj.Box_ofIn<
		nilnul.num.real.stream_.slider.Series4dbl
			//>
		//,
		//nilnul.num.real.bound_.closed.stream_.slider_.nested_.Cauchy4dblI
	{
		/// <summary>
		/// this will be manipulated by boxer;
		/// </summary>
		private Slider4dbl _slider;
		//private Series4dbl(Sum4dbl x) : base(x)
		//{
		//}

		public double arg { get {
				return _slider.arg;
			} }
		public Series4dbl(Slider4dbl slider4dbl):base(
			//new real.stream.cumulus_.Sum4dbl
			(slider4dbl)
		)
		{
			
			_slider = slider4dbl;
			//_current = new ClosedDbl( 0, _slider.current);
		}

		public Series4dbl(double val) : this(
			new Slider4dbl(val)
		)
		{
		}


	
	}
}
