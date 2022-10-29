using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.egal.uncertainty.measure_
{
	public class Bit
		:
		IMeasure
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="n">how many options.</param>
		/// <returns></returns>
		static public double Uncertainty_cardinalityAssumePositive(int n) {
			return Math.Log(n, 2);
		}
	}
}
