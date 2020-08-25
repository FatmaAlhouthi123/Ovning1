using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning1
{
    class Employee
    {

        public void EmployeeNameSalary()
        {
            Console.WriteLine("Enter employee name please:");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter employee salary please:");
            float employeeSalary = int.Parse(Console.ReadLine());
            Console.WriteLine("name: " + employeeName + "     salary: " + employeeSalary + "kr");

        }
    }
}
