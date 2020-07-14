using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        private int cost;
        private string brand;

        internal void Set(int cost, string brand)
        {
            this.cost = cost;
            this.brand = brand;
        }

        internal void Get()
        {
            Console.WriteLine($"Brand: {brand} Cost: {cost}");
        }

    }
}
