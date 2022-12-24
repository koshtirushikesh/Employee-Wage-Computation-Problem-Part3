using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem3
{
    public class ComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
       
        public void WagesforMonth(string company,int EMP_RATE_PER_HOUR,int MAX_OF_WORKING_DAYS,int MAX_OF_WORKING_HOUR)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHour = 0;
            int totalWorkingDay = 0;

            while (totalEmpHour < MAX_OF_WORKING_HOUR && totalWorkingDay < MAX_OF_WORKING_DAYS)
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
                totalEmpHour += empHrs;
                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine(": " + empWage);
                totalEmpWage += empWage;
            }
            Console.WriteLine("total employee wage:" + totalEmpWage);

        }
    }
}
