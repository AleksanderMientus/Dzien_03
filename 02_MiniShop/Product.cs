using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MiniShop
{
    /// <summary>
    /// Klasa opisująca produkt jednostkowy
    /// </summary>
    class Product
    {
        private int id;
        private string name;    // NULL - deklarowany string bez wartości
        private double price;
        private string descr = string.Empty;   // description - opis // string.Empty - ""
        private bool promo = false;
        private bool active = true;

        // właściwość (Z wielkiej litery), pola (z małej litery)
        // wystawianie wartości na zewnątrz bez robienia metody i bez możliwości zmiany z zewnątrz
        // gettery
        public bool Active 
        {
            get { return active; }
        }
        public double Price
        {
            get { return price; }
        }

        public string Name 
        { 
            get { return name; } 
        }

        public Product(int id, string name, double price, string descr = "")
        {
            this.id = id; this.name = name; this.price = price; this.descr = descr;
        }

        public void SetActive(bool active)
        {
            this.active = active;
        }

        public bool GetActive()
        {
            return active;
        }

        // nadpisanie metody ToString dziedziczonej po object
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", id, name, price);
        }


    }
}
