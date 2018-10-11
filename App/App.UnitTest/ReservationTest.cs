using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.App_Data;
namespace App.UnitTest
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //MathodName_Scenario_ExpectedBehavior()

            //Arrange ----Initialaize object
            Reservation reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCanbeCancelReservation_ReturnsTrue()
        {
            //Arrange ----Initialaize object
            User user = new User();
            Reservation reservation = new Reservation { MadeBy = user };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCanbeCancelReservation_ReturnsFalse()
        {
            //Arrange ----Initialaize object           
            Reservation reservation = new Reservation { MadeBy = new User() };

            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            Assert.IsFalse(result);
        }
    }
}
