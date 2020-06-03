using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.PointDbl;
using nilnul.geometry.planar.grad;
using nilnul.geometry.planar.polygon_.quadri_;

namespace nilnul.geometry.planar.parlgrm
{
	

	static public class SampleX
	{

		static public PointD Sample (nilnul.geometry.planar.polygon_.quadri_.ParlgrmDbl parlgrm)
		{
			
			return parlgrm.arrow0th.Sample()+  parlgrm.arrow1st.Sample() - parlgrm.b ;
				
		}

		public static PointD Sample(RectD rect)
		{
			return Sample(new ParlgrmDbl(rect.a,rect.b,rect.c) );
		}
	}



}
