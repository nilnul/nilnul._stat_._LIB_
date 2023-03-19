using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;

namespace nilnul.math.statistics
{
	public class Mean:Real
	{
		public RandomVariable randomVariable;
		public Mean(RandomVariable randomVariable) {
			this.randomVariable = randomVariable;
			
		}


		private bool? _exist;
		public bool? exist{
			public get {
				return _exist;
			}
			public set {
				_exist = value;

			}
		}
	}
}
