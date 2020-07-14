using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Set(5000, "Xiaomi");
            p1.Get();
        }
    }
}
