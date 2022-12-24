namespace EmployeeWageProblem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilderArray.addCompanyEmpWage("reliance", 10, 4, 20);
            empWageBuilderArray.computeEmpWage();

        }
    }
}