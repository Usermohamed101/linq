using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Order
    {

   
            public int OrderId { get; set; }
            public decimal Price { get; set; }

            public Order(int orderId, decimal price)
            {
                OrderId = orderId;
                Price = price;
            }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }

        public Order(DateTime orderDate, decimal amount)
        {
            OrderDate = orderDate;
            Amount = amount;
        }




    }
}
