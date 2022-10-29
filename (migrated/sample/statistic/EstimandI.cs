using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob.sample.statistic
{
	/// <summary>
	/// An estimand is a parameter which is to be estimated in a statistical analysis. 
	/// For instance, a normally distributed random variable 
	/// X has two parameters, its mean
	/// μ  and variance σ^2. The variance estimator, s^2 = ∑ i = 1...n  (x[i] − x¯)^2 /(n − 1 ) , yields an estimate of 7 for a data set x = { 2, 3, 7 } ; then s^2  is called an estimator of σ^2, and σ^2  is called the estimand.
	/// </summary>
	interface EstimandI
	{
	}
}
