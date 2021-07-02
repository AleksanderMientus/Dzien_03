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
            Product product2 = new Product(2, "Mąka", 2.56);
            Product product3 = new Product(3, "Sól", 1.99);
            Product product4 = new Product(4, "Cukier", 3.99);
            Product product5 = null;

            Order order = new Order();
            order.AddProduct(product1, 5);
            order.AddProduct(product2, 2);
            order.AddProduct(product1, 2);
            order.AddProduct(product2, 3);

            order.RemoveProduct(product1, 3);
            order.RemoveProduct(product2);
            order.RemoveProduct(product3, 5);

            order.AddProduct(product3, 6);
            order.AddProduct(product4, 10);

            order.Print();

            Console.ReadKey();

        }

    }
}
