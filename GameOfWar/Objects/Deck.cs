using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfWar.Objects
{
    class Deck
    {
        public List<Card> Cards = new List<Card>();

        public Deck()
        {
            for (int suit = 0; suit <= 3; suit++)
            {
                CardSuit cardSuitType;
                if (suit == 0)
                {
                    cardSuitType = CardSuit.Hearts;
                }
                else if (suit == 1)
                {
                    cardSuitType = CardSuit.Diamonds;
                }
                else if (suit == 2)
                {
                    cardSuitType = CardSuit.Spades;
                }
                else
                {
                    cardSuitType = CardSuit.Clubs;
                }

                for (int cardValue = 2; cardValue <= 14; cardValue++)
                {
                    Card card = new Card(cardSuitType, cardValue);
                    Cards.Add(card);
                }
            }
            Shuffle();
        }
        private void Shuffle()
        {
            Random randy = new Random();
            int currentCardIndex = Cards.Count;
            while (currentCardIndex > 1)
            {
                currentCardIndex--;
                int swapIndex = randy.Next(currentCardIndex + 1);
                Card tempCard = Cards[swapIndex];
                Cards[swapIndex] = Cards[currentCardIndex];
                Cards[currentCardIndex] = tempCard;
            }
        }
    }
}