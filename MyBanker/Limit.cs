using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Limit
    {
        public string Interval { get; private set; }
        public int LimitAmount { get; private set; }

        public Limit(string interval, int limitAmount)
        {
            Interval = interval;
            LimitAmount = limitAmount;
        }
    }
}
