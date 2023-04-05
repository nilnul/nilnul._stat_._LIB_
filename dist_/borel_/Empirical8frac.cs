using nilnul.stat.dist_.finite_.cmf_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_
{

	public class Empirical8frac
	   : nilnul.obj.Box1<
		   nilnul.stat.dist_.finite_.cmf_.Frac2frac
	   >
	{
		public Empirical8frac(Frac2frac val) : base(val)
		{
		}


		public nilnul.num.Quotient1 cumulativeDensity(nilnul.num.Quotient1 el) {
			var indexRange=nilnul.num.quotient.sortie._FindX._IndexRange_assumeSortie(
				this.boxed.boxed.Keys,
				el
			);

			if (indexRange.Item1 is null)
			{
				return 0;
			}
			if (indexRange.Item2 is null)
			{
				return 1;
			}


			var lower = this.boxed.boxed.Keys.ElementAt((int)(indexRange.Item1));
			if (indexRange.Item1 == indexRange.Item2)
			{
				return this.boxed.cumulativeDensity(
					lower
				);
			}

			var upper = this.boxed.boxed.Keys.ElementAt((int)(indexRange.Item2));

			return this.boxed.cumulativeDensity( lower)
				+
				(
					this.boxed.cumulativeDensity(
						lower
					)
					-
					this.boxed.cumulativeDensity(
						upper

					)
				)
				*
				(
					el-lower
				)
				/
				(upper-lower)

				;

		}

	}
}
