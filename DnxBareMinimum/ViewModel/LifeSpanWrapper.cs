using System;
using Model = Dennis.ComposerApp.Model;

namespace ViewModel
{
	public class LifeDatesWrapper {
      
		
		private Model.LifeSpan _lifeDates;
		public Model.LifeSpan LifeDates
		{
			get { return _lifeDates;}
			set { _lifeDates = value;}
		}
		public LifeDatesWrapper(Model.LifeSpan lifeDates) {
			if (lifeDates == null) {
				throw new ArgumentNullException("LifeDates must not be null");
			}
			_lifeDates = lifeDates;
		}
		
	}
}