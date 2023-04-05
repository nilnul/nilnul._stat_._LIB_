using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob_._finite
{
	/// <summary>
	/// the image of the measure. a collection of density
	/// </summary>
	public class Mass
	{


		private nilnul.num.real_.nonNegs.Started _reals;

		public nilnul.num.real_.nonNegs.Started reals
		{
			get { return _reals; }
			//set { _reals = value; }
		}

		public Mass(nilnul.num.real_.nonNegs.Started reals)
		{
			///at least one is positive
			///
			var sum = nilnul.num.real.accumulate_._SumX.Sum_bisect(reals);

			
			nilnul.num.real.be_.positive.Vow.Singleton.vow(sum);


			var str = reals.Select(x =>
				new nilnul.num.real_.Nonneg(
				nilnul.num.real.co_.divisible._DivX.Bind(x, sum)
				)
			);


			_reals = new num.real_.nonNegs.Started(
				str.First()
				,str.Skip(1)
				
			);



			// nilnul.num.real.str.op_._x._SumX.Sum_bisect(reals);
			//_reals = reals;
		}



	}
}
