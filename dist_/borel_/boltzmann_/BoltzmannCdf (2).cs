using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.realNumber;
using nilnul.collection.set;


namespace nilnul.randomEvent
{
	public partial class BoltzmannCdf
		:CumulativeDensityFunctionI<NonnegativeRealI>
	{
		public PositiveRealI temperature{
			get;
			set;
		}

		public BoltzmannCdf(PositiveRealI t)
		{
			this.temperature=t;
			
		}

		#region CumulativeDensityFunctionI<NonnegativeRealI> Members

		Func<NonnegativeRealI, ValueAcrossZeroOneI> CumulativeDensityFunctionI<NonnegativeRealI>.cumulativeDensityFunction
		{
			get
			{
				return c =>(
					(
						(ExprI<RealI>)(
							Exp.Call(
								c.Negate()
								.Divide(
									temperature
								)
							)
						)
					).ToValueAcrossZeroOneExpr()
				);
				;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public SetI<NonnegativeRealI> domain
		{
			get
			{
				return Set<NonnegativeRealI>.Instance;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#endregion

	
	}
}
