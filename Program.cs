using System;

namespace deck_of_playing_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player player1 = new Player("Eddie");
            
            Console.WriteLine("--- Deck before shuffling ---");
            deck.ReadDeck();
            
            deck.Shuffle();
            Console.WriteLine("--- Deck After shuffling ---");
            deck.ReadDeck();

            Console.WriteLine($"Card left: {deck.cards.Count}");
            while (deck.cards.Count != 0)
            {
                player1.DealerDrawToCaller(deck, player1);                
            }

            Console.WriteLine($"Card left: {deck.cards.Count}");
            player1.DealerDrawToCaller(deck, player1);
            
            player1.ReadPlayerHand(player1.hand);            
        }
    }
}
