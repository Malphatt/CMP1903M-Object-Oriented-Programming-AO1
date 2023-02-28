namespace CMP1903M_A01_2223 {

    class Testing {

        public Testing() {
            new Pack();
            Pack.shuffleCardPack(1);
            Pack.shuffleCardPack(2);
            Pack.shuffleCardPack(3);
            List<Card> dealtCards = Pack.dealCard(4);
            foreach (Card card in dealtCards) {
                Console.WriteLine(card.Suit + " " + card.Value);
            }

        }
    }
}