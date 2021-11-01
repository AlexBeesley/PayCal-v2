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
        return $"\nID: {EmployeeID}  Name: {FName} {LName} Is Employment Permanent: {isPermanent} Salary: £{Salaryint} Bonus: £{Bonusint} Day Rate: £{DayRateint} Weeks Worked: {WeeksWorkedint}";
    }

    public override int GetHashCode()
    {
        return EmployeeID;
    }
}