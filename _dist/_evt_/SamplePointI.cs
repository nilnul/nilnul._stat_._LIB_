using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob
{
	public interface SamplePointI{
		



	}


	public interface SampleDI {
		_prob.InDouble measure { get; }
	}


	public class SamplePoint
	{

	}


	public abstract class SampleDA:SampleDI
	{
		private _prob.InDouble  _measure;

		public _prob.InDouble  measure
		{
			get { return _measure; }
			set { _measure = value; }
		}

		public SampleDA(_prob.InDouble measure)
		{
			_measure = measure;
		}
	}



	public interface SamplePointI<T>
	: SamplePointI
	{



	}

	public interface SampleDI<T>:SampleDI {

	}

	public class SampleD<T>
		:
		SampleDA,
		SampleDI<T>
	{

		private T _point;

		public T point
		{
			get { return _point; }
			set { _point = value; }
		}


		public SampleD(T point, _prob.InDouble measure):base(measure)
		{
			_point = point;
		}


	}




}
