using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class DebitCard : Card
    {
        public DebitCard(Account account) : base(account)
        {
            prefixes.Add("2400");
            MinimumAge = 0;
        }
    }
}
