using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PG3302.CardGame
{
    class Deck : Card
    {
        public List<Card> DeckOfCards { get; set; } //list of all playing cards
        
        public void ArrangeDeck()
        {
            DeckOfCards = new List<Card>();
            
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Ranks rank in Enum.GetValues(typeof(Ranks)))
                {
                    DeckOfCards.Add(new Card(rank, suit));
                }
            }
        }
        
    }
}

    

