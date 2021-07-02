using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MiniShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Ryż", 2.99);
            Console.WriteLine(product1);

            Console.ReadKey();

        }

    }
}
