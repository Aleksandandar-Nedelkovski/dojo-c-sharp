using System;

namespace DeckOfCards {
    class Program {
        static void Main (string[] args) {

            // Initialize new deck and shuffle
            Deck newDeck = new Deck ();
            newDeck.Shuffle ();

            // Initialize new player
            Player ciso = new Player ("Narciso Lobo");

            // Deal five cards and add them to player's hand
            Card firstCard = newDeck.Deal ();
            ciso.hand.Add (firstCard);
            Card secondCard = newDeck.Deal ();
            ciso.hand.Add (secondCard);
            Card thirdCard = newDeck.Deal ();
            ciso.hand.Add (thirdCard);
            Card fourthCard = newDeck.Deal ();
            ciso.hand.Add (fourthCard);
            Card fifthCard = newDeck.Deal ();
            ciso.hand.Add (fifthCard);

            // Print cards in initial hand
            Console.WriteLine ("**Initial Hand");
            Console.WriteLine ($"{ciso.Name}'s hand:");
            foreach (var card in ciso.hand) {
                Console.WriteLine ($"The {card.stringVal} of {card.suit}");
            }

            // Discard last card and print remaining cards
            ciso.Discard (4);
            Console.WriteLine ("**Hand after Discard");
            Console.WriteLine ($"{ciso.Name}'s new hand:");
            foreach (var card in ciso.hand) {
                Console.WriteLine ($"The {card.stringVal} of {card.suit}");
            }

            // Draw a new card from the deck and print new hand
            Card drawnCard = ciso.Draw (newDeck);
            Console.WriteLine ("**Hand after Draw");
            Console.WriteLine ($"{ciso.Name}'s new hand:");
            foreach (var card in ciso.hand) {
                Console.WriteLine ($"The {card.stringVal} of {card.suit}");
            }
        }
    }
}