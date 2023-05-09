namespace MyBanker
{    
    public abstract class Card
    {
        public byte MinimumAge { get; protected set; }
        public byte CardNumberLength { get; protected set; } = 16;
        public Account Account { get; protected set; }
        public string CardNumber { get; protected set; }
        public DateTime ExpiryDate { get; protected set; }
        protected List<string> prefixes = new List<string>();

        public Card(Account account)
        {
            Account = account;
            CardNumber = GenerateCardNumber();
            ExpiryDate = GenerateExpiryDate();
        }

        public void Withdraw()
        {
            Console.WriteLine(Account.Name + " withdrew money from " + CardNumber);
        }
        
        public void Deposit()
        {
            Console.WriteLine(Account.Name + " deposited money to " + CardNumber);
        }

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
        protected virtual DateTime GenerateExpiryDate()
        {
            return DateTime.Now.AddYears(5);
        }
    }
}