using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q = nilnul.num.quotient.Q;
using q = nilnul.num.quotient;
using n = nilnul.num;

namespace nilnul.prob._finite
{
	/// <summary>
	/// Suppose that there is an urn of n different coupons, from which coupons are being collected, equally likely, with replacement. What is the probability that more than t sample trials are needed to collect all n coupons? An alternative statement is: Given n coupons, how many coupons do you expect you need to draw with replacement before having drawn each coupon at least once?
	/// </summary>
	public class CouponCollection
	{
		private nilnul.num._num.bigint.be.Positive.Asserted _n;

		public nilnul.num._num.bigint.be.Positive.Asserted  n
		{
			get { return _n; }
			set { _n = value; }
		}


		public CouponCollection( num._num.bigint.be.Positive.Asserted n)
		{
			_n = n;
		}

		public Q mean() {
			return  _n.val * q.stream._subtypeS.Harmonic.Singleton[_n.val];
		}

		static public Q Mean(n._num.bigint.be.Positive.Asserted n) {
			return  n.val * q.stream._subtypeS.Harmonic.Singleton[n.val];

		}
		static public Q Mean(int n) {
			return  Mean(new num._num.bigint.be.Positive.Asserted(n));

		}

	}
}
