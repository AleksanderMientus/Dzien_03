using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MiniShop
{
    // Order/Zamówienie

    /// <summary>
    /// Przechowuje informacje o zamówieniu
    /// </summary>
    class Order
    {
        // typ wyliczeniowy dla statusu zamówienia
        enum OrderStatus
        {
            NewOrder = 10,
            Complete = 20,       // kolejna wartość 11 // +1 // można też z ręki ustawić numer
            Confirmed = 30,     // potwierdzone
            Shipped = 40,       // wysłane
            Returned = 50,      // zwrócone
            Cancelled = 60,     // anulowane
        }
        
        private string orderNumber;
        private string customerName;        // Nazwa klienta
        private string shipAddress;          // Adres sklepu
        private DateTime orderDate;         // data zamówienia
        private int discount = 0;           // zniżka
        private OrderStatus status = OrderStatus.NewOrder;      // status zamówienia
        private List<OrderItem> items = new List<OrderItem>(10);  // zadeklarowanie listy wartością pustą (długość=0), bez deklaracji NULL i nie można użyć

        /// <summary>
        /// czyści listę tylko dla statusu NewOrder
        /// </summary>
        /// <returns>
        /// True - jeśli udało się usunąć. 
        /// False - zamówienie w innym statusie niż NewOrder
        /// </returns>
        public bool Clear()
        {
            if (status == OrderStatus.NewOrder)
            {
                items.Clear();
                return true;
            }
            return false;
        }

        private int GetProductIndex(Product product)
        {
            int result = -1;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ProductName.Equals(product.Name)) {
                    return i;
                }
            }
            return result;
        }
        public bool AddProduct(Product product, uint qnty)
        {
            // warunek
            if (!(status==OrderStatus.NewOrder && qnty>0 && product!=null))
                return false;

            // kontynuuj dodawanie
            //      int productIndex = GetProductIndex(product);
            //  wyrażenie lambda lub funkcja anonimowa
            int productIndex = items.FindIndex(x => x.ProductName.Equals(product.Name));    // zmiast GetProductIndex
            
            if (productIndex == -1)
            {
                items.Add(new OrderItem(product, qnty));
            } 
            else
            {
                items[productIndex].Qnty += qnty;
            }
            
            return true;
        }

        public bool RemoveProduct(Product product, uint qnty = 0)
        {
            // warunek
            if (!(status == OrderStatus.NewOrder && qnty >= 0 && product != null))
                return false;

            int productIndex = GetProductIndex(product);
            if (productIndex == -1) return false; // nie znaleziono produktu

            // zabezpieczenie na okoliczność podania qnty > na bieżący stan dla poz. zamówienia
            if (qnty > items[productIndex].Qnty) return false;

            // usuwanie, gdy qnty = 0 lub qnty jest równe bieżącej liczbie produktu zamówienia
            if (qnty == 0 || qnty == items[productIndex].Qnty)
            {
                items.RemoveAt(productIndex);
                return true;
            }

            items[productIndex].Qnty = qnty;
            return true;

        }

        public double CalcTotalAmount()
        {
            double amount = 0.0;
            foreach (var item in items)
            {
                amount += item.Qnty * item.ProductPrice;
            }
            // 
            // Rozwiąznie powyższego za pomocą lambda
            //  items.ForEach(x => amount += x.Qnty * x.ProductPrice);
            //

            // aplikacja zniżki
            if (discount>0 && discount<100)
            {
                amount *= (100 - discount) / 100.0;  // jeżeli dzieli się przez int to wynik jest calkowity
            }
            return amount;
        }

        public void Print()
        {
            Console.WriteLine("Pozycje zamówienia");

            items.ForEach(e => Console.WriteLine("{0,-20} | {1,10} | {2,10:0.00} | {3,10:0.00} ", e.ProductName, e.Qnty, e.ProductPrice, e.Qnty * e.ProductPrice));

            Console.WriteLine("");
            // to samo co powyżej
            foreach (var e in items)
            {
                Console.WriteLine("{0,-20} | {1,10} | {2,10:0.00} | {3,10:0.00} ",     // formatowanie {x, szerokość} / "-szerokość" formatowanie do lewej
                    e.ProductName,
                    e.Qnty,
                    e.ProductPrice,
                    e.Qnty*e.ProductPrice
                    );
            }

            Console.WriteLine("Do zapłaty: {0}", CalcTotalAmount());
        }
    }
}
