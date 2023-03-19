using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.set;
using nilnul.linearAlgebra;

namespace nilnul.statistics.hypothesisTest
{
	public interface IObservations:IElement {
 
	}
	public class Observations:Element

		,IObservations
	{
		public double mean {
			get {
				return this["mean"] ?? points.Column(0).Average();
			}
			set {
				this["mean"] = value;

			}
		}

		public double[,] points {
			get {
				return (double[,])this["points"];
			}
			set {
				this["points"] = value;
			}
		}

		


		
		
	}
}
