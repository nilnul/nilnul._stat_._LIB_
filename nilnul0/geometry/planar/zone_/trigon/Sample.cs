using nilnul.geometry.planar.cycle_.gon_.tetra_;
using nilnul.geometry.planar.zone_;
//using nilnul.geometry.planar.zone_.polygon_.tetra_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.Point4dbl;

namespace nilnul.geometry.planar.triangle
{
	static public class SampleX
	{
		static public PointD Sample(
			TriangleDbl  triangle	
		) {
			var parlgrm =  new ParlgrmDbl(triangle);

			var sample = nilnul.geometry.planar.parlgrm.SampleX.Sample(parlgrm);
			var edge_ca = triangle.ee.edge_ca();

			var triangleDir = triangle.ee.area();

			var sampleToCa = planar.grad_.skid.vsPoint._LayoutDblX.Layout(triangle.ee.arrow2nd, sample);

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
