using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cardgame
{
    public class Deck
    {
       // private static Random random = new Random();

        public List<Card> Cards { get; private set; }

        private Deck()
        {
            // This is private so that Deck.CreateFullDeck() is used to create a deck
            Cards = new List<Card>();
        }

        /// <summary>
        /// Creates the deck of cards, from Ace to King by suit.
        /// </summary>
        /// <returns>The initialized deck of cards</returns>
        public static Deck CreateFullDeck()
        {
            Deck deck = new Deck();
            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                for (int cardNumberIndex = 0; cardNumberIndex < 13; cardNumberIndex++)
                {
                    deck.Cards.Add(new Card((CardNumber)cardNumberIndex, (Suit)suitIndex));
                }
            }
            return deck;
        }

    }
}
