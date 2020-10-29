using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGameV3
{
	class Program
	{
		static void Main(string[] args)
		{
			//1.) Create a deck of cards.
			Deck deck = new Deck();

			//2.) Display your deck of cards.
			Console.WriteLine("Displaying Deck of cards");
			Console.WriteLine(deck.ToString());

			//3.) Randomly shuffle your deck of cards.
			deck.ShuffleCards();

			//4.) Display your shuffled deck of cards.
			Console.WriteLine("Displaying Shuffled Deck of cards:");
			Console.WriteLine(deck.ToString());

			//5.) Deal 4 hands of 5 cards each to 4 players.   
			for (var i = 0; i < 4; i++)
			{
				String[] drawnCards = deck.DrawCards(i * 4 + 1, 5);
				//6.) Display each player's hand
				Console.WriteLine("Displaying hand for Player{0}:", i + 1);
				for (var j = 0; j < 5; j++)
				{
					Console.WriteLine(drawnCards[j]);
				}
			}

			//7.) Display remaining cards in the deck
			Console.WriteLine("Displaying remaining cards in the deck:");
			Console.WriteLine(deck.ToString());
		}
	}
}
	

