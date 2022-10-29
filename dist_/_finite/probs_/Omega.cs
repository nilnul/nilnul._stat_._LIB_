using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M= nilnul.prob._measure.Double;


namespace nilnul.prob.measure
{
	public class OmegaD
	{

		private IEnumerable<_measure.Double> _measures;

		public IEnumerable<M> measures
		{
			get { return _measures; }
			set {
				AssertSumIsOne(value);
				_measures = value;

			}
		}

		

		public OmegaD(IEnumerable<M> measures)
		{

			this.measures = measures;
		}

		public void purge() {
			_measures = _measures.Where(a=>a._val>0);
		}


		static public void AssertSumIsOne(IEnumerable<M> measures)
		{

			nilnul.obj.AssertX.True(measures.Select(t => t._val).Sum() == 1);

		}

		static public IEnumerable<M> EnsureSumIsOne(IEnumerable<M> measures)
		{
			nilnul.AssertX.True(measures.Select(t => t._val).Sum() ==1);
			return measures;

		}




	}
}
