using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_Product
{
    internal class Product

    {
        public string name;
        public int price;
        public int quantity;

        public double TotalCost()
        {
            return price * quantity;
        }

        public double TotalCost(double customPrice, double customQuantity)
        {
            return customPrice * customQuantity;
        }
    }
}