using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EmployeeManagementSystem
{
    public interface IEmployee
    {

        string FirstName { get; set; }
        string Lastname { get; set; }
        string department { get; set; }
        string JobTitle { get; set; }

        decimal CalculateSalary();
        void DisplaySalary();
    }

    public abstract class Employee : IEmployee{
    
    public string FirstName { get; set; }   
    public string Lastname { get; set; }
    public string department { get; set; }
    public string JobTitle { get; set; }

        public Employee(string fname, string lname, string dept, string jobt) 
        {
        
            FirstName = fname;  
            Lastname = lname;
            department = dept;
            JobTitle = jobt;    
        }

        public abstract decimal CalculateSalary();

        public void DisplaySalary() {

            Console.WriteLine("--- Employee Salary Information--- ");
            Console.WriteLine();
            Console.WriteLine($"Name: {FirstName} {Lastname}");
            Console.WriteLine($"Department: {department} ");
            Console.WriteLine($"Job Title: {JobTitle}");
            Console.WriteLine($"Calculated Salary: ${CalculateSalary():N2} ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }

        public class FullTimeEmployee : Employee 
        {
        
            public decimal MonthlySalary { get; set; }

            public FullTimeEmployee(string fname, string lname, string dept, string jobt, decimal monthlysalary)
                : base( fname,  lname,  dept,  jobt)
            { 
                MonthlySalary = monthlysalary;
            }

            public override decimal CalculateSalary() 
            { 
            
                return MonthlySalary + (MonthlySalary * 12);
            
            }

            public class PartTimeEmployee : Employee
            { 
            
               decimal RatePerHour { get; set; }
               int TotalHoursWorked { get; set; }

                public PartTimeEmployee(string fname, string lname, string dept, string jobt, decimal ratePerHour)
                    : base(fname, lname, dept, jobt)
                { 
                    RatePerHour = ratePerHour;

                }

                public void AddHours(int  hours) 
                {

                    TotalHoursWorked = hours;
                    
                }

                public override decimal CalculateSalary()
                {
                        return TotalHoursWorked * RatePerHour;
                }

                public class Intern : Employee 
                {
                
                    public decimal MonthlyStipend { get; set; }

                    public Intern(string fname, string lname, string dept, string jobt, decimal monthlys)
                        : base(fname, lname, dept, jobt)
                    { 
                    
                        MonthlyStipend = monthlys;  

                    }
                    public override decimal CalculateSalary()
                    {

                        return MonthlyStipend;

                    }

                    public class ContractEmployee : Employee
                    {

                        public decimal RatePerHour { get; set; }
                        public int TotalHoursWorked{ get; set; }

                        public ContractEmployee(string fname, string lname, string dept, string jobt, decimal ratePerHour)
                            : base(fname, lname, dept, jobt)
                        { 
                        
                            RatePerHour=ratePerHour;

                        }

                        public void AddHours(int hours) 
                        {

                            TotalHoursWorked = hours;
                        
                        }

                        public override decimal CalculateSalary()
                        { 
                        
                            return TotalHoursWorked * RatePerHour;
                        
                        }
                    
                    }
                }
            }
        
        
        }
    
    }
}
