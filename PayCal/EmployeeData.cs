using System;
using System.Collections.Generic;
public class EmployeeData
{
    public int EmployeeID { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public bool isPermanent { get; set; }
    public int? Salaryint { get; set; }
    public int? Bonusint { get; set; }
    public int? DayRateint { get; set; }
    public int? WeeksWorkedint { get; set; }

    public override string ToString()
    {
        return $"ID: {EmployeeID}  Name: {FName} {LName} Is Employment Permanent: {isPermanent} Salary: {Salaryint} Bonus: {Bonusint} Day Rate: {DayRateint} Weeks Worked: {WeeksWorkedint}";
    }

    public override int GetHashCode()
    {
        return EmployeeID;
    }

    public object GetFName()
    {
        return FName;
    }

    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        EmployeeData objAsPart = obj as EmployeeData;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }

    public bool Equals(EmployeeData other)
    {
        if (other == null) return false;
        return (this.EmployeeID.Equals(other.EmployeeID));
    }
}