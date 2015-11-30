using System;
using Model;

namespace ViewModel
{
	public class LifeDatesWrapper {
      
		
		private LifeSpan _lifeDates;
		public LifeSpan LifeDates
		{
			get { return _lifeDates;}
			set { _lifeDates = value;}
		}
		public LifeDatesWrapper(LifeSpan lifeDates) {
			if (lifeDates == null) {
				throw new ArgumentNullException("LifeDates must not be null");
			}
			_lifeDates = lifeDates;
		}
		
	}
}