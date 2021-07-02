using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasaAbstrakcyjna
{
    class Product : AbstractProduct
    {
        private string barcode;
        public Product(string name, double price, string barcode) : base(name, price)
        {
            this.barcode = barcode;
        }
        public override void ShowPrice()
        {
            Console.WriteLine("cena produktu={0}", price);
        }
    }
}
