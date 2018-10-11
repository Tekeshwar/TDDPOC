using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.App_Data;
namespace App.UnitTest
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void canBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //MathodName_Scenario_ExpectedBehavior()

            //Arrange ----Initialaize object
            Reservation reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }
    }
}
