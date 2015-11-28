using Xunit;
using System;
using ViewModel;
using Model;

namespace ComposerTests
{
    public class AddressTests {
        
        Address _address;
        
        public AddressTests() {
            TestInitialize();
        }

        [Fact]
        public void WrapperContainsAddressModel() {
            var addressWrapper = new AddressWrapper(_address);
             Assert.Equal(_address, addressWrapper.address);
        }
        
        [Fact]
        public void WrapperPropertiesReferenceAddressModelProperties() {
            var addressWrapper = new AddressWrapper(_address);
            Assert.Equal("Tottenham", addressWrapper.address.Line2);
             Assert.Equal(_address.Line1, addressWrapper.address.Line1);
        }
        
        [Fact]
        public void PassedAddressIsNotNull() {
            ViewModel.AddressWrapper addressWrapper;
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => addressWrapper = new AddressWrapper(null));
            var exceptionMessage = ex.ParamName;
            Assert.Equal("Address must not be null", exceptionMessage);
        }
        
        private void TestInitialize() {
             _address = new Address{Line1 = "60 Acacia Avenue", Line2 = "Tottenham"};
        }
    }
}