using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Random= System.Random;

namespace nilnul.stat.dist.survey_
{
	/// <summary>
	/// a collection of surveys;
	/// generate more random in addtion to <see cref="_RndX"/>
	/// </summary>
	static public  class _RndsX
	{

		static  ConcurrentBag<Random> _Instances = new ConcurrentBag<Random>();
		static  object _Lock=new object();
		static public Random Get0th() {
			lock (_Lock) {
				if (_Instances.Any())
				{
					return _Instances.First();
				}
				var r = new Random();
				_Instances.Add( r);
				return r;
			}
		}

		static public Random Get1st() {
			lock (_Lock) {
				const int expectedTotal = 2;

				if (_Instances.Count<expectedTotal)
				{
					for (int i = _Instances.Count; i < expectedTotal; i++)
					{
						var r = new Random();
						_Instances.Add( r);

					}
					return _Instances.Last();
				}
				return _Instances.ElementAt(1);
			}
		}
		/// <summary>
		/// used by <see cref="dist_.IMultivariate"/>
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		static public Random Get(int index) {
			lock (_Lock) {
				
				if (_Instances.Count<=index)
				{
					for (int i = _Instances.Count; i <=index; i++)
					{
						var r = new Random();
						_Instances.Add( r);

					}
					return _Instances.Last();
				}
				return _Instances.ElementAt(index);
			}
		}



	
	}
}
