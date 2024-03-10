using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstyBank
{
    internal class Loan
    {
        public decimal Amount { get; set; }


        public Loan (decimal amount)
        {
            this.Amount = amount;
        }

    }
}
