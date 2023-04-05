using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;

namespace nilnul.math.statistics.distribution
{
	public class FiniteDiscreteDistribution
	{
		private Dictionary<Real,NonnegativeReal> _density;

		public FiniteDiscreteDistribution(decimal[] events, decimal[] probability) {
			
			if(events.Distinct().Count()!=events.Length){
				throw new Exception();
			}

			if(events.Length!=probability.Length){
				throw new Exception();
			}

			if(probability.Any(x=>x<0)){
				throw new Exception();
			}
			if(probability.Sum()!=1){
				throw new Exception();
			}

			for(int i=0;i<events.Length;i++){
				_density.Add(events[i],probability[i]);
			}	


		}
		
	}
}
