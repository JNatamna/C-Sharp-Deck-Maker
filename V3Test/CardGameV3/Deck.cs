using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CardGameV3
{
	class Deck

	{

		
		enum Suit
		{
			Heart = 1, 
			Club, 
			Spade, 
			Diamond
		}

		
		enum Rank
		{
			Ace = 1, 
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

		private String[] _mDeck;

		public Deck()

		{

			_mDeck = CreateDeck();

		}

		public override string ToString()

		{

			String array = "";

			for (int i = 0; i < _mDeck.Length; i++)

			{

				if (_mDeck[i].CompareTo("") == 0)

					continue;

				array += _mDeck[i];

				array += "\n";

			}

			return array;

		}



		public void ShuffleIndexArray(int[] indexArray)

		{

			Random random = new Random();

			for (var i = 0; i < 52; i++)

			{

				var rNum = i + random.Next(52 - i);

				var temp = indexArray[rNum];

				indexArray[rNum] = indexArray[i];

				indexArray[i] = temp;

			}

		}

		public void ShuffleCards()

		{

			// create random number array with distinct values

			var indexArray = new int[52];

			for (var i = 0; i < 52; i++)

			{

				indexArray[i] = i;

			}

			ShuffleIndexArray(indexArray);

			String[] newDeck = new String[52];

			for (var i = 0; i < 52; i++)

			{

				newDeck[i] = _mDeck[indexArray[i]];

			}

			_mDeck = newDeck;

		}


		public String[] DrawCards(int startPosition, int numberOfcards)

		{

			String[] drawnCards = new String[numberOfcards];

			var startIndex = startPosition - 1;

			for (var itr = 0; itr < numberOfcards; itr++)

			{

				drawnCards[itr] = _mDeck[startIndex];

				_mDeck[startIndex] = ""; // remove the card from the deck

				startIndex++;

			}

			return drawnCards;

		}

		public String[] CreateDeck()

		{

			String[] theDeck = new String[52];

			for (var itr = 0; itr < 52; itr++)

			{
				var sName = Enum.GetName(typeof(Suit), (itr / 13 + 1));

				var counter = itr % 13;

				if (counter >= 0 && counter <= 13) // add cards for one suite

				{

					String cName = Enum.GetName(typeof(Rank), (counter + 1));

					var value = cName + " of " + sName;

					theDeck[itr] = value;

				}

			}

			return theDeck;

		}

	}
}