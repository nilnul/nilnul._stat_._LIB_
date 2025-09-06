using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.real;
using nilnul.set.interval;
using nilnul.statistics.distributions;


namespace nilnul.statistics.hypothesisTest
{
	/// <summary>
	/// to test a normal population which has known variance.
	/// </summary>
	public interface IZtest { 
	}


	public class ZTest:IZtest
	{
		static public double Z(double populationVarianceSqrt,double populationMean0,uint sampleSize,double sampleMean,double conspicuousLevel) { 
			return (sampleMean-populationMean0)/ (populationVarianceSqrt/sampleSize.Sqrt());
		}


		static public IntervalLeftOpenRightInfinite<IReal> RightSide(double populationVarianceSqrt, double populationMean0, uint sampleSize,  double conspicuousLevel)
		{
			return new IntervalLeftOpenRightInfinite<IReal>(
				(Real<double>)
				(
				populationMean0
				+
				(populationVarianceSqrt/sampleSize.Sqrt())
				*
				NormalDistribution.UpperDividePoint(conspicuousLevel)
				)

				);
		}

		
	}
}
