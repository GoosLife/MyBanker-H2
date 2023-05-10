using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    /// <summary>
    /// Represents a VISA Dankort.
    /// </summary>
    public class VISADankort : CreditCard
    {
        /// <summary>
        /// The monthly limit of the card.
        /// </summary>
        public Limit MonthlyLimit { get; private set; } = new Limit(LimitInterval.MONTH, 20000);

        /// <summary>
        /// Create a new VISA Dankort with the specified account and total credit.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="totalCredit"></param>
        public VISADankort(Account account, int totalCredit = 25000) : base(account, totalCredit)
        {
            prefixes.Add("4");
            MinimumAge = 18;
        }
    }
}
