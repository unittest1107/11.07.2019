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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcAverageTables_InvalidInput_ThrowException()
        {
            // Arrange
            Reservation r = new Reservation();

            // Act
            float f = r.CalcAverageTables(-5, -5);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CalcAverageTables_ZeroHours_ThrowException()
        {
            // Arrange
            Reservation r = new Reservation();

            // Act
            float f = r.CalcAverageTables(5, 0);
        }

        [TestMethod]
        public void CalcAverageTables_ValidCalculation_ValidResult()
        {
            // Arrange
            Reservation r = new Reservation();

            // Act
            Assert.AreEqual( r.CalcAverageTables(10, 5), 2 );
            Assert.AreEqual( r.CalcAverageTables(15, 5), 0 );
            Assert.AreEqual( r.CalcAverageTables(20, 4), 5 );
        }
    }
}
