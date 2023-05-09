using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class VISADankort : CreditCard
    {
        public Limit MonthlyLimit { get; private set; } = new Limit(LimitInterval.MONTH, 20000);
        public VISADankort(Account account, int totalCredit = 25000) : base(account, totalCredit)
        {
            prefixes.Add("4");
            MinimumAge = 18;
        }
    }
}
