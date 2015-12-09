using System;
using Model = Dennis.ComposerApp.Model;

namespace ViewModel
{
	public class AddressWrapper {
		
		private Model.Address _address;
		
		public AddressWrapper(Model.Address address) {
			if (address == null) {
				throw new ArgumentNullException("Address must not be null");
			}
			_address = address;
		}
		
		public Model.Address address {
			get {
				return _address;
			}
		}
		
		public string Line1 {get;set;}
		public string Line2 {get;set;}
	}
}