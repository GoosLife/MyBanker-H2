namespace MyBanker
{    
    /// <summary>
    /// Represents a card.
    /// </summary>
    public abstract class Card
    {
        /// <summary>
        /// The minimum age required to own the card.
        /// </summary>
        public byte MinimumAge { get; protected set; }

        /// <summary>
        /// The length of the card number.
        /// </summary>
        public byte CardNumberLength { get; protected set; } = 16;

        /// <summary>
        /// The account the card is associated with.
        /// </summary>
        public Account Account { get; protected set; }

        /// <summary>
        /// The card number.
        /// </summary>
        public string CardNumber { get; protected set; }

        /// <summary>
        /// The expiry date of the card.
        /// </summary>
        public DateTime ExpiryDate { get; protected set; }

        /// <summary>
        /// List of prefixes valid for the card type.
        /// </summary>
        protected List<string> prefixes = new List<string>();

        /// <summary>
        /// Creates a new card associated with the specified account.
        /// </summary>
        /// <param name="account"></param>
        public Card(Account account)
        {
            Account = account;
            CardNumber = GenerateCardNumber();
            ExpiryDate = GenerateExpiryDate();
        }

        /// <summary>
        /// Simulate a withdrawal from the card.
        /// </summary>
        public void Withdraw()
        {
            Console.WriteLine(Account.Name + " withdrew money from " + CardNumber);
        }
        
        /// <summary>
        /// Simulate a deposit to the card.
        /// </summary>
        public void Deposit()
        {
            Console.WriteLine(Account.Name + " deposited money to " + CardNumber);
        }

        /// <summary>
        /// Generates a random card number based on the card type's prefix and the length of the card number.
        /// </summary>
        /// <returns></returns>
        protected virtual string GenerateCardNumber()
        {
            Random rand = new Random();
            string prefix = prefixes[rand.Next(0, prefixes.Count())];
            string cardNumber = prefix;

            for (int i = 0; i < (CardNumberLength - prefix.Length); i++)
            {
                cardNumber += rand.Next(0, 10);
            }

            return cardNumber;
        }

        /// <summary>
        /// "Generates" an expiry date for the card. 
        /// Since the maximum expiry date for most cards is 5 years, that is the default implementations return value, but it can be overridden.
        /// </summary>
        /// <returns></returns>
        protected virtual DateTime GenerateExpiryDate()
        {
            return DateTime.Now.AddYears(5);
        }
    }
}