namespace program_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.name = "Ipone";
            product.price = 500;
            product.quantity = 1;

            
            double cost1 = product.TotalCost();
            Console.WriteLine($"Total cost for {product.name} = {cost1}");

            
            double cost2 = product.TotalCost(500, 2);
            Console.WriteLine("Total cost (custom values) = " + cost2);
        }
    }
    
}
