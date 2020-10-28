using System;
using System.Collections.Generic;
using System.Linq;

namespace Cardgame
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck1 = Deck.CreateFullDeck();

            for (int i = 0; i < deck1.Cards.Count; i++)
            {
                int y = i+1;
                Console.WriteLine("Amount is: {0}, Card type is: {1}, Card number is: {2}", y, deck1.Cards[i].Suit, deck1.Cards[i].Number);
            }
        }
    }
}
