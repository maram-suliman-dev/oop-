namespace program_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            employee.name = "Maram";
            employee.age = 24;
            employee.salary = 1000;

            
            employee.PrintInfo();

            Console.WriteLine("print my name 3 times:");
            employee.PrintInfo(3); 
        }
    }
}