using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfWar.Objects
{
    public enum CardSuit
    {
        Hearts,
        Spades,
        Diamonds,
        Clubs
    }
    public class Card
    {
        public CardSuit Suit;
        public int Value { get; }
        public Card(CardSuit suit, int value)
        {
            Suit = suit;
            Value = value;
        }
        public override string ToString()
        {
            string valueDisplay = "";
            if (Value <= 10)
            {
                valueDisplay = Value.ToString();
            }
            else if (Value == 11)
            {
                valueDisplay = "Jack";
            }
            else if (Value == 12)
            {
                valueDisplay = "Queen";
            }

            else if (Value == 13)
            {
                valueDisplay = "King";
            }
             else if (Value == 14)
            {
                valueDisplay = "Ace"; ;
            }
            return ($"{valueDisplay} of {Suit}");
        }
    }
}
