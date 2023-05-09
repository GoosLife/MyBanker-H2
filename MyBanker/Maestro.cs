using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    internal class Maestro : Card, IInternationalTransaction, IOnlineTransaction
    {
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

        public void MakeInternationalTransaction()
        {
            Console.WriteLine("I think this is how you make an international transaction with a Maestro card...");
        }
        
        public void MakeOnlineTransaction()
        {
            Console.WriteLine("You have most definitely just made an online transaction with a Maestro card.");
        }

        protected override DateTime GenerateExpiryDate()
        {
            return DateTime.Now.AddYears(5).AddMonths(8);
        }
    }
}
