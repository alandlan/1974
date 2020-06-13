using AlanStore.Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlanStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var customer = new Customer("Alan",
                                        "Martins",
                                        "12344545678",
                                        "a@a.com.br",
                                        "123254",
                                        "Rua teste");

            var order = new Order(customer);
            
        }
    }
}
