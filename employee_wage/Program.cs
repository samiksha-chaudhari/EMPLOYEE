using System;

namespace employeeWage
{
    class Program
    {
        //Contant
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public static int computeWage()
        {
            //Variable
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHr = 0;
            while (totalEmpHr <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
            int totalEmpWage = totalEmpHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeWage();
        }
    }
}