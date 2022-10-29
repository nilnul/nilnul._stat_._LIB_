using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.statistics
{
	public class FiniteDiscreteDistribution<T>
	{
		private Dictionary<T,decimal> _density;
		public Dictionary<T, decimal> density {
			get {
				return _density;
			}
			set {

				if (value.Count == 0)
				{
					throw new Exception();
				}



				if (value.Values.Any(x => x < 0 || x > 1))
				{
					throw new Exception();
				}



				if (value.Values.Sum() != 1)
				{
					throw new Exception();

				}

				this._density = density;
			
			}
		}

		public FiniteDiscreteDistribution(Dictionary<T,decimal> density) {

			this.density = density;


		}
		
	}
}
