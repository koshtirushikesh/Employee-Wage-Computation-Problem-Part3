namespace EmployeeWageProblem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputeEmpWage computeEmpWage = new ComputeEmpWage();
            computeEmpWage.WagesforMonth("dmart", 20, 3, 10);
            computeEmpWage.WagesforMonth("Reliance", 10, 4, 20);
        }
    }
}