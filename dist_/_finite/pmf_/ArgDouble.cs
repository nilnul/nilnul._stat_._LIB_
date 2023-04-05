using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.finite
{
	/// <summary>
	/// 
	/// </summary>
	/// tODO: finitedistribution
	
	public class Pmf
	{
		private IEnumerable<_prob.InDouble> _measures;

		public IEnumerable<_prob.InDouble> measures
		{
			get { return _measures; }
			set {
				Assert(value);
				_measures = value;
			}
		}


		public Pmf(IEnumerable<double> measures) :this(measures.Select(t=>new _prob.InDouble(t))) { }


		public Pmf(IEnumerable<_prob.InDouble> measures)
		{

			
			this.measures = measures;
		}



		static public Pmf Pack(Pmf measures) {
			return new Pmf(measures.measures.Where(x => x._val != 0));
		}

		static public void Assert(IEnumerable<double > measures) {
			AssertInRange(measures);
			AssertSumIsZero(measures);



		}

		static public void Assert(IEnumerable<_prob.InDouble> measures) {
			AssertSumIsZero(measures);



		}
	static public void AssertSumIsZero(IEnumerable<double> measures) {

			nilnul.obj.AssertX.True(measures.Sum() == 0);

		}

		static public void AssertSumIsZero(IEnumerable<_prob.InDouble> measures) {

			nilnul.obj.AssertX.True(measures.Select(t=>t._val).Sum() == 0);

		}

		static public Pmf Create_froWeights(IEnumerable<double> weights_nonNegPostive) {
			var sum = weights_nonNegPostive.Sum();
			return new Pmf(weights_nonNegPostive.Select(t => t / sum));
		}

	static public void AssertInRange(IEnumerable<double > x) {
			x.ForEach(t=>_prob._measure.MeasureInDouble.AssertIsMeasure(t));
		}

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
				return new Packed() { _packed=Pmf.Create_froWeights(weights_allPostive)};
		



			}


			static public Packed Create_froWeights(IEnumerable<double> weights_allNonNeg)
			{
				return new Packed() { _packed=Pmf.Create_froWeights(weights_allNonNeg)};
		



			}





		}


	}


	
}
