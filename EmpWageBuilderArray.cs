using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem3
{
    public class EmpWageBuilderArray : IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int numOfCompany = 0;
        private List<CompanyEmpWage> CompanyEmpWageArrayList;

        public EmpWageBuilderArray()
        {
            this.CompanyEmpWageArrayList = new List<CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int EMP_RATE_PER_HOUR, int MAX_OF_WORKING_DAYS, int MAX_OF_WORKING_HOUR)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, EMP_RATE_PER_HOUR, MAX_OF_WORKING_DAYS, MAX_OF_WORKING_HOUR);
            this.CompanyEmpWageArrayList.Add(companyEmpWage);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for (int i = 0;i<numOfCompany;i++)
            {
                int num = this.computeEmpWage(this.CompanyEmpWageArrayList[i]);
                CompanyEmpWageArrayList[i].setTotalEmpWage(num);
                Console.WriteLine(this.CompanyEmpWageArrayList[i].tostring());
            }
        }

        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, empWage = 0, totalEmpWage = 0, totalEmpHour = 0, totalWorkingDay = 0;
            
            while (totalEmpHour <= companyEmpWage.EMP_RATE_PER_HOUR && totalWorkingDay <= companyEmpWage.MAX_OF_WORKING_DAYS)
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
                empWage = empHrs * companyEmpWage.EMP_RATE_PER_HOUR;
                Console.WriteLine(": " + empWage);
                totalEmpWage += empWage;
            }
            return totalEmpWage;
        }
        
    }
}
