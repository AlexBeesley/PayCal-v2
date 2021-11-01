using System;
using System.Collections.Generic;

public class Repository
{
    private List<EmployeeData> myEmployeeData = new List<EmployeeData>()
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

    public EmployeeData Create(int IDcount, string fname, string lname, bool isPerm, int? Salary, int? Bonus, int? DayRate, int? WeeksWorked)
    {
        var createEmployee = new EmployeeData()
        {
            EmployeeID = IDcount,
            FName = fname,
            LName = lname,
            isPermanent = isPerm,
            Salaryint = Salary,
            Bonusint = Bonus,
            DayRateint = DayRate,
            WeeksWorkedint = WeeksWorked
        };
        myEmployeeData.Add(createEmployee);
        return createEmployee;
    }

    public IEnumerable<EmployeeData> ReadAll()
    {
        return (myEmployeeData);
    }

    public EmployeeData Read(int employeeID)
    {
        return myEmployeeData[employeeID];
    }

    public EmployeeData Update(int employeeID, string fname, string lname, bool isPerm, int? Salary, int? Bonus, int? DayRate, int? WeeksWorked)
    {
        var x = Read(employeeID);
        x.FName = fname;
        x.LName = lname;
        x.isPermanent = isPerm;
        x.Salaryint = Salary;
        x.Bonusint = Bonus;
        x.DayRateint = DayRate;
        x.WeeksWorkedint = WeeksWorked;
        return x;
    }

    public bool Delete(int employeeID)
    {
        myEmployeeData.RemoveAt(employeeID);
        return true;
        // add error handling
    }
}