using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MStestMainDll;

namespace MSTesting_Resrvation
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void Cancellation_ByAdmin_should_Return_True()
        {
            //Arrange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Cancellation_By_MadeBy_Should_Return_True()
        {
            var user = new User();
            var reservation1 = new Reservation() { MadeBy = user };
            // reservation1.MadeBy = user;
            var result1 = reservation1.CanBeCancelledBy(reservation1.MadeBy);
            Assert.IsTrue(result1);
        }
        [TestMethod]
        public void Cancellation_By_Others_should_Return_False()
        {
            var reservation2 = new Reservation { MadeBy = new User() };
            var result2 = reservation2.CanBeCancelledBy(new User());
            Assert.IsFalse(result2);
        }
        
    }
}
