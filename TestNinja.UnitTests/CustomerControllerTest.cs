using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class CustomerControllerTest
    {
        private CustomerController _controller;

        [TestInitialize]
        public void Setup()
        {
            _controller = new CustomerController();
        }

        [TestMethod]
        [Ignore("Se ha implementado un test mas completo")]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = _controller.GetCustomer(0);

            //NotFound or one of its derivatives
            //Assert.IsInstanceOfType(result, typeof(NotFound));
            //Not Found
            Assert.AreEqual(result.GetType(), typeof(NotFound));


        }

        [TestMethod]
        [Ignore("Se ha implementado un test mas completo")]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var result = _controller.GetCustomer(1);

            Assert.IsInstanceOfType(result, typeof(Ok));
        }

        [TestMethod]
        [DataRow(0, typeof(NotFound))]
        [DataRow(1, typeof(Ok))]
        public void GetCustomer_IdReturnNotFoundOrOk(int id, object expected)
        {
            var result = _controller.GetCustomer(id);
            Assert.AreEqual(result.GetType(), expected);

        }
    }
}




