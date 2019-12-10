using System.Collections.Generic;

namespace DeckOfCards {
    //create a class called "Player"
    public class Player {
        //Give the Player class a name property.
        public string Name { get; set; }

        public Player (string number) {
            Name = number;
        }
        //Give the Player a hand property that is a List of type Card.
        public List<Card> hand = new List<Card> ();
        //Give the Player a draw method of which draws a card from a deck, adds it to the player 's hand and returns the Card. Note this method will require reference to a deck object
        public Card Draw (Deck deck) {
            Card drawnCard = deck.Deal ();
            hand.Add (drawnCard);
            return drawnCard;
        }
        // Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.
        public Card Discard (int idx) {
            if (idx > 0 && idx < hand.Count) {
                Card discardCard = hand[idx];
                hand.RemoveAt(idx);
                return discardCard;
            } else {
                return null;
            }
        }
    }
}