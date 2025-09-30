using EmployeeManagementSystem;
using System;
using static EmployeeManagementSystem.Employee;
using static EmployeeManagementSystem.Employee.FullTimeEmployee;
using static EmployeeManagementSystem.Employee.FullTimeEmployee.PartTimeEmployee;
using static EmployeeManagementSystem.Employee.FullTimeEmployee.PartTimeEmployee.Intern;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" === EMPLOYEE MANAGEMENT SYSTEM ===");
        Console.WriteLine();

        FullTimeEmployee fullTime = new FullTimeEmployee("John", "Cruz", "IT", "Software Engineer", 7000);

        PartTimeEmployee partTime = new PartTimeEmployee("Prince", "Marayag", "HR", "Assistant", 25);

        Intern intern = new Intern("Anika", "Esteria", "Marketing", "Trainee", 8000);

        ContractEmployee contract = new ContractEmployee("Coleen", "Trinidad", "Finance", "Consultant", 40);

        
        partTime.AddHours(100);
        contract.AddHours(160);

        
        fullTime.DisplaySalary();
        partTime.DisplaySalary();
        intern.DisplaySalary();
        contract.DisplaySalary();
    }
}
