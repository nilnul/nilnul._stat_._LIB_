using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.PointDbl;

namespace nilnul.geometry.planar.triangle
{
	static public class SampleX
	{
		static public PointD Sample(
			nilnul.geometry.planar.TriangleDbl  triangle	
		) {
			var parlgrm =  new nilnul.geometry.planar.polygon_.quadri_.ParlgrmDbl(triangle);

			var sample = nilnul.geometry.planar.parlgrm.SampleX.Sample(parlgrm);
			var edge_ca = triangle.edge_ca();

			var triangleDir = triangle.area();

			var sampleToCa = planar.grad_.arrow.vsPoint._LayoutDblX.Layout(triangle.arrow2nd, sample);

			if (sampleToCa>=0 && triangleDir>=0)
			{
				return sample;
			}
			//find the pivot.
			var pivot = planar.point.co.band_._MidX.Mid(edge_ca);

			return geometry.planar.point.co.band_._MirrorX.Mirror(pivot, sample);

			//todo: find the central point, then get the mirrored point.
		//	throw new NotImplementedException();
		}
	}
}
