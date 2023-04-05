namespace nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_._origined_.op_._bySeries._series
{
	public class Slider4dbl : nilnul.num.real.stream_.Slider4dblA
	{
		bit.stream_.slider_.alter_.OneNil _sign = new bit.stream_.slider_.alter_.OneNil();
		num.real.stream_.slider_.geometric_.pon_.Odd4dbl _geometric;//= new stream_.slider_.geometric_.pon_.Odd4dbl();

		num.stream_.slider_.Factorial _factorial = new num.stream_.slider_.Factorial();

		num.stream_.slider_.Odd1 _odd = new num.stream_.slider_.Odd1();

		void _calc() {
			var noSign = _geometric.current
				/ (
					((double)_factorial.current.en) * (double)(_odd.current.en )
				);
			_current = _sign.current ? noSign : -noSign;

		}

		private double _arg;
		public double arg { get { return _arg; } }
		public Slider4dbl(double x)
		{
			_geometric = new stream_.slider_.geometric_.pon_.Odd4dbl(x);
			_arg = x;
			_calc();

		}



		private double _current;

		public override double current => _current;

		public override void moveNext()
		{
			_sign.moveNext();
			_geometric.moveNext();
			_factorial.moveNext();
			_odd.moveNext();
			_calc();

		}
	}
}
