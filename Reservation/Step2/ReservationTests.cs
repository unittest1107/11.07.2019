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
        }

        [TestMethod]
        public void CanbeCancelledBy_SameNonAdminCancel_ReturnTrue()
        {
            // AAA
            // Arrange
            Reservation r = new Reservation();
            User u = new User();
            r.MadeBy = u;

            // Act
            bool result = r.CanbeCancelledBy(u);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanbeCancelledBy_DiffNonAdminCancel_ReturnFalse()
        {
            // AAA
            // Arrange
            Reservation r = new Reservation();
            User u = new User();
            u.IsAdmin = false;
            r.MadeBy = new User();

            // Act
            bool result = r.CanbeCancelledBy(u);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        [ExpectedException(typeof(NullUserException))]
        public void CanbeCancelledBy_NullUserInput_ThrowException()
        {
            // AAA
            // Arrange
            Reservation r = new Reservation();

            // Act
            bool result = r.CanbeCancelledBy(null);
        }
    }
}
