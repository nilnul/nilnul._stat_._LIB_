using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rx = nilnul.num.Real;
using nilnul.num.real.ext;
using nilnul.prob_._continuum_;
using nilnul.num;

namespace nilnul.prob_.continuum_
{
	public class Uniform : nilnul.prob_._continuum_.SupportI
	{
		private nilnul.num.real.Bound _support;

		public nilnul.num.real.Bound support
		{
			get { return _support; }
			set { _support = value; }
		}

		public Uniform(
			num.real.Bound span	
		)
		{
			_support = span;
		}

		public Rx density(Rx x) {
			if (_support.contains(x) )
			{
				return ( 1 /  _support.diameter.ToReal());

			}
			return 0;
		}

		public Rx cumulativeDensity(Rx x) {
			if (_support.contains(x) )
			{
				return (x - _support.lower.mark) / _support.diameter;

			}

			if (x < _support.lower.mark)
			{
				return 0;
			}

			return 1;
		}

		public Rx mean { get {
				return _support.center.ToReal();
			} }

		public Rx variance {
			get {
				return nilnul.num.Quotient1.CreateUnit( 12) * _support.diameter.Square().ToReal();
			}
		}

		Interval SupportI.support
		{
			get
			{
				return new Interval(
						new num.real.ext.border.Duo(
							new num.real.ext.Border(
						_support.lower.openFalseCloseTrue
						,
						new nilnul.num.real.ext_.Bare(_support.lower.mark)
								
								)
								,
							new num.real.ext.Border(
								_support.upper.openFalseCloseTrue
								,
								new nilnul.num.real.ext_.Bare(
									_support.upper.mark
									)	
							)
							
							)
				);
				throw new NotImplementedException();
			}
		}
	}
}
