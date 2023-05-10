using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    /// <summary>
    /// Represents a debit card.
    /// </summary>
    public class DebitCard : Card
    {
        /// <summary>
        /// Create a new debit card with the specified account and prefixes.
        /// </summary>
        /// <param name="account"></param>
        public DebitCard(Account account) : base(account)
        {
            prefixes.Add("2400");
            MinimumAge = 0;
        }
    }
}
