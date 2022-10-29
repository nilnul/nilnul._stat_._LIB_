using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.function;
using nilnul.number.real;
namespace nilnul.statistics.randomVariable
{

	/// <summary>
	/// Note that randomVariables can take any real number values, though in some place the probability is 0.
	/// For a discrete random variable, designated values are taken for all the possible outcomes; in this case, we say that the random variable takes all the other values for an Impossible Event.---------not right
	/// Discrete random can take designated values. But we define the distribution function as X <=x. So though X can only be a few values, x can take all values in the real domain.
	/// 
	/// 
	/// </summary>
	public interface IDensityFunction:IFunction<IReal,IReal> { 

	}
	public class DensityFunction:IDensityFunction
	{

	}
}
