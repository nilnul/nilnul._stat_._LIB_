using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.app.select
{


	public partial class WeightedChoose
	{

		static public T Choose<T>(T x, double xWeight, T y, double yWeight) {
			var rnd = new Random();
			var rndNum=rnd.NextDouble();
			var totalWeight = xWeight + yWeight;

			if (rndNum<xWeight)
			{
				return x;
				
			}
			return y;

		}

		static public bool ChooseOrNot(double weight) {
			var rnd = new Random();
			if (rnd.NextDouble() <weight)
			{
				return true;
				
			}
			
				return false;
			
		
		}

		


	}
}
