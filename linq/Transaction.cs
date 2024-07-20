using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Transaction
    {




     
            public DateTime TransactionDate { get; set; }
            public decimal Amount { get; set; }

            public Transaction(DateTime transactionDate, decimal amount)
            {
                TransactionDate = transactionDate;
                Amount = amount;
            }
        }

    }

