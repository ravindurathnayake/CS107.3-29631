using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    class Employee
    {
        public int EmployeeID { get; }
        public string FullName { get; set; }
        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary cannot be negative.");
                }
            }
        }

        public Employee(int employeeID, string fullName, double salary)
        {
            EmployeeID = employeeID;
            FullName = fullName;
            Salary = salary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Full Name: " + FullName);
            Console.WriteLine("Salary: Rs." + Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //a)
            Employee employee = new Employee(101, " John", 500000);
            //b)
            Console.WriteLine("Employee ID: " + employee.EmployeeID);
            //c)
            employee.FullName = "John Doe";
            //d)
            employee.DisplayEmployeeInfo();

            // Attempting to modify the salary directly from external code
            // This will not work because Salary is a private field
            //employee.Salary = 60000; // This line will generate a compiler error

            Console.ReadKey();
        }
    }
}
