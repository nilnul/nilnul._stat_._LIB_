using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.prob_.trivia.sample_.shuffle_
{
	public  class NoPlaceBack
	{


		static public IEnumerable<T> Exe<T>(IEnumerable<T> elements) {

			return Exe(elements.ToList());
		}
	



		public static IEnumerable<T> Exe<T>(List<T> array)
		{
			return Exe(array, new Random());
		}

		public static IEnumerable<T> Exe<T>(List<T> array,Random random)
		{
			var len = array.Count;
			while (len>0)
			{
				var drew = random.Next(len);
				yield return array[drew];
				array.RemoveAt(drew);
				len--;

			}
			
		}

	}
}
