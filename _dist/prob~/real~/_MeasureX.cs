using R = nilnul.num.RealI;

namespace nilnul._prob
{
	/// <summary>
	/// [0,1]
	/// </summary>
	///

	public class _MeasureX
	{
		static public bool IsInRange(R r ) {
			return  nilnul.num.real.bound_._ClosedX.Bound(0,1).contains(r);
		}

		static public void Assert(R r) {
			 nilnul.AssertX.True( IsInRange(r));
		}


	}
}
