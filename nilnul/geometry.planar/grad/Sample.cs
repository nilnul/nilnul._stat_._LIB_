using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.PointDbl;
using Rect = nilnul.geometry.planar.polygon_.quadri_.RectD;
using G = nilnul.geometry.planar.GradDbl;//.EdgeD1;

using PointDuo = nilnul.geometry.planar.point.CoD;

namespace nilnul.geometry.planar.grad
{
	static public class SampleX
	{


		static public PointD Sample(this G	duo)
		{
			return geometry.planar.point.SampleX.Sample( nilnul.geometry.planar.grad._DisplaceX.Displace(  duo ))
				+
				duo.Item1
			;
		}

		static public PointD Sample(this nilnul.geometry.planar.grad_.ArrowDbl duo)
		{
			return geometry.planar.point.SampleX.Sample( nilnul.geometry.planar.grad._DisplaceX.Displace(  duo ))
				+
				duo.begin
			;

		}

	}
}
