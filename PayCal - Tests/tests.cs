//using NUnit.Framework;
//using System;

//[TestFixture]
//public class Check_Variables
//{

//    [Test]
//    public void Check_newPermboo_is_false()
//    {
//        // Arrange
//        var sut = new DataTableNewEntry();

//        // Act + Assert
//        Assert.False(sut.newPermBoo);
//    }

//    [Test]
//    public void Check_newFName_is_null()
//    {
//        // Arrange
//        var sut = new DataTableNewEntry();

//        // Act + Assert
//        Assert.Null(sut.newFName);
//    }

//    [Test]
//    public void Check_newLName_is_null()
//    {
//        // Arrange
//        var sut = new DataTableNewEntry();

//        // Act + Assert
//        Assert.Null(sut.newLName);
//    }

//    [Test]
//    public void Check_newSalaryint_is_null()
//    {
//        // Arrange
//        var sut = new DataTableNewEntry();

//        // Act + Assert
//        Assert.Null(sut.newSalaryint);
//    }

//    [Test]
//    public void Check_newBonusint_is_null()
//    {
//        // Arrange
//        var sut = new DataTableNewEntry();

//        // Act + Assert
//        Assert.Null(sut.newBonusint);
//    }

//    [Test]
//    public void Check_newDayRateint_is_null()
//    {
//        // Arrange
//        var sut = new DataTableNewEntry();

//        // Act + Assert
//        Assert.Null(sut.newDayRateint);
//    }

//    [Test]
//    public void Check_newWeeksWorkedint_is_null()
//    {
//        // Arrange
//        var sut = new DataTableNewEntry();

//        // Act + Assert
//        Assert.Null(sut.newWeeksWorkedint);
//    }
//}

//public class Check_DataTable_Types
//{
//    [Test]
//    public void Check_Object_In_IDColumn_Is_Int32()
//    {
//        // Arrange
//        var sut = new DataTableMain();

//        // Act
//        sut.MakeTable();

//        // Assert
//        Assert.That(sut.table.Rows[0].ItemArray.GetValue(0), 
//                    Is.TypeOf((Type)typeof(Int32)));
//    }

//    [Test]
//    public void Check_Object_In_FNColumn_Is_String()
//    {
//        // Arrange
//        var sut = new DataTableMain();

//        // Act
//        sut.MakeTable();

//        // Assert
//        Assert.That(sut.table.Rows[0].ItemArray.GetValue(1),
//                    Is.TypeOf((Type)typeof(String)));
//    }

//    [Test]
//    public void Check_Object_In_LNColumn_Is_String()
//    {
//        // Arrange
//        var sut = new DataTableMain();

//        // Act
//        sut.MakeTable();

//        // Assert
//        Assert.That(sut.table.Rows[0].ItemArray.GetValue(2),
//                    Is.TypeOf((Type)typeof(String)));
//    }

//   [Test]
//    public void Check_Object_In_PermanentEmploymentColumn_Is_Int32()
//    {
//    // Arrange
//    var sut = new DataTableMain();

//    // Act
//    sut.MakeTable();

//    // Assert
//    Assert.That(sut.table.Rows[0].ItemArray.GetValue(3),
//                Is.TypeOf((Type)typeof(bool)));
//    }

//    [Test]
//    public void Check_Object_In_SalaryColumn_Is_Int32()
//    {
//        // Arrange
//        var sut = new DataTableMain();

//        // Act
//        sut.MakeTable();

//        // Assert
//        Assert.That(sut.table.Rows[0].ItemArray.GetValue(4),
//                    Is.TypeOf((Type)typeof(Int32)));
//    }

//    [Test]
//    public void Check_Object_In_BonusColumn_Is_Int32()
//    {
//        // Arrange
//        var sut = new DataTableMain();

//        // Act
//        sut.MakeTable();

//        // Assert
//        Assert.That(sut.table.Rows[0].ItemArray.GetValue(5),
//                    Is.TypeOf((Type)typeof(Int32)));
//    }

//    [Test]
//    public void Check_Object_In_DayRateColumn_Is_Int32()
//    {
//        // Arrange
//        var sut = new DataTableMain();

//        // Act
//        sut.MakeTable();

//        // Assert
//        Assert.That(sut.table.Rows[2].ItemArray.GetValue(6),
//                    Is.TypeOf((Type)typeof(Int32)));
//    }

//    [Test]
//    public void Check_Object_In_WeeksWorkedColumn_Is_Int32()
//    {
//        // Arrange
//        var sut = new DataTableMain();

//        // Act
//        sut.MakeTable();

//        // Assert
//        Assert.That(sut.table.Rows[2].ItemArray.GetValue(7),
//                    Is.TypeOf((Type)typeof(Int32)));
//    }
//}