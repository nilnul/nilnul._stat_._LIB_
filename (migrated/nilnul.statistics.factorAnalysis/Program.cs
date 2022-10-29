using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.statistics.factorAnalysis;
using nilnul.statistics.distribution;
using nilnul.set;


namespace nilnul
{
	public class Program
	{
		public static void Main() {
			//UnifactorAnalysis u = new UnifactorAnalysis(
			//    );
			//u.observations = new double[][] {
			//    new []{.236,.238,.248,.245,.243}, 
			//    new []{.257,.253,.255,.254,.261},
			//    new []{.258,.264,.259,.267,.262}
			//};

			////Neighborhood<int> n = new Neighborhood<int>(2, 3);

			//Console.WriteLine(u.meanDifferenceConfidenceInterval(0,2,.95));

			Console.WriteLine(
				TDistribution.UDP(2.8453,20)
				);

			
			Console.Read();

		}
	}
}
