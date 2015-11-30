using System;
using Model;

namespace ViewModel
{
	public class AddressWrapper {
		
		private Address _address;
		
		public AddressWrapper(Address address) {
			if (address == null) {
				throw new ArgumentNullException("Address must not be null");
			}
			_address = address;
		}
		
		public Address address {
			get {
				return _address;
			}
		}
		
		public string Line1 {get;set;}
		public string Line2 {get;set;}
	}
}