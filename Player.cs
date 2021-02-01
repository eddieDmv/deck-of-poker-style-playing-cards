using System.Collections.Generic;

namespace deck_of_playing_cards
{
    class Player
    {
        public string name { get; set; }

        public List<Card> hand = new List<Card>();

        public Player(string playerName)
        {
            name = playerName;
        }

        public Card DealerDrawToCaller(Deck deck, Player player)
        {
            if (deck.cards.Count != 0)
            {
                string currentPlayer = player.name;
                Card newCard = deck.DealOneCard();
                System.Console.WriteLine($"Dealer drew {newCard.stringVal} of {newCard.suit} and dealing to player {currentPlayer}");
                System.Console.WriteLine("-----------");
                hand.Add(newCard);
                return newCard;
            }
            else
            {
                System.Console.WriteLine("The deck is empty and no card to deal.");
                return null;
            }
        }

        public void ReadPlayerHand(List<Card> playerHand)
        {
            System.Console.WriteLine("--- Reading Player Hand ---");
            foreach (Card card in playerHand)
            {
                System.Console.WriteLine($"{card.stringVal} of {card.suit}");
            }
        }

    }
}
