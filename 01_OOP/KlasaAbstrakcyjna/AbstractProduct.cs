using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.KlasaAbstrakcyjna
{
    /// <summary>
    /// Klasa abstrakcyjna.
    /// Nie można jej bezpośrednio użyć.   ?
    /// </summary>
    abstract class AbstractProduct
    {
        // podajemy tylko zajawkę
        // czym się różni od interface ? - oprócz metod można deklarować konstruktor, pola, metody
        // interface na sterydach
        public abstract void ShowPrice();

        protected string name;
        protected double price;

        public AbstractProduct(string n, double p)
        {
            name = n; price = p;
        }

        public void ShowInfo()
        {
            Console.WriteLine("nazwa: {0}, cena={1}", name, price);
        }
    }
}
