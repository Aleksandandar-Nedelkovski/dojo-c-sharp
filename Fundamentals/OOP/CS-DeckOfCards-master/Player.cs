using System.Collections.Generic;

namespace DeckOfCards {
    // Give the Player class a name property.
    // Give the Player a hand property that is a List of type Card.
    // Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card. Note this method will require reference to a deck object
    // Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.
    public class Player {
        public string Name { get; set; }

        public Player (string nm) {
            Name = nm;
        }
        public List<Card> hand = new List<Card> ();
        public Card Draw (Deck deck) {
            Card drawnCard = deck.Deal ();
            hand.Add (drawnCard);
            return drawnCard;
        }
        public Card Discard (int idx) {
            if (idx > 0 && idx < hand.Count) {
                Card discardedCard = hand[idx];
                hand.RemoveAt (idx);
                return discardedCard;
            } else {
                return null;
            }
        }
    }
}