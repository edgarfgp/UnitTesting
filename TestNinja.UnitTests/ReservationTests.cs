using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestInitialize]
        public void SetUp()
        {

        }
        /// <summary>
        /// The name of the method has three parts
        /// -Name of the method
        /// -Scenario we are Testing
        /// -The Expected Behavior we are testing
        /// </summary>
        [TestMethod]
        public void CanBeCancellBy_AdminCancelling_ReturnsTrue()
        {
            //Arrange is the initilization of the object
            var reservation = new Reservation();

            //Act whn we call the method that we want to test
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            
            //Assert

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void CanBeCancellBy_SameUserCancelingTheReservation_ReturnTrue()
        {
            //Arrange is the initilization of the object
            var user = new User();
            var reservation = new Reservation { MadeBy = user};

            //Act whn we call the method that we want to test
            var result = reservation.CanBeCancelledBy(user);

            //Assert

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void CanBeCancellBy_AnotherUserCancelingReservation_ReturnNull()
        {
            //Arrange is the initilization of the object
            var reservation = new Reservation { MadeBy = new User()};

            //Act whn we call the method that we want to test
            var result = reservation.CanBeCancelledBy(new User());

            //Assert

            Assert.IsFalse(result);

        }

    }
}
