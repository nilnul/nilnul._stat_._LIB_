using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.finite
{
	/// <summary>
	/// N products, D unqualified products, now take n, and there are  k unqualified, what's the probability of this event?
	/// </summary>
	public class HyperGeometric
	{
		private uint _total;
		private uint _target;
		private uint _takes;

		public HyperGeometric(uint total, uint target, uint takes) { 
			if(target>total){
				throw new Exception();
			}

			if(takes>total){
				throw new Exception();
			}
			_total = total;
			_target = target;
			_takes = takes;

			
		}

		public uint total {
			get {
				return _total;
			}
		}

		public uint target {
			get {
				return _target;
			}
		}

		public uint take {
			get {
				return _takes;
			}
		}

		

		

		public double densityFunc(uint k) {
			return  Combinate.Eval(target, k)
				*
				 Combinate.Eval(total - target, take - k)
				/
				Combinate.Eval(total, take)
			;
		}



	}
}
