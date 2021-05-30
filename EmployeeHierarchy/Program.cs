using EmployeesLibrary;
using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees(
                "Employee4,Employee2,500" +
                "\n" +
                "Employee3,Employee1,800" +
                "\n" +
                "Employee1,,1000" +
                "\n" +
                "Employee5,Employee1,500" +  
                "\n" +
                "Employee2,Employee1,500" 
                );

            int salary = employees.managerSalaryBudget("Employee1");

            Console.WriteLine(salary);
        }

    }
}
