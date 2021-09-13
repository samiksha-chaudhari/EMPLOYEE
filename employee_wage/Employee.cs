using System;
using System.Collections.Generic;
using System.Text;

namespace employeeWage
{
    public class EmpWageBuilderObject
    {
        //Contant
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string COMPANY;
        private  int EMP_RATE_PER_HOUR;
        private  int NUM_OF_WORKING_DAYS;
        private  int MAX_HRS_IN_MONTH;
        private int totalEmpWage;

        public EmpWageBuilderObject(string COMPANY, int EMP_RATE_PER_HOUR, int NUM_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
              this.COMPANY = COMPANY;
              this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
              this.NUM_OF_WORKING_DAYS = NUM_OF_WORKING_DAYS;
              this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;
            
        }


        public void computeEmpWage()
        {
            //Variable
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHr = 0;
            while (totalEmpHr <= this.MAX_HRS_IN_MONTH && totalWorkingDays < this.NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                //Computation
                int empCheck = random.Next(0, 2);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 8;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHr += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + "       " + "Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHr * this.EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
           
        }
        public string toString()
        {
            return "total emp wage for company : " + this.COMPANY + "is" + this.totalEmpWage;
        }
    }
}
