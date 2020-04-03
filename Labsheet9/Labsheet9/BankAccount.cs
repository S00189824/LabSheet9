using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet9
{
    public class BankAccount
    {
        public decimal Balance { get; set; }
        public decimal OverDraftLimit { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            decimal avaolableFunds = Balance + OverDraftLimit;
            if(amount <= avaolableFunds)
                Balance -= amount;

        }
    }
}
