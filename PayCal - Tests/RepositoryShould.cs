using NUnit.Framework;

namespace PayCal___Tests
{
    [TestFixture]
    public class RepositoryShould
    {
        [Test]
        public void Check_Create_method_adds_data_to_list()
        {
            // Arrange
            var sut = new Repository();

            // Act
            sut.Create(4, "Alex", "Beesley", true, 23000, 3000, null, null);

            // Assert
            Assert.That(sut.Read(3).FName, Is.EqualTo("Alex"));
        }

        [Test]
        public void Check_ReadAll_method_returns_all()
        {
            // Arrange
            var sut = new Repository();

            // Act
            var x = sut.ReadAll();

            // Assert
            Assert.That(string.Concat(x).Split("ID").Length, Is.EqualTo(4));
        }

        [Test]
        public void Check_Read_method_returns_all_values_in_list()
        {
            // Arrange
            var sut = new Repository();
            int employeeID = 1;

            // Act
            var x = sut.Read(employeeID);

            // Assert
            Assert.That(x.isPermanent, Is.EqualTo(true));
        }

        [Test]
        public void Check_Delete_method_returns_true()
        {
            // Arrange
            var sut = new Repository();
            int employeeID = 1;

            // Act
            var x = sut.Delete(employeeID);

            // Assert
            Assert.True(x);
        }
    }
}
