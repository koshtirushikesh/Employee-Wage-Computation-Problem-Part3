using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem3
{
    public class Employee
    {
        public void Wage()
        {
            int IS_FULL_TIME = 1;
            int empWage = 0;
            int empHrs = 0;
            int EMP_RATE_PER_HOUR = 20;


            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;

            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine(": " + empWage);
        }
    }
}
