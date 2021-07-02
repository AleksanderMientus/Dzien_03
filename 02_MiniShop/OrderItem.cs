using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MiniShop
{
    /// <summary>
    /// Przechowuje informacje o pozycji zamówienia
    /// </summary>
    class OrderItem
    {
        private Product product;
        private uint qnty;   // ilość / quantity - unit int od 0 - 49.... (32 bit)

        public string ProductName
        {
            get { return product.Name; }
        }
        
        public double ProductPrice 
        {
            get { return product.Price; }
        }
        
        // Właściwość Qnty
        public uint Qnty
        {
            get { return qnty; }    // do odczytu
            set { qnty = value; }   // do zapisu
        }
        public void UpdateQnty(int qnty)
        {
            this.qnty += (uint)qnty;
        }

        public OrderItem(Product product, uint qnty)
        {
            this.product = product;
            this.qnty = qnty;
        }


    }
}
