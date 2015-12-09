using Model = Dennis.ComposerApp.Model;
using Xunit;

namespace UnitTests {
	
	public class ChangeNotificationSimpleProperty {
		
		Model.Address _address;
	
		public ChangeNotificationSimpleProperty() {
			TestInitialize();
		}
		
		[Fact]
		public void StuffDoesStuff() {
			Assert.False(1 == 1);
		}


		private void TestInitialize() {
				_address = new Model.Address{Line1 = "60 Acacia Avenue", Line2 = "Tottenham"};
			
		}
	}
}