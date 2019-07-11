using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestFixture]
    public class ReservationNUnit
    {
        [Test]
        public void CanbeCancelledBy_AdminCancel_ReturnTrue()
        {
            // AAA
            // Arrange
            Reservation r = new Reservation();

            // Act
            bool result = r.CanbeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
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
            Assert.That(result, Is.True);
        }

        [Test]
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
            Assert.That(result, Is.False);
        }


        [Test]
        public void CanbeCancelledBy_NullUserInput_ThrowException()
        {
            // AAA
            // Arrange
            Reservation r = new Reservation();

            // Act + Assert
            Exception ex = Assert.Throws<NullUserException>( () => r.CanbeCancelledBy(null));

            // Assert
            Assert.That(ex.Message, Is.EqualTo("Null user given for CanbeCancelledBy"));
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void CalcAverageTables_InvalidInput_ThrowException()
        //{
        //    // Arrange
        //    Reservation r = new Reservation();

        //    // Act
        //    float f = r.CalcAverageTables(-5, -5);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        //public void CalcAverageTables_ZeroHours_ThrowException()
        //{
        //    // Arrange
        //    Reservation r = new Reservation();

        //    // Act
        //    float f = r.CalcAverageTables(5, 0);
        //}

        //[TestMethod]
        //public void CalcAverageTables_ValidCalculation_ValidResult()
        //{
        //    // Arrange
        //    Reservation r = new Reservation();

        //    // Act
        //    Assert.AreEqual(r.CalcAverageTables(10, 5), 2);
        //    Assert.AreEqual(r.CalcAverageTables(15, 5), 3);
        //    Assert.AreEqual(r.CalcAverageTables(20, 4), 5);
        //}
    }
}
