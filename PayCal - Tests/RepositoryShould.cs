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
            sut.Create("Alex", "Beesley", true, 23000, 400, null, null);

            // Assert
            Assert.That(sut.myEmployeeData, Is.Unique);
        }

        [Test]
        public void Check_ReadAll_method_returns_all()
        {
            // Arrange
            var sut = new Repository();

            // Act
            var x = sut.ReadAll();

            // Assert
            Assert.That(x, Is.Not.Null);
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
            Assert.That(x, Is.Not.Null);
        }

        [Test]
        public void Check_ReadValues_method_returns_correct_values()
        {
            // Arrange
            var sut = new Repository();
            int employeeID = 1;
            string[] fields = { "FName", "LName", "isPermanent", "Salary", "Bonus", "DayRate", "WeeksWorked" };

            for (int i = 0; i < 6; i++)
            {
                // Act
                var x = sut.ReadValues(employeeID, fields[i]);
                
                // Assert
                if (i == 0 || i == 1) { Assert.IsInstanceOf(typeof(string), x); }
                if (i == 2) { Assert.IsInstanceOf(typeof(bool), x); }
                if (i == 3 || i == 4) { Assert.IsInstanceOf(typeof(int), x); }
                if (i == 5 || i == 6) { Assert.Null(x); }
            }
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
