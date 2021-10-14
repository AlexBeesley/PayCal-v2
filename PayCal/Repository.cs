using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

public class Repository
{
    public List<EmployeeData> myEmployeeData = new List<EmployeeData>()
    {
        new EmployeeData()
        {
            EmployeeID = 1,
            FName = "Joe",
            LName = "Bloggs",
            isPermanent = true,
            Salaryint = 40000,
            Bonusint = 5000,
            DayRateint = null,
            WeeksWorkedint = null
        },

        new EmployeeData()
        {
            EmployeeID = 2,
            FName = "John",
            LName = "Smith",
            isPermanent = true,
            Salaryint = 45000,
            Bonusint = 2500,
            DayRateint = null,
            WeeksWorkedint = null
        },

        new EmployeeData()
        {
            EmployeeID = 3,
            FName = "Clare",
            LName = "Jones",
            isPermanent = false,
            Salaryint = null,
            Bonusint = null,
            DayRateint = 350,
            WeeksWorkedint = 40
        }
    };

    public int IDCount = 3;

    public void Create(string fname, string lname, bool isPerm, int? Salary, int? Bonus, int? DayRate, int? WeeksWorked)
    {
        myEmployeeData.Add(new EmployeeData()
        {
            EmployeeID = IDCount,
            FName = fname,
            LName = lname,
            isPermanent = isPerm,
            Salaryint = Salary,
            Bonusint = Bonus,
            DayRateint = DayRate,
            WeeksWorkedint = WeeksWorked
        });
    }

    public IEnumerable<object> ReadAll()
    {
        foreach (EmployeeData dataitem in myEmployeeData)
        {
            yield return ("\n" + dataitem);
        }
    }

    public object Read(int employeeID)
    {
        var x = myEmployeeData.Find(item => item.EmployeeID == employeeID);
        return x;
    }

    public object ReadValues(int employeeID, string value)
    {
        string FName = myEmployeeData[employeeID].FName;
        if (value == "FName") { return FName; }

        string LName = myEmployeeData[employeeID].LName;
        if (value == "LName") { return LName; }

        bool isPermanent = myEmployeeData[employeeID].isPermanent;
        if (value == "isPermanent") { return isPermanent; }

        int? Salary = myEmployeeData[employeeID].Salaryint;
        if (value == "Salary") { return Salary; }

        int? Bonus = myEmployeeData[employeeID].Bonusint;
        if (value == "Bonus") { return Bonus; }

        int? DayRate = myEmployeeData[employeeID].DayRateint;
        if (value == "DayRate") { return DayRate; }

        int? WeeksWorked = myEmployeeData[employeeID].WeeksWorkedint;
        if (value == "WeeksWorked") { return WeeksWorked; }

        else { throw new Exception("Invaild Value."); }
    }


    public bool Delete(int employeeID)
    {
        myEmployeeData.RemoveAt(employeeID);
        return true;
    }
}