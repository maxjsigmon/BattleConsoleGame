using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfWar.Objects
{
    class Player
    {
        public string Name { get; set; }
        public List<Card> CardsInHand { get; set; }
        public int Points { get; set; }
        public Player() { }
        public Player(string name)
        {
            Name = name;
            CardsInHand = new List<Card>();
            Points = 0;
        }
        public List<Card> Deal(List<Card> cards)
        {
            List<Card> player1cards = new List<Card>();
            List<Card> player2cards = new List<Card>();

            for (int i = 0; i <= cards.Count - 1; i++)
            {
                Card myCard = cards[i];
                if (i % 2 == 0)
                {
                    player2cards.Add(myCard);
                    cards.Remove(myCard);
                }
                else
                {
                    player1cards.Add(myCard);
                    cards.Remove(myCard);
                }
                return null;
            }
            return null;
        }
    }
}