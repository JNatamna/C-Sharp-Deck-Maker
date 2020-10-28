using System;
using System.Collections.Generic;
using System.Text;

namespace Cardgame
{
    public class Card
    {
        public CardNumber Number { get; private set; }
        public Suit Suit { get; private set; }

        public Card(CardNumber number, Suit suit)
        {
            Number = number;
            Suit = suit;
        }
    }

    public enum CardNumber
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
        King
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
}
