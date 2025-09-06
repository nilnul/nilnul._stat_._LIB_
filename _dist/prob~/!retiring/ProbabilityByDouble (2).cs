using System;
using System.Net;


namespace nilnul.num.real
{
	/// <summary>
	/// a number in [0,1]
	/// </summary>
	public partial struct Probability
	{
		double _val;

		public double val
		{
			get
			{
				return _val;
			}
			set
			{
				if (val < 0 || val > 1)
				{
					throw new ArgumentOutOfRangeException();

				}
				else
				{
					_val = val;
				}

			}
		}




		public Probability(double val)
			: this()
		{

			// this.val = val;
			this._val = val;
		}

		public static bool Has(double val)
		{

			if (val < 0 || val > 1) { return false; }
			else
			{
				return true;
			}

		}

		public static void Assert(double val) {

			nilnul.bit.Assert.Eval(Has(val));
		}



	}
}
