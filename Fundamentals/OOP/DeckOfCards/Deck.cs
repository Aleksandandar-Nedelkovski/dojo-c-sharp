using System;
using System.Collections.Generic;

namespace DeckOfCards {
    public class Deck {
        // Give the Deck class a property called "cards" which is a list of Card objects.
        public List<Card> cards = new List<Card> ();
        public Deck () {
            BuildDeck ();
        }
        public List<Card> BuildDeck () {
            // When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
            string[] cardVals = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen" };
            string[] suits = new string[] { "Hearts", "Spades", "Clubs", "Diamonds" };
            cards = new List<Card> ();
            for (int j = 0; j < suits.Length; j++) {
                for (int i = 0; i < cardVals.Length; i++) {
                    cards.Add (new Card (cardVals[i], suits[j], i + 1));
                }
            }
            return cards;
        }

        // Give the Deck a shuffle method that randomly reorders the deck 's cards.
        public void Shuffle () {
            Random rand = new Random ();
            for (int i = cards.Count - 1; i > 0; i--) {
                int n = rand.Next (i + 1);
                Card temp = cards[i];
                cards[i] = cards[n];
                cards[n] = temp;
            }
        }
        // Give the Deck a deal method that selects the "top-most"card, removes it from the list of cards, and returns the Card.
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
    }
}