using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    /// <summary>
    /// Interface for making online transactions.
    /// </summary>
    public interface IInternationalTransaction
    {
        /// <summary>
        /// Make an international transaction.
        /// </summary>
        void MakeInternationalTransaction();
    }
}
