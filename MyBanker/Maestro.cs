using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    /// <summary>
    /// Represents a Maestro card.
    /// </summary>
    internal class Maestro : Card, IInternationalTransaction, IOnlineTransaction
    {
        /// <summary>
        /// Create a new Maestro card with the specified account.
        /// The prefixes for the maestro card, as well as the minimum age and card number length are defined in the constructor.
        /// Ideally, these would be defined in a config file or database.
        /// </summary>
        /// <param name="account"></param>
        public Maestro(Account account) : base(account)
        {
            prefixes.Add("5018");
            prefixes.Add("5020");
            prefixes.Add("5038");
            prefixes.Add("5893");
            prefixes.Add("6304");
            prefixes.Add("6759");
            prefixes.Add("6761");
            prefixes.Add("6762");
            prefixes.Add("6763");
            MinimumAge = 18;
            CardNumberLength = 19;
        }

        /// <summary>
        /// Implementation of the IInternationalTransaction interface.
        /// </summary>
        public void MakeInternationalTransaction()
        {
            Console.WriteLine("I think this is how you make an international transaction with a Maestro card...");
        }
        
        /// <summary>
        /// Implementation of the IOnlineTransaction interface.
        /// </summary>
        public void MakeOnlineTransaction()
        {
            Console.WriteLine("You have most definitely just made an online transaction with a Maestro card.");
        }

        /// <summary>
        /// Because the Maestro card has a different expiry date than the other cards, we override the GenerateExpiryDate method.
        /// </summary>
        protected override DateTime GenerateExpiryDate()
        {
            return DateTime.Now.AddYears(5).AddMonths(8);
        }
    }
}
