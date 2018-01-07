using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ErroLoggerTests
    {
        private ErrorLogger _logger;

        [TestInitialize]
        public void Setup()
        {
            _logger = new ErrorLogger();
        }


        [TestMethod]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            _logger.Log("a");
            var result = _logger.LastError;

            Assert.AreEqual(result, "a");

        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(String error)
        {
            Assert.ThrowsException<ArgumentNullException>(() => _logger.Log(error));
        }

        [TestMethod]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            //_logger.ErrorLogged += _logger_ErrorLogged;
            var id = Guid.Empty;

            _logger.ErrorLogged += (sender, args) =>
            {
                id = args;
            };
            _logger.Log("a");

            Assert.AreNotEqual(id, Guid.Empty);

        }

        //private void _logger_ErrorLogged(object sender, Guid e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
