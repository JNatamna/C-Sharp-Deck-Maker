using System;
using System.Collections.Generic;
using System.Linq;

namespace PG3302.CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();

            for (int i = 0; i < deck.Cards.Count; i++)
            {
                int y = i + 1;
                Console.WriteLine("Amount is: {0}, Card type is: {1}, Card number is: {2}", y, deck.Cards[i].Suit, deck.Cards[i].Rank);
            }
        }
    }
}