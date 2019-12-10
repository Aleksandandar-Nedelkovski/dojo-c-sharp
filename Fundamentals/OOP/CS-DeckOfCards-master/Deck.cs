using System;
using System.Collections.Generic;

namespace DeckOfCards {
    public class Deck {
        // Give the Deck class a property called "cards" which is a list of Card objects.
        public List<Card> cards = new List<Card> ();
        // Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
        public Card Deal () {
            Card dealtCard = cards[cards.Count - 1];
            cards.RemoveAt (cards.Count - 1);
            return dealtCard;
        }
        // Give the Deck a reset method that resets the cards property to contain the original 52 cards.
        public Deck Reset () {
            Deck newDeck = new Deck ();
            return newDeck;
        }
        // Give the Deck a shuffle method that randomly reorders the deck's cards.
        public void Shuffle () {
            Random rand = new Random ();
            for (int i = cards.Count - 1; i > 0; i--) {
                int n = rand.Next (i + 1);
                Card temp = cards[i];
                cards[i] = cards[n];
                cards[n] = temp;
            }
        }
        // When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
        public Deck () {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            foreach (var suit in suits) {
                for (int i = 1; i <= 13; i++) {
                    if (i == 1) {
                        cards.Add (new Card ("Ace", suit, i));
                    } else if (i > 1 && i < 11) {
                        cards.Add (new Card (i.ToString (), suit, i));
                    } else if (i == 11) {
                        cards.Add (new Card ("Jack", suit, i));
                    } else if (i == 12) {
                        cards.Add (new Card ("Queen", suit, i));
                    } else {
                        cards.Add (new Card ("King", suit, i));
                    }
                }
            }
        }
    }
}