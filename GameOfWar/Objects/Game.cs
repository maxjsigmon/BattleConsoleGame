using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfWar.Objects
{
    class Game
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Deck CardDeck { get; set; }
        public Game()
        {
            Console.WriteLine("Player One enter your name:");
            PlayerOne = new Player (Console.ReadLine());
            Console.WriteLine("Player Two enter your name:");
            PlayerTwo = new Player(Console.ReadLine());
            CardDeck = new Deck();
        }
        public void PlayGame()
        {
            Console.WriteLine("Press Enter to begin THE BATTLE and after each turn!");
 
            while (CardDeck.Cards.Count > 0)
            {
                Console.ReadKey();
                PlayersDrawCards();
                SeePoints();  
            }
            Console.WriteLine("Game Over!");
            DisplayWinner();
        }
        public void PlayersDrawCards()
        {
            Card playerOneDrawnCard = CardDeck.Cards.FirstOrDefault();
            CardDeck.Cards.Remove(playerOneDrawnCard);
            PlayerOne.CardsInHand.Add(playerOneDrawnCard);

            Card playerTwoDrawnCard = CardDeck.Cards.FirstOrDefault();
            CardDeck.Cards.Remove(playerTwoDrawnCard);
            PlayerTwo.CardsInHand.Add(playerTwoDrawnCard);

            if (playerOneDrawnCard.Value > playerTwoDrawnCard.Value)
            {
                PlayerOne.Points += 1;
                Console.WriteLine($"{PlayerOne.Name} won the draw with the {playerOneDrawnCard.ToString()} over " +
                                   $"{PlayerTwo.Name}'s {playerTwoDrawnCard.ToString()}");
            }
            else if (playerTwoDrawnCard.Value > playerOneDrawnCard.Value)
            {
                PlayerTwo.Points += 1;
                Console.WriteLine($"{PlayerTwo.Name} won the draw with the {playerTwoDrawnCard.ToString()} over " +
                                   $"{PlayerOne.Name}'s {playerOneDrawnCard.ToString()}");
            }
            else
            {
                Console.WriteLine("Tie. No Points");
            }
        }
        public void SeeDeck()
        {
            foreach (Card c in CardDeck.Cards)
            {
                Console.WriteLine($"{c.Value} of {c.Suit}");
            }
            Console.WriteLine($"Card Count - {CardDeck.Cards.Count}");
        }
        public void SeePoints()
        {
            Console.WriteLine($"{PlayerOne.Name} - { PlayerOne.Points} vs. {PlayerTwo.Name} - {PlayerTwo.Points}");
        }
        public void DisplayWinner()
        {
            if (PlayerOne.Points > PlayerTwo.Points)
            {
                Console.WriteLine($"{PlayerOne.Name} wins!");
            }
            else if (PlayerOne.Points < PlayerTwo.Points)
            {
                Console.WriteLine($"{PlayerTwo.Name} wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
    }
}
