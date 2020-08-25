using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning1
{
    class Employee
    {

      static List<string> EmployeeNameList = new List<string>();
       static List<float> EmployeeSarayList = new List<float>();
       static string names;
       static string salarys;
        static int EmplyeesNumber;




        public void EmployeeName()
        {

            EmplyeesNumber++;
            Console.WriteLine("Enter employee name please:");
            string employeeName = Console.ReadLine();
            

            EmployeeNameList.Add(employeeName);
           
            //Console.WriteLine("name: " + employeeName + "     salary: " + employeeSalary + "kr");

        }

        public void EmployeeSalary()
        {
            Console.WriteLine("Enter employee salary please:");
            float employeeSalary = int.Parse(Console.ReadLine());

           
            EmployeeSarayList.Add(employeeSalary);


        }
        public void EmployeeInfo()
        {
            for (int i = 0; i < EmplyeesNumber; i++)
            {
                Console.WriteLine("name:" + EmployeeNameList[i] + " salary" +  EmployeeSarayList[i]);
            }



           
          }



    }
}
