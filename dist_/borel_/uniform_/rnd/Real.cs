using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;

namespace nilnul._prob.rnd
{
	/// <summary>
	/// this generates a real number:  the terms of the stream are in [0, 1), but the limit is in [0,1] 
	/// Note this is not a real number:
	///		1) the choice everytimes doesn't confluent.
	///	This is neither a "Generator"
	///		:1) the approaches generated don't have same limit.
	///		
	/// This is an approach variable:
	///		1) every times it generates an approach.
	///		2) the generated is not of the same limit.
	/// </summary>
	public class Real : 
		nilnul.num._real.approach.generator.cofinal.eg.single.GeneratorNew<_real.Generator>,
		nilnul.num.RealI
	{


		
	}
}
