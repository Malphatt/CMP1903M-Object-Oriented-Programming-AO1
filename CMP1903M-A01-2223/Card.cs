namespace CMP1903M_A01_2223 {

    class Card {

        public Card(int suit, int value) {
            Suit = suit;
            Value = value;
        }

        // Encapsulation has been used to ensure that the value and suit of a card cannot be changed to an invalid value
        // Value and Suit are private and can only be accessed through the public get and set methods
        int _value;
        public int Value {
            get { return _value; }
            set {
                if (value > 0 && value < 14) {
                    _value = value;
                } else {
                    throw new Exception("Invalid Card Value: " + value);
                }
            }
        }
        int _suit;
        public int Suit {
            get { return _suit; }
            set {
                if (value > 0 && value < 5) {
                    _suit = value;
                } else {
                    throw new Exception("Invalid Card Suit: " + value);
                }
            }
        }

        public override String ToString() {

            String[] cardSuits = new String[4] { "Spades", "Hearts", "Clubs", "Diamonds" };
            String[] cardValues = new String[13] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            return cardValues[Value - 1] + " of " + cardSuits[Suit - 1];
        }
    }
}
