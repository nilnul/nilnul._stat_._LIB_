using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_
{
	public  interface Borel4dblI
		:
		_borel_.Cdf4dblI
		,
		_borel_.prob_.OfExt4DblI
		//,
		//_borel_.Sample4dblI
		,
		DistI<double>
		,
		IBorel
	{

		
		



	}
}
