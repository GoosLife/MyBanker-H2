using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Account
    {
        public int AccountNumber { get; private set; }
        public byte Age { get; private set; }
        public string Name { get; set; }
        private List<Card> cards = new List<Card>();

        public Account(byte age, string name)
        {
            Age = age;
            Name = name;
        }

        public Card[] GetAllCards() {
            return cards.ToArray();
        }

        public bool AddCard(Card card)
        {
            if (card.MinimumAge <= Age)
            {
                cards.Add(card);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
