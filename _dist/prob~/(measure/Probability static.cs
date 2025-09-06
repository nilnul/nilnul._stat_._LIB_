using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval;
using nilnul.number.real;

namespace nilnul.probability
{
	public class Probability
	{
		static public readonly ClosedInterval<IReal> validInterval = new ClosedInterval<IReal>(0, 1);
		static public bool? validProbability (IReal p){
			return validInterval.contains(p);
		}

		
	}
}
