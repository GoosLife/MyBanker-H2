using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class VISAElectron : Card, IInternationalTransaction, IOnlineTransaction
    {
        public Limit MonthlyLimit { get; private set; } = new Limit(LimitInterval.MONTH, 10000);

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

        public void MakeInternationalTransaction()
        {
            Console.WriteLine("An international transaction was made using the IInternationalTransaction interface implementation on the VISA Electron card class.");
        }

        public void MakeOnlineTransaction()
        {
            Console.WriteLine("An online transaction was made using the IOnlineTransaction interface implementation on the VISA Electron card class.");
        }
    }
}
