using System;
using System.IO;

namespace EmployeeWage
{

    public class Program
    {
        static void Main(string[] args) //main method
        {
          
            EmpWageBuilder empWageBuilder = new EmpWageBuilder(); // object is created
            empWageBuilder.addCompanyEmp("Dmart", 20, 20, 58);
            empWageBuilder.addCompanyEmp("Reliance", 25, 10, 70);
            empWageBuilder.computeEmpWage();
        }
    }
}