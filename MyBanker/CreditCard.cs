using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class CreditCard : Card
    {
        public int TotalCredit { get; protected set; }
        public int UsedCredit { get; protected set; } = 0;
        public int AvailableCredit { get => TotalCredit - UsedCredit; }

        public CreditCard(Account account, int totalCredit) : base(account) 
        {
            TotalCredit = totalCredit;
        }

        public void PayOffCredit(int amountToPay)
        {
            UsedCredit -= amountToPay;
        }
    }
}
