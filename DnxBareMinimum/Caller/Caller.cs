using System;
using Model.Address;
using ViewModel.Address;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CallerNs
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("[In the Caller: as simple as it gets]");
            var address = new Address(){Line1 = "60 Acacia Avenue", Line2 = "adsfadf"};
            address.DisplayStuff();
            var wrapperAddress = new AddressWrapper(address);
            Assert.AreEqual(1,2);
        
            
        }
    }
}
