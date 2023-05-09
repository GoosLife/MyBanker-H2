using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class MasterCard : CreditCard
    {
        Limit DailyLimit = new Limit(LimitInterval.DAY, 5000);
        Limit MonthlyLimit = new Limit(LimitInterval.MONTH, 30000);

        public MasterCard(Account account, int totalCredit = 40000) : base(account, totalCredit)
        {
            prefixes.Add("51");
            prefixes.Add("52");
            prefixes.Add("53");
            prefixes.Add("54");
            prefixes.Add("55");
            MinimumAge = 0; // Really???
        }
    }
}
