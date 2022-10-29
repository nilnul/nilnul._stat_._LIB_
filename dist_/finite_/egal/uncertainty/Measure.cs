using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.egal.uncertainty
{
	///<see cref="nameof(Comp)"/> defines a function for comparsion. But it's not a measure, as it is not conformant to the requirment of "Sigma Summable" for measure.
	/// We need to find a measure, U(n) where n is the count of options (n is positive natural num), which according to defintion must:
	///		1) U(1) = 0
	///		2) strict increasing
	///		3) U(mn) = U(m) +U(n)
	///			as we can sect a choice of mn options  by: first group the options into m groups, then in each group we have n members.
	///			thus the choice is sected into two disjoint choices:
	///				choice from m groups
	///				and choice from n members.
	///	only Log(a, x) fit. Not a must be gt one, as we need it to be monotonically growing.
	///		for simplicity and for consistency with binary computer(including binary storage unit of bit)
	///			we let a =2. Then the unit of uncertainty is also called bit.
	///			some, especially mathematicians might choose a = e. The unit of uncertainty is then called nat(natural digit).
	/// <summary>
	/// this is a measure of uncertainty
	/// </summary>
	public interface IMeasure
	{
	}
	public class Measure
	{

	}
}
