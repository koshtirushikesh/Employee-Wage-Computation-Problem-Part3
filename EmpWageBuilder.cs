using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem3
{
    public class EmpWageBuilder
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int EMP_RATE_PER_HOUR;
        private int MAX_OF_WORKING_DAYS;
        private int MAX_OF_WORKING_HOUR;
        private int totalEmpWage;


        public EmpWageBuilder(string company, int EMP_RATE_PER_HOUR, int MAX_OF_WORKING_DAYS, int MAX_OF_WORKING_HOUR)
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.MAX_OF_WORKING_DAYS = MAX_OF_WORKING_DAYS;
            this.MAX_OF_WORKING_HOUR = MAX_OF_WORKING_HOUR;
        }   
        public void WagesforMonth()
        {
            int empHrs = 0, empWage = 0, totalEmpWage = 0, totalEmpHour = 0, totalWorkingDay = 0;
            
            while (totalEmpHour <= MAX_OF_WORKING_HOUR && totalWorkingDay <= MAX_OF_WORKING_DAYS)
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
                empWage = empHrs * this.EMP_RATE_PER_HOUR;
                Console.WriteLine(": " + empWage);
                totalEmpWage += empWage;
            }
            this.totalEmpWage = totalEmpWage;
            Console.WriteLine("total employee wage:" + totalEmpWage);
        }
        public string tostring()
        {
            return "Total Emp Wage for company: " + this.company + " is :" + this.totalEmpWage;
        }
    }
}
