using System;

namespace DeckOfCards {
    public class Card {
        public string stringVal { get; set; }
        public string suits { get; set; }
        public int numVal { get; set; }

        public Card (string val1, string val2, int val3) {
            stringVal = val1;
            suits = val2;
            numVal = val3;
        }
    }
}