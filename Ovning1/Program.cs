using System;

namespace Ovning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee call = new Employee();
            Boolean continu= true;

            while (continu) {
                Console.WriteLine("hello  Do you want to add an employee  write yes or no ");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    call.EmployeeName();
                    call.EmployeeSalary();

                    Console.WriteLine("  Do you want to add more employeer  write yes or no ");
                    answer = Console.ReadLine();
                    if (answer == "no") break;

            }

            }
            call.EmployeeInfo();

        }
    }
}
