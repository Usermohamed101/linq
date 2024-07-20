using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Sale
    {



      
            public string Salesperson { get; set; }
            public decimal Amount { get; set; }

            public Sale(string salesperson, decimal amount)
            {
                Salesperson = salesperson;
                Amount = amount;
            }
        
    }
}
