using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanbeCancelledBy_AdminCancel_ReturnTrue()
        {
            // AAA
            // Arrange
            Reservation r = new Reservation();

            // Act
            bool result = r.CanbeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);

            //Assert.That. -- NUnit
        }


    }
}
