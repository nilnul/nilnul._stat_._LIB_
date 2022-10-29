using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.Point4dbl;
//using Rect = nilnul.geometry.planar.zone_.RectD;
using G = nilnul.geometry.planar.grad_.Step4dbl;//.EdgeD1;

using PointDuo = nilnul.geometry.planar.point.CoD;

namespace nilnul.geometry.planar.grad
{
	static public class SampleX
	{


		static public PointD Sample(this G	duo)
		{
			return geometry.planar.point.SampleX.Sample( nilnul.geometry.planar.grad._DisplaceX.Displace(  duo ).point)
				+
				duo.Item1
			;
		}

		static public PointD Sample(this nilnul.geometry.planar.grad_.skid_.ByPoints4Dbl duo)
		{
			return geometry.planar.point.SampleX.Sample( nilnul.geometry.planar.grad._DisplaceX.Displace(  duo ).point)
				+
				duo.begin
			;

		}

	}
}
