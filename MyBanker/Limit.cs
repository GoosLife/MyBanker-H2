using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    /// <summary>
    /// Represents the possible intervals for a limit.
    /// </summary>
    public enum LimitInterval
    {
        DAY,
        MONTH
    }

    /// <summary>
    /// Represents a limit on a card.
    /// </summary>
    public class Limit
    {
        /// <summary>
        /// The interval of the limit.
        /// </summary>
        public LimitInterval Interval { get; private set; }

        /// <summary>
        /// The amount of the limit.
        /// </summary>
        public int LimitAmount { get; private set; }

        /// <summary>
        /// Create a new limit with the specified interval and amount.
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="limitAmount"></param>
        public Limit(LimitInterval interval, int limitAmount)
        {
            Interval = interval;
            LimitAmount = limitAmount;
        }
    }
}
