using System;
using nilnul.collection.set;
using nilnul.statistics.basic;
using nilnul.number.real;
using System.Linq.Expressions;
using nilnul.function.basic;

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
	public partial class RandomVariable:
		IRandomVariable
	{
		private IExperiment _experiment;
		private Expression<Func<ISamplePoint,IReal>> _rule;

		public RandomVariable(IExperiment experiment,Expression<Func<ISamplePoint,IReal>> rule) {

			///todo: rule's domain must isSuperSetOf experiment's samplespace.
			this._experiment = experiment;
			this._rule = rule;

		}






		#region IFunction<ISamplePoint,IReal> Members

		public ISet<ISamplePoint> domain
		{
			get { return experiment.sampleSpace; }
		}

		public ISet<IReal> range
		{
			get { throw new NotImplementedException(); }
		}

		public Expression<Func<ISamplePoint, IReal>> rule
		{
			get { 
				return _rule; 
				
			}
		}

		#endregion

		#region IRandomVariable Members

		public IExperiment experiment
		{
			get { return _experiment; }
		}

		#endregion
	}//class

	
	
	
}
