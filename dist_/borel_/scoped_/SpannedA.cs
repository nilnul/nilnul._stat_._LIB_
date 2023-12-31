using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;
using nilnul.num.real;
using nilnul._prob;
using nilnul.num;

namespace nilnul.prob_._continuum_.cdf_
{
	/// <summary>
	/// not a single point;
	/// </summary>
	public abstract class SpannedA : nilnul.prob_._continuum_.CdfI
	{
		/// <summary>
		/// where measure is not zero.
		/// </summary>

		private nilnul.num.real.Bound _support;

		public nilnul.num.real.Bound support
		{
			get { return _support; }
			set { _support = value; }
		}

		public abstract Measure measureInSupport(R upperBound);



		public Measure measure(R upperBound)
		{
			var pointRel2Support = nilnul.num.real.range._PointRel2RangeX.Eval(upperBound, _support);
			if ( pointRel2Support <0 )
			{
				return Measure.CreateZero();
			}
			if (pointRel2Support ==0)
			{
				return measureInSupport(upperBound);
			}

			return Measure.CreateOne();
		}
	}
}
