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

        public bool AddProduct(Product product, uint qnty)
        {
            return false;
        }

        public bool RemoveProduct(Product product, uint qnty = 0)
        {
            return false;
        }
    }
}
