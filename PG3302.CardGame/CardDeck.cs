using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PG3302.CardGame
{
    class CardDeck : Card
    {
        public List<Card> Deck; //list of all playing cards

        public void ArrangeDeck()
        {
            Deck = new List<Card>();
            
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Ranks rank in Enum.GetValues(typeof(Ranks)))
                {
                    Deck.Add(new Card(rank, suit));
                }
            }
        }
    }
}

    

