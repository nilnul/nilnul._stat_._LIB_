using nilnul.stat.dist_.finite_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_
{
	
	/// <summary>
	/// from discrete measure to continuous measure 
	/// </summary>
	public class Empirical4dbl
	   : nilnul.obj.Box1<
		   nilnul.stat.dist_.finite_.CumulableDbl
	   >
	{
		public Empirical4dbl(CumulableDbl val) : base(val)
		{
		}


		public double cumulativeDensity(double el) {
			var indexRange=nilnul.num.real.sortie._FindX._IndexRange(
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
