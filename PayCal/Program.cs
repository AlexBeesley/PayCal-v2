using System;

namespace PayCal
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository re = new Repository();
            EmployeeData ed = new EmployeeData();
            Calculator cal = new Calculator(re);
            int Output;
            string[] Fields = { "Enter First Name:  ", "Enter Surname:  ", "Enter Salary (if applicable):  £", "Enter Bonus (if applicable):  £",
                        "Enter Day Rate (if applicable):  £", "Enter Weeks Worked (if applicable):  " };

            Console.WriteLine("Welcome to the PayCal System, a Salary Calculator.\n");
            
            while (true)
            {
                Console.WriteLine(@"
Please Select from the following options:
Display Employee Information --------------------------------------------------------------------------------- 1
Add new Employee --------------------------------------------------------------------------------------------- 2
Delete Employee ---------------------------------------------------------------------------------------------- 3
Pay Calculator ----------------------------------------------------------------------------------------------- 4");
                Console.Write(">>>  ");
                string Selection = Console.ReadLine();

                if (Selection == "1")
                {
                    Console.Clear();
                    Console.WriteLine("EMPLOYEE INFORMATION\n");
                    Console.WriteLine(string.Concat(re.ReadAll()));
                    Console.WriteLine($"Number of current Employees: {re.Count()}");
                }

                if (Selection == "2")
                {
                    bool NELoopComplete = false;
                    while (NELoopComplete == false)
                    {
                        Console.Clear();
                        Console.WriteLine("NEW EMPLOYEE ENTRY\n");
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
                                            ed.Salaryint = Output;
                                        }
                                        if (i == 3) //Bonus
                                        {
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
                                            ed.DayRateint = Output;
                                        }
                                        if (i == 5) //Weeks Worked
                                        {
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
                        Console.WriteLine("DELETE EMPLOYEE\n");
                        Console.WriteLine(string.Concat(re.ReadAll()));
                        Console.Write("\nSelect ID of Employee to be deleted:  ");
                        string Input = Console.ReadLine();
                        bool valid = int.TryParse(Input, out Output);
                        if (valid)
                        {
                            int selectedID = Output;
                            bool x = re.Delete(selectedID);
                            if (x)
                            {
                                Console.WriteLine(string.Concat(re.ReadAll()));
                                Console.WriteLine($"Employee with ID: {selectedID} has been deleted.");
                                CalLoop = true;
                            }
                        }
                    }
                }

                if (Selection == "4")
                {
                    bool CalLoop = false;
                    while (CalLoop == false)
                    {
                        Console.Clear();
                        Console.WriteLine("CALCULATE ANNUAL PAY\n");
                        Console.WriteLine(string.Concat(re.ReadAll()));
                        Console.Write("\nSelect ID of Employee:  ");
                        string Input = Console.ReadLine();
                        bool valid = int.TryParse(Input, out Output);
                        if (valid)
                        {
                            int selectedID = Output;
                            Console.WriteLine("Employee Name:  " + re.Read(selectedID).FName + " " + re.Read(selectedID).LName);
                            Console.WriteLine("Employment Type:  " + re.Read(selectedID).isPermanent);
                            Console.WriteLine("Annual Pay after Tax:  £" + cal.CalculateEmployeePay(selectedID));
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