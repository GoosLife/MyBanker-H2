using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public enum LimitInterval
    {
        DAY,
        MONTH
    }

    public class Limit
    {
        public LimitInterval Interval { get; private set; }
        public int LimitAmount { get; private set; }

        public Limit(LimitInterval interval, int limitAmount)
        {
            Interval = interval;
            LimitAmount = limitAmount;
        }
    }
}
