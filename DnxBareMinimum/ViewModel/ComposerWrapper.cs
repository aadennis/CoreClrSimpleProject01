using System;
using Model;

namespace ViewModel
{
	public class ComposerWrapper {
        private string _firstName;
		public string FirstName
		{
			get { return _composer.FirstName;}
			set { _composer.FirstName = value;}
		}
		
		private string _lastName;
		public string LastName
		{
			get { return _composer.LastName;}
			set { _composer.LastName = value;}
		}
		
        private Composer _composer;
		
		public ComposerWrapper(Composer composer) {
			if (composer == null) {
				throw new ArgumentNullException("composer must not be null");
			}
			_composer = composer;
		}
		
		public Composer composer {
			get {
				return _composer;
			}
		}
		
	}
}