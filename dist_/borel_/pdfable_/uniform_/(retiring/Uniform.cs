using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rx = nilnul.num.RealI;
using nilnul.num;
using nilnul.num.real.ext;
using nilnul.prob_._continuum_;

namespace nilnul.prob.continuum_
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
			if (
				
				_support.contains(x)

				)
			{
				return Rx.Div( 1 , _support.diameter);

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
				return _support.Center().ToX();
			} }

		public Rx variance {
			get {
				return nilnul.num.quotient.all.X.QDiv(1, 12) * _support.diameter.Square1();
			}
		}

		Interval SupportI.support
		{
			get
			{
				return new Interval(
						new num.real.ext.border.Duo(
							new Border(
						_support.lower.openFalseCloseTrue
						,
						new nilnul.num.real.ext_.Bare(_support.lower.mark)
								
								)
								,
							new Border(
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
