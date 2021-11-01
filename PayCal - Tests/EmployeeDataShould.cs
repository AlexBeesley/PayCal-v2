using NUnit.Framework;

namespace PayCal___Tests
{
    [TestFixture]
    public class EmployeeDataShould
    {
        [Test]
        public void Check_FName_is_null()
        {
            // Arrange
            var sut = new EmployeeData();

            // Act + Assert
            Assert.Null(sut.FName);
        }

        [Test]
        public void Check_LName_is_null()
        {
            // Arrange
            var sut = new EmployeeData();

            // Act + Assert
            Assert.Null(sut.LName);
        }

        [Test]
        public void Check_isPermanent_is_false()
        {
            // Arrange
            var sut = new EmployeeData();

            // Act + Assert
            Assert.False(sut.isPermanent);
        }

        [Test]
        public void Check_Salaryint_is_null()
        {
            // Arrange
            var sut = new EmployeeData();

            // Act + Assert
            Assert.Null(sut.Salaryint);
        }

        [Test]
        public void Check_Bonusint_is_null()
        {
            // Arrange
            var sut = new EmployeeData();

            // Act + Assert
            Assert.Null(sut.Bonusint);
        }

        [Test]
        public void Check_DayRateint_is_null()
        {
            // Arrange
            var sut = new EmployeeData();

            // Act + Assert
            Assert.Null(sut.DayRateint);
        }

        [Test]
        public void Check_WeeksWorkedint_is_null()
        {
            // Arrange
            var sut = new EmployeeData();

            // Act + Assert
            Assert.Null(sut.WeeksWorkedint);
        }
    }
}
