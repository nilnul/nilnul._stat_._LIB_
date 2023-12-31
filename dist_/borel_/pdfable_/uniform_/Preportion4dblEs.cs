using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_.pdfable_.uniform_
{
	public  class Preportion4dblEs
	{

		static  ConcurrentBag<Preportion4dbl> _Instances = new ConcurrentBag<Preportion4dbl>();
		static  object _Lock=new object();
		static public Preportion4dbl Get0th() {
			lock (_Lock) {
				if (_Instances.Any())
				{
					return _Instances.First();
				}
				var r = new Preportion4dbl();
				_Instances.Add( r);
				return r;
			}
		}

		static public Preportion4dbl Get1st() {
			lock (_Lock) {
				const int expectedTotal = 2;

				if (_Instances.Count<expectedTotal)
				{
					for (int i = _Instances.Count; i < expectedTotal; i++)
					{
						var r = new Preportion4dbl();
						_Instances.Add( r);

					}
					return _Instances.Last();
				}
				return _Instances.ElementAt(1);
			}
		}
		static public Preportion4dbl Get(int index) {
			lock (_Lock) {
				
				if (_Instances.Count<=index)
				{
					for (int i = _Instances.Count; i <=index; i++)
					{
						var r = new Preportion4dbl();
						_Instances.Add( r);

					}
					return _Instances.Last();
				}
				return _Instances.ElementAt(index);
			}
		}



	
	}
}
