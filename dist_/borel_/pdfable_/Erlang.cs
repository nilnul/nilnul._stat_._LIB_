using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_.pdfable_
{
	////// Consider a Poisson Process, X is the time till the n-th events occur.
	/// P(X<=x)=1-P(X>x)=1-Sum (
	///            k=0 -> n-1,
	///            (lamda * x)^k * e^(-lamda *x) / k!
	/// )
	///
	/// <summary>
	/// The sum of n exponential (β) random variables is a gamma (n, β) random variable. Since n is an integer, the gamma distribution is also a Erlang distribution.
	/// </summary>
	public class Erlang: IErlang
	{
		private nilnul.num.real_.PositiveDbl _rate;

		public nilnul.num.real_.PositiveDbl rate
		{
			get { return _rate; }
			set { _rate = value; }
		}

		private nilnul.Num_ofIn _count;

		public nilnul.Num_ofIn count
		{
			get { return _count; }
			set { _count = value; }
		}


		public Erlang(num.real_.PositiveDbl rate, nilnul.Num_ofIn count){
			this._rate = rate;
			this._count = count;
		}

		
	}


}
