namespace program_Rectangle
{
    internal class Program
    {
        static void Main()
        {

            Rectangle rectangle = new Rectangle();

            int areaWithArgs = rectangle.CalculateArea(2, 6);
            Console.WriteLine("Area using method with arguments: " + areaWithArgs);

            rectangle.SetDimensions(8, 4);

            int areaNoArgs = rectangle.CalculateArea();
            Console.WriteLine("Area using method without arguments: " + areaNoArgs);
        }
    }
}