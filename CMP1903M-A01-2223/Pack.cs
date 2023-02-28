namespace CMP1903M_A01_2223 {

    class Pack {

        static List<Card> pack = new List<Card>(52);

        public Pack() {

        // Creates a new pack of cards with 52 cards in it (4 suits, 13 values)
            for (int i = 1; i < 5; i++) {
                for (int j = 1; j < 14; j++) {
                    pack.Add(new Card(j, i));
                }
            }
        }

    // Shuffles the pack based on the type of shuffle specified
        public static bool shuffleCardPack(int typeOfShuffle) {
            
            switch (typeOfShuffle) {
            // Fisher Yates Shuffle
                case 1:
                    pack = Shuffle.fisherYatesShuffle(pack);
                    return true;
            // Riffle Shuffle
                case 2:
                    pack = Shuffle.riffleShuffle(pack);
                    return true;
            // No Shuffle
                case 3:
                    pack = Shuffle.noShuffle(pack);
                    return true;
            // Invalid Shuffle
                default:
                    Console.WriteLine("Invalid Shuffle Type: " + typeOfShuffle);
                    return false;
            }
        }

        public static Card deal() {

        // Gets the first card in the pack
            Card returnCard = pack[0];
        // Removes the card from the pack
            pack.RemoveAt(0);
        // Returns a single card from the pack
            return returnCard;
        }
        
        public static List<Card> dealCard(int amount) {

        // Creates a new list of cards to return
            List<Card> returnCards = new List<Card>(amount);

        // Adds the specified amount of cards to the return list
            for (int i = 0; i < amount; i++) {
                returnCards.Add(deal());    
            }

            return returnCards;
        }
    }
}
