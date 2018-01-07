
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class MathTests
    {
        private Math _math;

        [TestInitialize]
        public void SetUp()
        {
            _math = new Math();

        }
        [TestMethod]
        //[Ignore("Because I Dont Know")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {

            var result = _math.Add(1, 2);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        [DataRow(2, 1, 2)]
        [DataRow(1, 2, 2)]
        [DataRow(1, 1, 1)]
        public void Max_WhenCalled_ResturnTheGreaterArgument(int a, int b, int expected)
        {

            var result = _math.Max(a, b);
            Assert.AreEqual(result, expected);

        }

        [TestMethod]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count(), 3);
            //Assert.IsTrue(result.Contains<int>(1));
            //Assert.IsTrue(result.Contains<int>(2));
            //Assert.IsTrue(result.Contains<int>(3));
            CollectionAssert.AreEquivalent(result.ToList(), new[] { 1, 3, 5 });
            CollectionAssert.AllItemsAreUnique(result.ToList());
            CollectionAssert.AllItemsAreNotNull(result.ToList());


        }


    }
}
