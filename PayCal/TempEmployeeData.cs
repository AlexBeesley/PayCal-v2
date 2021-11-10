public class TempEmployeeData
{
    public int EmployeeID { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public int? DayRateint { get; set; }
    public int? WeeksWorkedint { get; set; }

    public override string ToString()
    {
        return $"\nID: {EmployeeID} Name: {FName} {LName} Day Rate: £{DayRateint} Weeks Worked: {WeeksWorkedint}";
    }

    public override int GetHashCode()
    {
        return EmployeeID;
    }
}