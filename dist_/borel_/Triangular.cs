using nilnul.num.real.ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_
{

	internal abstract class Triangular4dblA
		:
		stat.dist_.Borel4dblI
	{
		public abstract double cumulatedProb(double upperBound);
		public abstract double prob(Bound4dbl sample);
		public abstract double sample();
	}
}
