using System;
using System.Collections.Generic;
using System.Text;

namespace PG3302.CardGame
{
    class Card
    {
        //Create all suits in a deck of cards
        public enum Suits
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs,
        }

        //Create ranks
        public enum Ranks
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
        }

        public Suits suit;
        public Ranks rank;

        public Card(Ranks iRank, Suits iSuit)
        {
            suit = iSuit;
            rank = iRank;
        }


    }
}
