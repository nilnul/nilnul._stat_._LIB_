using System;
using System.Collections.Generic;
using System.Linq;
using Measure = nilnul.prob._measure.Double;

namespace nilnul.prob
{
	[Obsolete()]
	public class FiniteDD:FiniteD<double,nilnul.num.real.EqDbl>
	{

		

		public FiniteDD(
			Dictionary<double,Measure> dict
		):base(dict)
		{

		}

		public double mean() {
			return this.Average(x => x.Key * x.Value);
		}

		static public FiniteDD Create(
			Dictionary<double,double> dict
		) {
			var target = new Dictionary<double, Measure>();

			foreach (var item in dict)
			{
				target.Add(
					item.Key,
					new _measure.Double(item.Value)
				);

			}

			return new FiniteDD(target);
		}
	}



}
