using nilnul.num.real.bound_;
using nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_._origined_.op_._bySeries._series;
using nilnul.num.real.stream.cumulus_;
using nilnul.num.real_;
using nilnul.obj._stream_._next;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_._origined_.op_._bySeries.series
{
	/// <summary>
	/// 
	/// </summary>
	public class Converge4dbl
		:
		nilnul.obj.Box_ofIn<
			Series4dbl
		>
		,
		nilnul.num.real.bound_.closed.stream_.slider_.nested_.Cauchy4dblI
	{

		ClosedDbl _getBound()
		{
			return num.real.range_.Closed4dbl.OfBase9drift(
				new num.Real4dbl(
				boxed.current
				)
				,
				new num.Real4dbl(
				boxed.toBeCumulated

				)

			).toBound();
		}
		double _argSq;
		void _tilNextRateLtOne()
		{

			var k = 0;
			while (
				(2 * k + 1) * _argSq
				/
				((k + 1) * (2 * k + 3/*2*/))
				>= 1
			)
			{
				k++;
				boxed.moveNext();
			}

		}

		void _calcCurrent()
		{
			//var t = _calcBound();
			_current = _getBound();

//				num.real.bound_.closed.co_.joint._IntersectX._Intersect_01joint(_current,
//_calcBound()
//				);
		}

		ClosedDbl _current;
		public ClosedDbl current => _current;
		public Converge4dbl(in Series4dbl val) : base(val)
		{
			/// till the denominator gt the par;
			///

			_argSq = val.arg * val.arg;
			_tilNextRateLtOne();
			_current = _getBound();

		}

		public Converge4dbl(Series4dbl x) : this(in x)
		{
		}


		public Converge4dbl(Slider4dbl slider4dbl) : this(
			new Series4dbl(slider4dbl)
		)
		{

			//_slider = slider4dbl;
			//_current = new ClosedDbl( 0, _slider.current);
		}

		public Converge4dbl(double val) : this(
			new Slider4dbl(val)
		)
		{
		}



		public void clamp(PositiveDblI diameter)
		{
			while (Math.Abs(boxed.toBeCumulated) > diameter.dblen.ee)
			{
				boxed.moveNext();
			}
			_calcCurrent();

		}



		//void tilCurrentRateLtOne() {

		//	var k = 0;
		//	while (
		//		(2*k-1) * boxed.arg
		//	)
		//	{

		//	}
		//}


		public void moveNext()
		{
			boxed.moveNext();
			_calcCurrent();
		}

		public ClosedDbl next()
		{
			var t = current;
			moveNext();
			return t;

		}
	}
}
