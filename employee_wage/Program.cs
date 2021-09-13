using System;


namespace employeeWage
{
    class Program
    {  static void Main(string[] args)
        {
            EmpWageBuilderObject Dmart = new EmpWageBuilderObject("Dmart", 20, 2, 10);
            EmpWageBuilderObject Reliancee = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            Dmart.computeEmpWage();
            Console.WriteLine(Dmart.toString());
            Reliancee.computeEmpWage();
            Console.WriteLine(Reliancee.toString());

        }
    }
}