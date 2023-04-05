using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.set;

namespace nilnul.math.statistics.operators
{
	public class Add 
	{
		public Add(RandomVariable a, RandomVariable b)
		{
			this._operands = new List<Real>();

			if (a is Add)
			{
				this._operands.AddRange(((Add)a)._operands);
				this._operands.Add(b);

			}
			else if (b is Add)
			{
				this._operands.Add(a);
				this._operands.AddRange(((Add)b)._operands);


			}
			else
			{
				this._operands.Add(a);
				_operands.Add(b);
			}
		}
	}//class
}
