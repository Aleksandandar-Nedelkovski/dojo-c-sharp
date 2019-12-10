using System;

namespace DeckOfCards {
    class Program {
        static void Main (string[] args) {
            // Initialize new deck and shuffle
            Deck whatever = new Deck ();
            whatever.BuildDeck ();
            whatever.Shuffle ();
            // Console.WriteLine (whatever.Shuffle ());

            // Initialize new player
            Player alex = new Player ("Alex");
            Console.WriteLine (alex);

            // Deal five cards and add them to player's hand
            Card first = whatever.Deal ();
            alex.hand.Add (first);
            Card second = whatever.Deal ();
            alex.hand.Add (second);
            Card third = whatever.Deal ();
            alex.hand.Add (third);
            Card fourth = whatever.Deal ();
            alex.hand.Add (fourth);
            Card fifth = whatever.Deal ();
            alex.hand.Add (fifth);

            // Print cards in initial hand
            Console.WriteLine ($"{alex.Name}'s hand:");
            foreach (var card in alex.hand) {
                Console.WriteLine ($"{card.stringVal} of {card.suits} ");
            }
            // Discard last card and print remaining cards
            alex.Discard (4);
            Console.WriteLine ("Hand after Discard");
            Console.WriteLine ($"{alex.Name}'s new hand:");
            foreach (var card in alex.hand) {
                Console.WriteLine ($" {card.stringVal} of {card.suits}");
            }
            // Draw a new card from the deck and print new hand
            Card drawnCard = alex.Draw (whatever);
            Console.WriteLine ("Hand after Draw");
            Console.WriteLine ($"{alex.Name}'s new hand:");
            foreach (var card in alex.hand) {
                Console.WriteLine ($"The {card.stringVal} of {card.suits}");
            }
        }
    }
}