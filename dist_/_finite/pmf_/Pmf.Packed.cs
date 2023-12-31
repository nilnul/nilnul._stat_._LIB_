using System.Collections.Generic;

namespace nilnul.prob.finite
{

	public partial class Pmf
	{
		public class Packed
		{
			private Pmf _packed;

			public Pmf packed
			{
				get { return _packed; }
				set { _packed = value; }
			}
			private Packed() { }

			public Packed(Pmf val)

			{
				_packed = Pmf.Pack(val);

			}


			static public Packed _Create_froWeights(IEnumerable<double> weights_allPostive)
			{
				return new Packed() { _packed = Pmf.Create_froWeights(weights_allPostive) };




			}


			static public Packed Create_froWeights(IEnumerable<double> weights_allNonNeg)
			{
				return new Packed() { _packed = Pmf.Create_froWeights(weights_allNonNeg) };




			}





		}


	}



}
