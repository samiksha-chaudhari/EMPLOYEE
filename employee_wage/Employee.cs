using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    //using iterface
    public interface IComputeEmpWage //interface
    {
        public void addCompanyEmp(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths);
        public void computeEmpWage();

    }
    class EmpWageBuilder : IComputeEmpWage //EmpWageBuilder implimented IComputeEmpWage interface
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int companyCount = 0;
        private CompanyEmpWage[] companyEmpWages;

        public EmpWageBuilder()
        {
            this.companyEmpWages = new CompanyEmpWage[5];
        }

        public void addCompanyEmp(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths)
        {
            companyEmpWages[this.companyCount] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonths);
            companyCount++;
        }

        public void computeEmpWage() ////Computing employee wage
        {
            for (int i = 0; i < companyCount; i++)
            {
                companyEmpWages[i].setSalary(this.computeEmpWage(this.companyEmpWages[i]));
                Console.WriteLine(this.companyEmpWages[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHour = 0, workingDay = 0, totalHours = 0;
            int empCheck;
            Random random = new Random();
            while (workingDay <= companyEmpWage.numOfWorkingDays && totalHours <= companyEmpWage.maxHoursPerMonths)
            {
                workingDay++;
                empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHour = 8;
                        break;
                    case IS_FULL_TIME:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                totalHours += empHour;
                Console.WriteLine("Day {0} Employee hours {1}", workingDay, totalHours);
            }
            return totalHours * companyEmpWage.empRatePerHour;

        }
    }
}