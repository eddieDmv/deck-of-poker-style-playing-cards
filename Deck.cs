using System;
using System.Collections.Generic;

namespace deck_of_playing_cards
{
    class Deck
    {
        string[] stringCards = new string[]
        {"Ace", "2", "3", "4", "5", "6", "7","8", "9", "10", "Jack", "Queen", "King"};

        string[] suits = new string[]
        {
            "Clubs",
            "Spades",
            "Hearts",
            "Diamonds"
        };
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            foreach (string suit in suits)
            {
                int numVal = 1;

                foreach (var stringVal in stringCards)
                {
                    Card newCard = new Card(stringVal, suit);
                    cards.Add(newCard);
                    numVal++;
                }
            }
        }
        public void ReadDeck()
        {
            System.Console.WriteLine("--- Reading Deck ---");
            foreach (Card card in cards)
            {
                System.Console.WriteLine($"{card.stringVal} of {card.suit}");
            }
        }

        public void Shuffle()
        {
            System.Console.WriteLine("---Shuffling---");
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int newIndx = rand.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[newIndx];
                cards[newIndx] = temp;
            }
        }
        public Card DealOneCard()
        {
            Card dealtCard = cards[0];
            cards.Remove(dealtCard);
            return dealtCard;
        }

    }
}
