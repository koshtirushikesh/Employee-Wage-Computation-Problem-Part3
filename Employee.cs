using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem3
{
    public class Employee
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int NUM_OF_WORKING_HOUR = 100;
        public void WagesforMonth()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHour = 0;
            int totalWorkingDay = 0;

            while (totalEmpHour < NUM_OF_WORKING_HOUR && totalWorkingDay < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDay++;
                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {
                    case IS_FULL_TIME: empHrs = 8; break;
                    case IS_PART_TIME: empHrs = 4; break;

                    default: empHrs = 0; break;
                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine(": " + empWage);
                totalEmpWage += empWage;
            }
            Console.WriteLine("total employee wage:" + totalEmpWage);

        }
    }
}
