using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    /// <summary>
    /// Represents a credit card.
    /// </summary>
    public abstract class CreditCard : Card
    {
        /// <summary>
        /// The total credit available on the card.
        /// </summary>
        public int TotalCredit { get; protected set; }

        /// <summary>
        /// The amount of credit used on the card.
        /// </summary>
        public int UsedCredit { get; protected set; } = 0;

        /// <summary>
        /// The amount of credit available on the card.
        /// </summary>
        public int AvailableCredit { get => TotalCredit - UsedCredit; }

        /// <summary>
        /// Create a new credit card with the specified account and total credit.
        /// </summary>
        /// <param name="account">The account associated with this credit card.</param>
        /// <param name="totalCredit">The total starting credit.</param>
        public CreditCard(Account account, int totalCredit) : base(account) 
        {
            TotalCredit = totalCredit;
        }

        /// <summary>
        /// Simulate paying off credit on the card.
        /// </summary>
        /// <param name="amountToPay"></param>
        public void PayOffCredit(int amountToPay)
        {
            UsedCredit -= amountToPay;
        }
    }
}
