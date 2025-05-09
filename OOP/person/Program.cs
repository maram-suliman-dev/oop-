namespace program_person
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Person person = new Person();

            person.Name = "Maram Suliman";

            person.Age = 24;


            Console.WriteLine("one time:");
            person.PrintInfo(1);

            Console.WriteLine("five times:");
            person.PrintInfo(5);
        }
    }
}