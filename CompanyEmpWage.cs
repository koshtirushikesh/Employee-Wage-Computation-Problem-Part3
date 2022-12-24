using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem3
{
    public class CompanyEmpWage
    {
        public string company;
        public int EMP_RATE_PER_HOUR;
        public int MAX_OF_WORKING_DAYS;
        public int MAX_OF_WORKING_HOUR;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int EMP_RATE_PER_HOUR, int MAX_OF_WORKING_DAYS, int MAX_OF_WORKING_HOUR)
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.MAX_OF_WORKING_DAYS = MAX_OF_WORKING_DAYS;
            this.MAX_OF_WORKING_HOUR = MAX_OF_WORKING_HOUR;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string tostring()
        {
            return "Total Emp Wage for company: " + this.company + " is :" + this.totalEmpWage;
        }
    }
}
