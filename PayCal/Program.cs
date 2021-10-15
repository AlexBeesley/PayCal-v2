using System;

namespace PayCal
{
    class Program
    {

        static void Main(string[] args)
        {
            Repository re = new Repository();
            EmployeeData ed = new EmployeeData();

            Console.WriteLine(string.Concat(re.ReadAll()));

            int Output;

            string[] Fields = { "Enter First Name:  ", "Enter Surname:  ", "Enter Salary (if applicable):  $", "Enter Bonus (if applicable):  $",
                        "Enter Day Rate (if applicable):  $", "Enter Weeks Worked (if applicable):  " };

            Console.WriteLine("\nWelcome to the PayCal System, a Salary Calculator.\n");
            while (true)
            {
                Console.WriteLine(@"
Please Select from the following options:
Display Employee Information --------------------------------------------------------------------------------- 1
Add new Employee --------------------------------------------------------------------------------------------- 2
Pay Calculator ----------------------------------------------------------------------------------------------- 3");
                Console.Write(">>>  ");
                string Selection = Console.ReadLine();
                if (Selection == "1")
                {
                    Console.Clear();
                    Console.WriteLine("\nEMPLOYEE INFORMATION\n");
                    Console.WriteLine(string.Concat(re.ReadAll()));
                }
                if (Selection == "2")
                {
                    bool NELoopComplete = false;
                    while (NELoopComplete == false)
                    {
                        Console.Clear();
                        Console.WriteLine("\nNEW EMPLOYEE ENTRY\n");
                        Console.WriteLine(string.Concat(re.ReadAll()));

                        Console.Write(Fields[0]);
                        ed.FName = Console.ReadLine();

                        Console.Write(Fields[1]);
                        ed.LName = Console.ReadLine();

                        bool typeConvComplete = false;
                        while (typeConvComplete == false)
                        {
                            Console.WriteLine("Is Employment Permanent? [Y/N]  ");
                            string newIsPerm = Console.ReadLine();

                            if (newIsPerm == "Y" || newIsPerm == "y")
                            {
                                ed.isPermanent = true;
                                for (int i = 2; i < 4; i++)
                                {
                                    Console.Write(Fields[i]);
                                    string Input = Console.ReadLine();
                                    bool valid = int.TryParse(Input, out Output);
                                    if (valid)
                                    {
                                        if (i == 2) //Salary
                                        {
                                            Console.WriteLine("Vaild, Salary set to: $" + Output);
                                            ed.Salaryint = Output;
                                        }
                                        if (i == 3) //Bonus
                                        {
                                            Console.WriteLine("Vaild, Bonus set to: $" + Output);
                                            ed.Bonusint = Output;
                                        }
                                        ed.DayRateint = null;
                                        ed.WeeksWorkedint = null;
                                    }

                                    else
                                    {
                                        Console.WriteLine("invaild input.");
                                    }
                                }
                                typeConvComplete = true;
                            }

                            if (newIsPerm == "N" || newIsPerm == "n")
                            {
                                ed.isPermanent = false;
                                for (int i = 4; i < 6; i++)
                                {
                                    Console.Write(Fields[i]);
                                    string Input = Console.ReadLine();
                                    bool valid = int.TryParse(Input, out Output);
                                    if (valid)
                                    {
                                        if (i == 4) //Day Rate
                                        {
                                            Console.WriteLine("Vaild, Day Rate set to: $" + Output);
                                            ed.DayRateint = Output;
                                        }
                                        if (i == 5) //Weeks Worked
                                        {
                                            Console.WriteLine("Vaild, Weeks Worked set to:  " + Output);
                                            ed.WeeksWorkedint = Output;
                                        }
                                        ed.Salaryint = null;
                                        ed.Bonusint = null;
                                    }
                                    else
                                    {
                                        Console.WriteLine("invaild input.");
                                    }
                                }
                                typeConvComplete = true;
                            }
                            Console.WriteLine($"Data to inject:  {ed.FName} / {ed.LName} / {ed.isPermanent} / {ed.Salaryint} / {ed.Bonusint} / {ed.DayRateint} / {ed.WeeksWorkedint}");


                            bool commitComplete = false;
                            bool commit = false;
                            while (commitComplete == false)
                            {
                                Console.Write("Confirm data is correct and fit for injection. [Y/n]  ");
                                string confirm = Console.ReadLine();
                                if (confirm == "Y" || confirm == "y" || confirm == "")
                                {
                                    re.IDCount++;
                                    commit = true;
                                    commitComplete = true;
                                    re.Create(ed.FName, ed.LName, ed.isPermanent, ed.Salaryint, ed.Bonusint, ed.DayRateint, ed.WeeksWorkedint);
                                }
                                if (confirm == "N" || confirm == "n")
                                {
                                    commitComplete = true;
                                }
                            }

                            if (commit == true)
                            {
                                NELoopComplete = true;
                            }
                        }
                    }
                }

                if (Selection == "3")
                {
                    bool CalLoop = false;
                    while (CalLoop == false)
                    {
                        Console.Clear();
                        Console.WriteLine("\nCALCULATE ANNUAL PAY\n");
                        Console.WriteLine(string.Concat(re.ReadAll()));
                        Console.Write("\nSelect ID of Employee:  ");
                        string Input = Console.ReadLine();
                        bool valid = int.TryParse(Input, out Output);
                        if (valid)
                        {
                            int selectedID = Output;

                            selectedID = selectedID - 1;

                            object getFName = re.ReadValues(selectedID, "FName");
                            object getLname = re.ReadValues(selectedID, "LName");
                            object getEmploymentStatus = re.ReadValues(selectedID, "isPermanent");
                            object getSalary = re.ReadValues(selectedID, "Salary");
                            object getBonus = re.ReadValues(selectedID, "Bonus");
                            object getDayRate = re.ReadValues(selectedID, "DayRate");
                            object getWeeksWorked = re.ReadValues(selectedID, "WeeksWorked");

                            bool CheckID = (selectedID <= re.IDCount);
                            if (CheckID)
                            {
                                Console.WriteLine("Employee Name:  " + getFName + " " + getLname);
                                if (Convert.ToBoolean(getEmploymentStatus) == true)
                                {
                                    int AnnualPay = Convert.ToInt32(getBonus) + Convert.ToInt32(getSalary);
                                    Console.WriteLine("Salary is:  $" + getSalary);
                                    Console.WriteLine("Bonus is:  $" + getBonus);
                                    Console.WriteLine("Total Annual pay is:  $" + AnnualPay);
                                }
                                else
                                {
                                    int PartTimePay = Convert.ToInt32(getDayRate) * 5 * Convert.ToInt32(getWeeksWorked);
                                    Console.WriteLine("DayRate is:  $" + getDayRate);
                                    Console.WriteLine("Weeks Worked is:  " + getWeeksWorked);
                                    Console.WriteLine("Total Annual pay is:  $" + PartTimePay);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invaild ID.");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invaild ID.");
                        }
                        CalLoop = true;
                    }


                }
            }
        }
    }
}