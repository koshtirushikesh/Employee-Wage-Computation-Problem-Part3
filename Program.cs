namespace EmployeeWageProblem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder dmart = new EmpWageBuilder("Dmart", 10, 4, 20);
            dmart.WagesforMonth();
            Console.WriteLine(dmart.tostring());

            EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
            reliance.WagesforMonth();
            Console.WriteLine(reliance.tostring());
        }
    }
}