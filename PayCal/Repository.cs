using System;
using System.Collections.Generic;
using System.Linq;

public class Repository
{
    static Random rnd = new Random();
    private List<EmployeeData> myEmployeeData = new List<EmployeeData>()
    {
        new EmployeeData()
        {
            EmployeeID = rnd.Next(1000,9999),
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
            EmployeeID = rnd.Next(1000,9999),
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
            EmployeeID = rnd.Next(1000,9999),
            FName = "Clare",
            LName = "Jones",
            isPermanent = false,
            Salaryint = null,
            Bonusint = null,
            DayRateint = 350,
            WeeksWorkedint = 40
        }
    };

    public EmployeeData Create(string fname, string lname, bool isPerm, int? Salary, int? Bonus, int? DayRate, int? WeeksWorked)
    {
        var createEmployee = new EmployeeData()
        {
            EmployeeID = rnd.Next(1000, 9999),
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

    public int GetIDfromIndex(int employeeID)
    {
        return myEmployeeData[employeeID].EmployeeID;
    }

    public EmployeeData Read(int employeeID)
    {
        EmployeeData employee = myEmployeeData.First(e => e.EmployeeID == employeeID);
        return employee;
    }

    public int Count()
    {
        return myEmployeeData.Count;
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
        EmployeeData employee = myEmployeeData.FirstOrDefault(e => e.EmployeeID == employeeID);
        if (myEmployeeData.Remove(employee)) { return true; }
        else { return false; }        
    }
}