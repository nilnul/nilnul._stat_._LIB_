using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.set;


namespace nilnul.statistics
{
	

	public class FiniteDiscreteSampleSpace : SampleSpace {
		public Event[] basicEvents {
			private set {
				this["basicEvents"] = basicEvents;
			}
			get { 
				return this["basicEvents"];
			}
		}
		public FiniteDiscreteSampleSpace(Event[] basicEvents) { 

		}

	}

	

	public class Sample : Element { 
	}
}
