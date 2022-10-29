using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using nilnul.number.collection;
using nilnul.calculus;

namespace nilnul.statistics
{
	public partial class GeneralizedBetaDistribution
		
	{
		private ClosedNonemptyDoubleInterval _domain;

		public ClosedNonemptyDoubleInterval domain {

			get {
				return _domain;
			}

			set {
				_domain = value;
			}
		
		}

		public double lowerBound {

			get {
				return _domain.lower;
			}
		
		}
		public double upperBound {

			get {
				return _domain.upper;
			}
		
		}
		private double _alpha;
		public double alpha
		{
			get { return _alpha; }
			set
			{
				if (value < 0)
				{
					throw new Exception();
				}
				else
				{
					_alpha = value;
				}
			}
		}
		private double _beta;
		public double beta
		{
			get
			{
				return _beta;
			}
			set
			{

				if (value < 0)
				{
					throw new Exception();
				}
				else
				{
					_beta = value;
				}

			}
		}
		public GeneralizedBetaDistribution(ClosedNonemptyDoubleInterval domain, double alpha, double beta)
		{
			this.alpha = alpha;
			this.beta = beta;
			this.domain = domain;

		}
		public GeneralizedBetaDistribution(double lower,double upper,double alpha,double beta )
		{
			this.alpha = alpha;
			this.beta = beta;
			this.domain = new ClosedNonemptyDoubleInterval(lower, upper);

		}

		public double density(double x) {

			if (domain.contains(x))
			{
				return Math.Pow((x-lowerBound),alpha-1)*Math.Pow((upperBound-x),beta-1)/(BetaFunction.Eval(alpha,beta)*Math.Pow(upperBound-lowerBound,alpha+beta-1));
				
			}
			return 0;
		
		}

	}
}
