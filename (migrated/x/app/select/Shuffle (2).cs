using System;
using System.Net;
using System.Collections.Generic;
using nilnul.alg.shuffle;

namespace nilnul.algorithm
{
	public partial class Shuffle
	{


		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <remarks>see wikipedia for the explanation of the algorithm.</remarks>
		static public void Eval<T>(List<T> list)
		{

			T blankedOut;

			Random r = new Random();

			int selected;

			for (int blank = list.Count - 1; blank >= 1; blank--)
			{
				selected = r.Next(blank + 1);

				blankedOut = list[blank];
				list[blank] = list[selected];
				list[selected] = blankedOut;

			}
		}

		static public void Eval<T>(T[] list)
		{

			T blankedOut;

			Random r = new Random();

			int selected;

			for (int blank = list.Length- 1; blank >= 1; blank--)
			{
				selected = r.Next(blank + 1);

				blankedOut = list[blank];
				list[blank] = list[selected];
				list[selected] = blankedOut;

			}
		}


		public static void KnuthShuffle<T>(T[] array)
		{
			System.Random random = new System.Random();
			for (int i = 0; i < array.Length; i++)
			{
				int j = random.Next(array.Length);
				T temp = array[i];
				array[i] = array[j]; 
				array[j] = temp;
			}
		}


	}
}
