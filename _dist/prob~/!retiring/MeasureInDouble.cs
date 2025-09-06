using System;
using System.Net;


namespace nilnul.prob._prob._measure
{
    /// <summary>
    /// a number in [0,1]
    /// </summary>
    public partial struct MeasureInDouble
    {
        double _val;

        public double val
        {
            get
            {
                return _val;
            }
            set
            {
                if (val < 0 || val > 1)
                {
                    throw new ArgumentOutOfRangeException();

                }
                else
                {
                    _val = val;
                }

            }
        }


		//public MeasureInDouble()
		//{
		//	_val = 0;
		//}

        public MeasureInDouble(double val)
           : this()
        {

           // this.val = val;
            this._val = val;
        }

		static public void AssertIsMeasure(double x) {
			nilnul.num.real.double_.CloseInterval.Unit.AssertContains(x);
		}




    }
}
