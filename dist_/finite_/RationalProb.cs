using nilnul.prob.discrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.finite
{
	public partial class RationalProb<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{
		private List<T> _samples;

		public List<T> sample
		{
			get { return _samples; }
			set { _samples = value; }
		}

		private Dictionary<T,ProbabilityInRational1> _dict;

		public Dictionary<T,ProbabilityInRational1> dict
		{
			get { return _dict; }
			set {

				ProbabilitiesSet.SumIsOnePredicate1.assert(
					value.Select(c => c.Value)
				);

				
				_dict = value; 
			
			}
		}

		public finite.measure.Natural<T> toNaturalMeasure() {

			List<nilnul.num.rational.Fraction140728> probInFractionsOfSameDenominator = nilnul.num.rational.collection.op.SameDenominator.Eval(dict.Values.Select(c => c)).ToList();

			var lcmOfDenom=nilnul.num.natural.collection.op.Lcm.Eval(dict.Select(c=>c.Value.denominator.val));
			//var numSum = probInFractionsOfSameDenominator.Sum(f => (int)(f.numerator));
			var r = new Dictionary<T, int>();

			foreach (var item in dict)
			{
				r.Add(item.Key, (int) ( (item.Value * lcmOfDenom).numerator1));
				
			}

			return new measure.Natural<T>(r);





			
		}
		
		
		public RationalProb(
			Dictionary<T,ProbabilityInRational1> dict	
		)
		{
			this.dict = dict;
		}

		public void purge() {
			foreach (var item in dict)
			{
				if (item.Value==0)
				{
					dict.Remove(item.Key);
				}
				
			}
		}

		public T randomSelect() { 

			//first make probs same deno.

			return toNaturalMeasure().randomSelect();


			throw new NotImplementedException();


		

		}

	}
}
