using System;
using System.Collections.Generic;
using System.Linq;

namespace PayCal
{
    public class PermEmployeeRepository : IRepository<PermEmployeeData>
    {
        static Random rnd = new Random();
        private List<PermEmployeeData> myEmployeeData = new List<PermEmployeeData>()
    {
        new PermEmployeeData()
        {
            EmployeeID = rnd.Next(1000,9999),
            FName = "Joe",
            LName = "Bloggs",
            Salaryint = 40000,
            Bonusint = 5000,
        },

        new PermEmployeeData()
        {
            EmployeeID = rnd.Next(1000,9999),
            FName = "John",
            LName = "Smith",
            Salaryint = 45000,
            Bonusint = 2500,
        },
    };

        public PermEmployeeData Create(string fname, string lname, int? Salary, int? Bonus, int? DayRate, int? WeeksWorked)
        {
            var createEmployee = new PermEmployeeData()
            {
                EmployeeID = rnd.Next(1000, 9999),
                FName = fname,
                LName = lname,
                Salaryint = Salary,
                Bonusint = Bonus,
            };
            myEmployeeData.Add(createEmployee);
            return createEmployee;
        }

        public IEnumerable<PermEmployeeData> ReadAll()
        {
            return (myEmployeeData);
        }

        public int GetIDfromIndex(int employeeID)
        {
            return myEmployeeData[employeeID].EmployeeID;
        }

        public PermEmployeeData Read(int employeeID)
        {
            PermEmployeeData employee = myEmployeeData.First(e => e.EmployeeID == employeeID);
            return employee;
        }

        public int Count()
        {
            return myEmployeeData.Count;
        }

        public PermEmployeeData Update(int employeeID, string fname, string lname, int? Salary, int? Bonus, int? DayRate, int? WeeksWorked)
        {
            var x = Read(employeeID);
            x.FName = fname;
            x.LName = lname;
            x.Salaryint = Salary;
            x.Bonusint = Bonus;
            return x;
        }

        public bool Delete(int employeeID)
        {
            PermEmployeeData employee = myEmployeeData.FirstOrDefault(e => e.EmployeeID == employeeID);
            if (myEmployeeData.Remove(employee)) { return true; }
            else { return false; }
        }
    }
}