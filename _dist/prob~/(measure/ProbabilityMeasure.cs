using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.set;
using nilnul.math.complex.real;

namespace nilnul.math.statistics
{
	public class ProbabilityMeasure:Measure
	{
	
		public ProbabilityMeasure(SigmaAlgebra sigma,Func<Set,NonnegativeReal> func) { 
			if(
				func(new Set())==0

				&&

				func(sigma.universal)==1

				&&

				
			){
			}

		}

		static public bool Is(SigmaAlgebra sigma, Func<Set, NonnegativeReal> func)
		{
			foreach (List<Set> subsets in sigma.Subsets()) { 
				subsets.
				

			}

		}
		static public bool IsMutual(List<Set> sets) { 
			foreach(Set s in sets){
				if(s){
				}
			}

		}
	}
}
