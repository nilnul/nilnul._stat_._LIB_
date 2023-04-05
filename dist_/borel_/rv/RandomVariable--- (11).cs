using System;
using nilnul.math.complex.real;
using nilnul.math.set;
using nilnul.math.statistics.operators;
using nilnul.function;
using nilnul.number.real;
using nilnul.statistics.basic;



namespace nilnul.statistics.randomVariable
{
	


	/// <summary>
	/// RandomVariable=x is an event, which includes some sample points in the samplespace, so when it takes a value, it's a subset of sampleSpace.
	/// 
	/// Every R.V. value corresponds to an event, but not every event corresponds to a value of the RandomVariable; e.g., an event might corresponds to two values; the CertainEvent contains all the values.
	/// So all the values corresponds to the CertainEvent.
	/// 
	/// RandomVariable is a function; it's domain is the samplePoints of the sampleSpace, thought it can take same value for different samplePoints.
	/// 
	/// </summary>
	/// <remarks>Random variable X: function from sample space to the real numbers.
	/// –Discrete or Continuous
	/// Can have several random variables defined on the same sample space.
	/// </remarks>
	/// 
	public class RandomVariable:IRandomVariable {

		private Mean _mean;
		public Mean mean{
			get {
				if( _mean==null){
					_mean = new Mean(this);
				}
				return _mean;
				
			}
		}

		public virtual distribution.Distribution distribution{
			get {
				return this["distribution"];
			}
			set {
				this["distribution"] = value;
			}
		}
		

		public RandomVariable power(RandomVariable exponent) {
			return new Power(this, exponent);
		}

		public RandomVariable squared() {
			return power(2);
		}

		static public RandomVariable operator ^(RandomVariable x,RandomVariable y){
			return new Power(x, y);
		}
		

		static public RandomVariable operator -(RandomVariable x,RandomVariable y){
			
			Expression e=new Expression();
			
			e.stream.Add(x);
			e.stream.Add("-");
			e.stream.Add(y);
			
			RandomVariable r=new RandomVariable();

			r["value"]=e;
			
			return r;
		}
		
		static public RandomVariable operator -(RandomVariable x,math.Num y)
		{
			
			Expression e=new Expression();
			
			e.stream.Add(x);
			e.stream.Add("-");
			e.stream.Add(y);
			
			RandomVariable r=new RandomVariable();

			r["value"]=e;
			
			return r;
		}

		static public RandomVariable operator *(RandomVariable x, RandomVariable y){
			RandomVariable r=new RandomVariable();
			Expression e=new Expression();
			e.add(x);
			e.add("*");
			e.add(y);
			r["value"]=e;
			return r;

		}

		static public RandomVariable operator /(RandomVariable x, RandomVariable y)
		{
			return new Divide(x, y);
			

		}


		
	
	}//class

	static public class RandomVariableS_Extension {
		static public bool Indenpendanc(this RandomVariable[] randomVariables) {
			return null;
		}
	}
	
	
}
