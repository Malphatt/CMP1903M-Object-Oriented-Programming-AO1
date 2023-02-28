namespace CMP1903M_A01_2223 {

    class Card {

        private int value;
        private int suit;

        public Card(int value, int suit) {
            this.value = value;
            this.suit = suit;
        }

        public int Value { get { return value; } }
        public int Suit { get { return suit; } }
    }
}
