using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    /// <summary>
    /// Represents a VISA Electron card.
    /// </summary>
    public class VISAElectron : Card, IInternationalTransaction, IOnlineTransaction
    {
        /// <summary>
        /// The daily limit of the card.
        /// </summary>
        public Limit MonthlyLimit { get; private set; } = new Limit(LimitInterval.MONTH, 10000);

        /// <summary>
        /// Create a new VISA Electron card with the specified account.
        /// </summary>
        /// <param name="account"></param>
        public VISAElectron(Account account) : base(account)
        {
            prefixes.Add("4026");
            prefixes.Add("417500");
            prefixes.Add("4508");
            prefixes.Add("4844");
            prefixes.Add("4913");
            prefixes.Add("4917");
            MinimumAge = 15;
        }

        /// <summary>
        /// Make an international transaction.
        /// </summary>
        public void MakeInternationalTransaction()
        {
            Console.WriteLine("An international transaction was made using the IInternationalTransaction interface implementation on the VISA Electron card class.");
        }

        /// <summary>
        /// Make an online transaction.
        /// </summary>
        public void MakeOnlineTransaction()
        {
            Console.WriteLine("An online transaction was made using the IOnlineTransaction interface implementation on the VISA Electron card class.");
        }
    }
}
