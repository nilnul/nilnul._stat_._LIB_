namespace nilnul.stat.dist_.borel_.pdfable_.normal_._std_.cdf_.bySeries_._calculi8partwise._series
{
	public class Slider4dbl : nilnul.num.real.stream_.Slider4dblA
	{
		
		num.real.stream_.slider_.geometric_.pon_.Odd4dbl _geometric;

		num.stream_.slider_.odd.to_.each_._dblFactorial.Ret _factorial = new num.stream_.slider_.odd.to_.each_._dblFactorial.Ret();


		void _calc() {
			_current = _geometric.current
				/ 
					(double)_factorial.current.en 
				;
			

		}

		private double _arg;
		public double arg { get { return _arg; } }

		//double _argTwice;

		//public double argTwice { get { return _argTwice; } }
		public Slider4dbl(double x)
		{
			_arg = x;
			//_argTwice = 2 * x;
			_geometric = new nilnul.num.real.stream_.slider_.geometric_.pon_.Odd4dbl(_arg);
			_calc();

		}



		private double _current;

		public override double current => _current;

		public override void moveNext()
		{
			_geometric.moveNext();
			_factorial.moveNext();
			_calc();

		}
	}
}
