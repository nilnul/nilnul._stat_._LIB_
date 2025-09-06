namespace nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_.bySeries_._unisign._series
{
	public class Slider4dbl : nilnul.num.real.stream_.Slider4dblA
	{
		
		num.real.stream_.slider_.geometric_.pon_.Odd4dbl _geometricOdd;

		num.stream_.slider_.odd.to_.each_._dblFactorial.Ret _refac = new num.stream_.slider_.odd.to_.each_._dblFactorial.Ret();


		void _calc() {
			_current = _geometricOdd.current
				/ 
					(double)_refac.current.en 
				;
			

		}

		private double _arg;
		public double arg { get { return _arg; } }
		//private double _argSq;
		//public double argSq { get { return _argSq; } }

		double _argTwice;

		public double argTwice { get { return _argTwice; } }
		public Slider4dbl(double x)
		{
			_arg = x;
			_argTwice = 2 * x;
			//_argSq = x * x;
			_geometricOdd = new stream_.slider_.geometric_.pon_.Odd4dbl(
				_argTwice
			);
			_calc();

		}



		private double _current;

		public override double current => _current;

		public override void moveNext()
		{
			_geometricOdd.moveNext();
			_refac.moveNext();
			_calc();

		}
	}
}
