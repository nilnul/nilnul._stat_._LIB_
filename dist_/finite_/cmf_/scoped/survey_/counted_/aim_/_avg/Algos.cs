using nilnul.prob.dist._finite._sel._constraint._boundSum._algos;
using nilnul.prob.finite.measures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.finite._sample._constraint._boundSum
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// <seealso cref="nilnul.stat.dist_.borel_._scoped_"/>
	/// 
	/// </remarks>
	/// vs:
	///		<seealso cref="nilnul.stat.dist_.borel_.boundaried.survey_.counted_.aim_.avg_._RandomizeThenNormalizeX"/>
	///			, which is for borel one, whileas this is for finite space;
	public class Algos
	{

		/// <summary>
		/// ByProportionalSelect is prefererable to ByShuffle in that it's specified by the number of the points to be assigned, and need not take into account those empty cells.
		/// </summary>
		/// <param name="averageTargeted"></param>
		/// <param name="sampleCardinal"></param>
		/// <param name="scoreMax"></param>
		/// <returns></returns>
		static public int[] Exe_givenMean(int averageTargeted, int sampleCardinal, int scoreMax)
		{




			return ByProportionalSelect.Exe_givenMean(averageTargeted, sampleCardinal, scoreMax);









		}
		

	}
}
