using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class HtmlFormatterTests
    {
        [TestMethod]
        public void FormatAsBold_WhenCalled_ShouldEncloseStringWithStrongElements()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("Edgar");
            //Specific Assertion
            Assert.AreEqual(result, "<strong>Edgar</strong>");

            //Too General
            StringAssert.StartsWith(result, "<strong>");

            //Less General
            StringAssert.EndsWith(result, "</strong>");

            //less General
            StringAssert.Contains(result,"Edgar");

            //Resuming when you write String test is Better is the Assert to be more general

        }
        
    }
}
