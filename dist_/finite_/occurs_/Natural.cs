using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.finite.measure
{
	public partial class Natural<T>
	{
		

		private Dictionary<T,int> _weights;

		public Dictionary<T,int> weights
		{
			get { return _weights; }
			set { _weights = value; }
		}

		public Natural(Dictionary<T,int> x)
		{
			this._weights = x;

		}


		public int totalWeight
		{
			get { return _weights.Sum(x=>x.Value); }
		}
		

		public T randomSelect() {
			var r = new Random();

			var randomIndex= r.Next(totalWeight);

			var measureTotal = 0;
			foreach (var item in weights)
			{

				measureTotal += item.Value;
				if (randomIndex<measureTotal)
				{
					return item.Key;
					
				}

				
			}





			throw new NotImplementedException();		
		}
		


	}
}
