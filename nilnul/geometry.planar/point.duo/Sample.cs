using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.geometry.planar.point.duo
{
	public class Sample
	{


		public PointDbl Eval(planar.point.CoD	duo)
		{
			return geometry.planar.point.SampleX.Sample( nilnul.geometry.planar.grad._DisplaceX.Displace(duo)  ) +duo.Item1;
		}



	}
}
