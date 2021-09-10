using System;

namespace employeeWage
{
    class Program
    {  static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            //Employee myCompany = new Employee();
           Employee.computeEmpWage("Dmart", 20, 2, 10);
            Employee.computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}