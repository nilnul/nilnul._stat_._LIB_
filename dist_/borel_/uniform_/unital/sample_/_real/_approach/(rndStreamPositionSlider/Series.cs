using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient;
using Quotient = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul._prob.rnd._real._approach.rndStreamWtSlider
{
	public class Series
		:
		//nilnul.Box1<RndStreamWeightSlider>,
		num.quotient._series_.SeriesI1
	{

		private num.quotient.stream.Series _series;

		public num.quotient.stream.Series series
		{
			get { return _series; }
			set { _series = value; }
		}

		public Series()
		{
			_rndStreamWtSlider=new RndStreamWeightSlider();

			_series = new num.quotient.stream.Series(_rndStreamWtSlider);
		}

		private RndStreamWeightSlider _rndStreamWtSlider;	//this one will be moved by _series. 

		public Quotient positionalWeight
		{
			get { return _rndStreamWtSlider.positionalWeight; }
		}

		public Quotient accumulated
		{
			get
			{
				return _series.accumulated;
				//throw new NotImplementedException();
			}
		}

		

		public void moveNext()
		{
			_series.moveNext();
			//throw new NotImplementedException();
		}
	}
}
