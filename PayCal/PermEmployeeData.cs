public class PermEmployeeData
{
    public int EmployeeID { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public int? Salaryint { get; set; }
    public int? Bonusint { get; set; }

    public override string ToString()
    {
        return $"\nID: {EmployeeID} Name: {FName} {LName} Salary: £{Salaryint} Bonus: £{Bonusint}";
    }

    public override int GetHashCode()
    {
        return EmployeeID;
    }
}