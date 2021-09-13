using System;
using System.IO;

namespace EmpWage
{

    public class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmp("Dmart", 20, 20, 58);
            empWageBuilder.addCompanyEmp("Reliance", 25, 10, 70);
            empWageBuilder.computeEmpWage();
        }
    }
}