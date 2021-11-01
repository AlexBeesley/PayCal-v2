using NUnit.Framework;

namespace PayCal___Tests
{
    [TestFixture]
    public class CalculatorShould
    {
        [Test]
        public void Check_CalculateEmployeePay_method_returns_correct_pay()
        {
            // Arrange
            var re = new Repository();
            var sut = new Calculator(re);
            double pay = 6986;

            // Act
            var x = sut.CalculateEmployeePay(1);

            // Assert
            Assert.That(x, Is.EqualTo(pay));
        }
    }
}
