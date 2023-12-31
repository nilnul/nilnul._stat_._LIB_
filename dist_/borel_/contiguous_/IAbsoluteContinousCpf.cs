using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.contiguous_
{
	/// <summary>
	/// this is pdfable;
	/// </summary>
	/// <remarks>
	/// for closed interval, absoluteContinuous means there exists a pdf such that integration of pdf would result this cpf;
	/// </remarks>
	public interface IAbsoluteContinousCpf
		:IContiguous
	{
	}
}
