using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PG3302.CardGame
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }

        //Objects for random generation, using lock object to guarantee thread safety
        private static readonly Random rand = new Random();
        private static readonly object syncLock = new object();


        /// Creates the deck of cards, from Ace to King by suit.
        public Deck()
        {
            Cards = new List<Card>();

            foreach (Suit cardSuit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank cardRank in Enum.GetValues(typeof(Rank)))
                {
                    Cards.Add(new Card(cardRank, cardSuit));
                }
            }

            ShuffleCards();
        }

        public void ShuffleCards()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                //FisherYates in-place shuffle

                //Store the card element
                var temp = Cards[i];

                //Store a random index position out from cards
                var index = RandomNumber(0, Cards.Count);

                //Give element in list a new index position
                Cards[i] = Cards[index];

                //Give the stored index the new card
                Cards[index] = temp;
            }
        }

        public int RandomNumber(int min, int max)
        {
            //Set lock to make sure the method is thread safe so that cards can not be affixed an already stored value
            lock (syncLock)
            {
                return rand.Next(min, max);
            }
        }
    }
}