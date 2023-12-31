using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prob4dbl = nilnul.stat.dist_.borel_.pdfable_.uniform_.Prob4dbl;

namespace nilnul.stat.dist_.borel_.pdfable_.uniform_
{
	static public class _Prob4dblEsX
	{

		static ConcurrentBag<Prob4dbl> _Instances = new ConcurrentBag<Prob4dbl>();
		static object _Lock = new object();
		static public Prob4dbl Get0th()
		{
			lock (_Lock)
			{
				if (_Instances.Any())
				{
					return _Instances.First();
				}
				var r = new Prob4dbl(
					dist.survey_._RndsX.Get1st() /// the 0th is already take by <see cref="Prob4dbl.StaticInstance"/>
					,
					dist.survey_._RndsX.Get(2)

				);
				_Instances.Add(r);
				return r;
			}
		}
		static public Prob4dbl Get(int index)
		{
			lock (_Lock)
			{
				if (_Instances.Count <= index)
				{
					for (int i = _Instances.Count; i <= index; i++)
					{
						var r = new Prob4dbl(
							dist.survey_._RndsX.Get(2 * index + 1)
							,
							dist.survey_._RndsX.Get(2 * index + 2)

						);
						_Instances.Add(r);

					}
					return _Instances.Last();
				}
				return _Instances.ElementAt(index);
			}
		}

		static public Prob4dbl Get1st()
		{
			return Get(1);
		}




	}
}
