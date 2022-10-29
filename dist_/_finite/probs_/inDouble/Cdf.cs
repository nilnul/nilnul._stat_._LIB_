using nilnul.prob.rationalProb.rationalSample;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LessThan = nilnul.num.rational.order.LessThan;

namespace nilnul.prob.dist._finite.inDouble
{
	public partial class Cdf
	{
		private IEnumerable<double> _probs;

		public IEnumerable<double> probs
		{
			get { return _probs; }
			set {
				Assert(value);
				_probs = value; }
		}

		static public Cdf Pack(Cdf cdf) {
			var list = new List<double>();

			double lastAdded=0;
			

			for (int i=0; i<cdf.probs.Count(); i++)
			{

				if (cdf.probs.ElementAt(i) !=lastAdded)
				{
					lastAdded = cdf.probs.ElementAt(i);
					list.Add(lastAdded);

				}
			}

			return new Cdf( list);

		}


		static public bool Be(IEnumerable<double> probs) {
			var monotone = true;



			return probs.First() >= 0 && probs.Last() == 1 && monotone;
		}
	
		static public void Assert (
			IEnumerable<double> x
			)
		{

			nilnul.obj.AssertX.True(Be(x));

		}


		private Cdf() { }

		public Cdf(
			IEnumerable<double> probs

		)
		{
			this.probs = probs;
		}

		static public Cdf Create(Pmf pmf) {
			var list =new  List<double>();
			var cumulated = 0d;
			foreach (var item in pmf.measures)
			{
				
				list.Add(cumulated+=item._val);
			}
			return new Cdf() { _probs=list };
		}

		public class Packed
		{
			private Cdf _cdf;

			public Cdf cdf
			{
				get { return _cdf; }
				set { _cdf = Cdf.Pack( value); }
			}
			private Packed()
			{


			}

			public Packed(Cdf cdf)
			{
				_cdf=Cdf.Pack(cdf);

			}
			public int randomSelect()
			{
				var randomIndex = _prob.RandomX.NextDouble();
				
				for (int i = 0; i < cdf.probs.Count(); i++)
				{
					if (randomIndex<cdf.probs.ElementAt(i))
					{
						return i;
					}	
				}

				throw new UnexpectedReachException();


			}

			public Cdf.Packed Create(Pmf.Packed pmfPacked) {
				return new Packed() { _cdf= Cdf.Create(pmfPacked.packed)};
			}

		}
	}
}
