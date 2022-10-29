using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.Point4dbl;
using nilnul.geometry.planar.grad;
using nilnul.geometry.planar.zone_;
//using nilnul.geometry.planar.zone_.polygon_.tetra_;
using nilnul.geometry.planar.cycle_.gon_.tetra_;
using nilnul.geometry.planar.facet_;

namespace nilnul.geometry.planar.parlgrm
{
	

	static public class SampleX
	{

		static public PointD Sample (ParlgrmDbl parlgrm)
		{
			
			return parlgrm.arrow0th.Sample()+  parlgrm.arrow1st.Sample() - parlgrm.b ;
				
		}

		public static PointD Sample(RectD rect)
		{
			return Sample(new ParlgrmDbl(rect.a,rect.b,rect.c) );
		}
	}



}
