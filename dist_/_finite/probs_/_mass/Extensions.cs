using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob_._finite._mass
{
	public class Extensions
	{
		static public IEnumerable<decimal> _Eval(params decimal[] numbers)
		{
			var sum = numbers.Sum();
			return numbers.Select(x => x / sum);

		}
		static public IEnumerable<double> _Eval(params double[] numbers)
		{
			var sum = numbers.Sum();
			return numbers.Select(x => x / sum);

		}
		static public IEnumerable<float> _Eval(params float[] numbers)
		{
			var sum = numbers.Sum();
			return numbers.Select(x => x / sum);

		}

		static public IEnumerable<float> _GenerateEvenFloat(int countsPositive)
		{
			for (int i = 0; i < countsPositive; i++)
			{
				yield return 1f / countsPositive;
			}

		}



	}
}
