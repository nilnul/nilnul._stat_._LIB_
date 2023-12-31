using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat._dist_
{
	/// <summary>
	/// randomly select one specimen; note the <typeparamref name="T"/> is an interval for <see cref="dist_.IBorel"/>
	/// </summary>
	public  interface SampleI<T>
	{
		T sample();

	}

	public abstract class Sample5dblA<T> : SampleI<T>, Invert5dblI<T>
	{
		public T sample()
		{
			return sample(
				nilnul.stat.dist_.borel_.pdfable_.uniform_.prob.sample_._RandomX.Next4dbl()
			);
		}

		public abstract T sample(double x);
	}

}
