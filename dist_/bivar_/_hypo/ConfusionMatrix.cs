using nilnul.num_.radix_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.bivar_._hypo
{
	/// for an ask in an exam, the ans can be:
	///		cross or checkmark
	///		yea or nay.
	///	when the teacher evaluates the answer, it's in red ink in a cross or checkmark, denoting whether the answer is correct or wrong.
	///
	/// <summary>
	/// for example, a medic test is done on a patient. The test is not 100% correct. the outcome of the test is named positive, or negative, not true or fasle, as they are not a bivalue one, and they are not 100% correct.
	/// 
	/// We have a 2x2 matrix for Type1 and type2 error:
	///			Cathode,		Anode
	///		true positive, true negative
	///		false negative,  fasle positive
	/// 
	/// </summary>
	internal class ConfusionMatrix
	{
		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		true positive
		public double correctPositive;

		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		true negative
		public double correctNegative;


		/// <summary>
		/// 
		/// </summary>
		/// 
		/// alias:
		///		false positive
		///		type1 error
		public double wrongPositive;

		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		false negative
		///		type2 error;
		public double wrongNegative;

		public double cathode { get {
				return correctPositive + wrongNegative;
			} }

		public double anode { get {
				return correctNegative + wrongPositive;
			} }

		public double positive { get {
				return correctPositive + wrongPositive;
			} }

		public double negative { get {
				return correctNegative + wrongNegative;
			} }



		/// <summary>
		/// symptomic infected|carrier.
		/// </summary>
		public double precision{
			get {
				return correctPositive / positive;
			}
		}

		/// <summary>
		/// uninfected|healthy with no symptoms.
		/// </summary>
		/// 
		public double predictive{
			get {
				return correctNegative / negative;
			}
		}

		/// <summary>
		/// how many patients can be symptomic
		/// </summary>
		/// alias:
		///		recall
		public double sensitivity{
			get {
				return correctPositive / cathode;
			}
		}

		/// <summary>
		/// how many healthy can be unsymptomic.
		/// </summary>
		public double specificity{
			get {
				return correctNegative / anode;
			}
		}

		public double falseNegativeRate {
			get {
				return wrongNegative / cathode;
			}
		}
		public double falsePositiveRate {
			get {
				return wrongPositive / anode;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		///alias:
		///		correctness

		public double accuracy {
			get {
				return correctPositive + correctNegative;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// 1 means perfect; 0 means poor
		/// </remarks>
		public double ef1score {
			get {
				return precision * sensitivity / (precision + sensitivity) * 2;
			}
		}


	
	}
}
