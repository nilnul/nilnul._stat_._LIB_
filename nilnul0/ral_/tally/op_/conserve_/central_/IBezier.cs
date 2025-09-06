using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.ral_.tally.op_.conserve_.central_
{
	/// <summary>
	/// use 4 control points.
	/// Then for time t:
	///		move the inner point of each of the 3 segment from start
	///		connect the moving inner points, and move the inner point of one of the two connecting segment;
	///		recursively connect the inner point of the connecting segment, and move a point from start 
	///		
	///		
	/// </summary>
	/// vs:
	///		<see cref="nilnul.geometry.planar.curl_"/>
	///		<see cref="nilnul.geometry.planar.curve_.bezier_"/>
    class IBezier
    {
    }
}
