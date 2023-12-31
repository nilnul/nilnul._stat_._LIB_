using nilnul.num;
using nilnul.num.real.bound_;
//using nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_.bySeries_._unisign._series;
using nilnul.num.real.stream.cumulus_;
using nilnul.num.real_;
using nilnul.obj._stream_._next;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdfable_.normal_._std_.cdf_.bySeries_._calculi8partwise.series
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

			var residue=boxed.toBeCumulated / (1-_nextRate); // decreases

			return num.real.range_.Closed4dbl.OfBase9drift(
				new num.Real4dbl(
					boxed.current
				)
				,
				new Real4dbl(
					residue
				)

			).toBound();
		}
		//double _argTwice;
		//double _fourArgSq;

		double _argSq;
		public double argSq {
			get { return _argSq; }
		}

		int _k_ofSeries = 0;
		//int _k_ofSlider = -1;

		double _getNextRate() {
			return 
				this._argSq/
				(2 * _k_ofSeries + 1);  //note: when series index is 1 , the sliderIndex is 0;
		}
		double _nextRate;
		void _cacheNextRate() {
			 _nextRate=_getNextRate();
		}

		void __tilNextRateLtOne()
		{
			
			while (
				// _fourArgSq 
				///
				//( 2 * k + 3)
				_getNextRate()

				>= 1
			)
			{
				_k_ofSeries++;
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
		void _calc() {
			_cacheNextRate();
			///we need the above;
			_calcCurrent();

		}

		ClosedDbl _current;
		public ClosedDbl current => _current;
		public Converge4dbl(in Series4dbl val) : base(val)
		{
			/// till the denominator gt the par;
			///

			_argSq = val.arg * val.arg;

			/// we cannot compute the <see cref="_getNextRate"/> of the 0th of the underlying slider as the series next
			/// v
			///
			ref Series4dbl series = ref boxed;

			series.moveNext(); //series is also a slider;
			_k_ofSeries++;
			//_k_ofSlider++;

			//var _argTwice = 2 * val.arg;
			//_fourArgSq = 4 * _argSq;// _argTwice * _argTwice;
			__tilNextRateLtOne(); //change k from 0;

			_calc();

		}

		public Converge4dbl(Series4dbl x) : this(in x)
		{
		}


		public Converge4dbl(_series.Slider4dbl slider4dbl) : this(
			new Series4dbl(slider4dbl)
		)
		{
		}

		public Converge4dbl(double val) : this(
			new _series.Slider4dbl(val)
		)
		{
		}



		public void clamp(PositiveDblI diameter)
		{
			while (_current.width > diameter.dblen.ee)
			{
				moveNext();
				//k++;
			}
			//_calc();


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
			_k_ofSeries++;

			_calc();
		}

		public ClosedDbl next()
		{
			var t = current;
			moveNext();
			return t;

		}
	}
}
