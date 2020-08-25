using System;

namespace Ovning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee call = new Employee();
            Boolean continu= true;
            Console.WriteLine("hello welcome to employee register");
            while (continu) {
                Console.WriteLine("  Do you want to add an employee  write yes or no ");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    call.EmployeeName();
                    call.EmployeeSalary();

              
            }
                else
                {
                    break;
                }

            }
            call.EmployeeInfo();

        }
    }
}
