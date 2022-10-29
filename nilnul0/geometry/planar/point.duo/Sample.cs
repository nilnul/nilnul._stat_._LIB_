using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.geometry.planar.point.duo
{
	public class Sample
	{


		public Point4dbl Eval(planar.point.CoD	duo)
		{
			return geometry.planar.point.SampleX.Sample( nilnul.geometry.planar.grad._DisplaceX.Displace(duo) .point ) +duo.Item1;
		}



	}
}
