namespace program_calculate
{
    internal class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            int sum1 = calculator.Add (10, 7);         
            int sum2 = calculator.Add (12, 5, 1);     

            Console.WriteLine("10 + 7 = " + sum1);
            Console.WriteLine("12 + 5 + 1 = " + sum2);
        }
    }
}