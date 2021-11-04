public class Calculator
{
	public double AnnualPayAfterTax;
	public double AnnualPay;

	private readonly Repository re;

    public Calculator(Repository repository)
    {
        re = repository;
    }
    public double CalculateEmployeePay(int employeeID)
	{
		bool EmploymentStatus = re.Read(employeeID).isPermanent;
		if (EmploymentStatus == true)
		{ 
			int Salary = (int)re.Read(employeeID).Salaryint;
			int Bonus = (int)re.Read(employeeID).Bonusint;
			AnnualPay = Salary + Bonus;
		}
		else {
			int DayRate = (int)re.Read(employeeID).DayRateint;
			int WeeksWorked = (int)re.Read(employeeID).WeeksWorkedint;
			AnnualPay = (DayRate * 5) + WeeksWorked;
		}
		if (AnnualPay < 12570) { AnnualPayAfterTax = AnnualPay; }
		if (AnnualPay > 12570) { AnnualPayAfterTax = (AnnualPay - 12570) * 0.2; }
		return (AnnualPayAfterTax);
	}
}