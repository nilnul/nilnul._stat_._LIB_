using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_._finite_
{
	/// synnonym to <see cref="borel_.ICdfable"/>; but in <see cref="borel_.ICdfable"/>, the probability mass is the cumulated density; 
	/// <summary>
	/// cumulative mass function;
	/// same semantics for <see cref="dist_.borel_._pdfable_."/>
	/// </summary>
	public interface ICmf
		:
		stat.dist_.borel_._discrete_.ICmf
		//,nilnul.stat.dist_._borel_.ICpf
	{
	}


}
