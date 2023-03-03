namespace CMP1903M_A01_2223 {

    class Testing {

        bool repeat = true; // Used to check whether the user wants to repeat the program

        public Testing() {
            new Pack(); // Create a new pack of cards

            while (repeat) {
                selectMode();
            }
        }

        void selectMode() {

            bool selectedMode = false; // Used to check whether the user has selected a mode
            while (!selectedMode) {

                Console.WriteLine("Would you like to shuffle the pack or deal a card? (S/D): ");
                String mode = Console.ReadLine().ToUpper();

                if (mode == "") { // Go back
                    Console.WriteLine("You cannot go back at this point, but you can quit the program by typing 'Q'");

                } else
                if (mode == "Q") { // Quit the program
                    repeat = false;
                    return;

                } else
                if (mode == "S") { // Shuffle the pack
                    selectedMode = true;
                    shuffle();

                } else
                if (mode == "D") { // Deal a select number of cards
                    selectedMode = true;
                    deal();

                } else { Console.WriteLine("Invalid Input"); }
            }
        }

        void shuffle() {

            bool shuffleSuccess = false; // Used to check whether the user has successfully shuffled the pack
            while (!shuffleSuccess) {

                Console.WriteLine("Would you like to shuffle the pack using the Fisher-Yates shuffle algorithm, the riffle shuffle algorithm or don't shuffle the pack? (1/2/3): ");
                String input = Console.ReadLine().ToUpper();

                if (input == "") { // Go back
                    return;
                } else
                if (input == "Q") { // Quit the program
                    repeat = false;
                    return;
                } else {
                
                    try {

                        int shuffleType = Convert.ToInt32(input);
                        if (Pack.shuffleCardPack(shuffleType)) { shuffleSuccess = true; }
                        else { Console.WriteLine("Invalid Input"); }

                    } catch { Console.WriteLine("Invalid Input"); }
                }
            }
        }

        void deal() {

            if (Pack.GetPackSize() == 0) { // Check if the pack is empty

                Console.WriteLine("The pack is empty");
                repeat = false;
                return;

            } else {

                Console.WriteLine("How many cards would you like to deal? (1-" + Pack.GetPackSize() + "): ");
                String input = Console.ReadLine().ToUpper();
                
                if (input == "") { // Go back
                    return;
                } else
                if (input == "Q") { // Quit the program
                    repeat = false;
                    return;
                } else { // Deal the cards

                    try {

                        int amount = Convert.ToInt32(input);
                        if (amount > 0 && amount <= Pack.GetPackSize()) {

                            List<Card> dealtCards = Pack.dealCard(amount);

                            foreach (Card card in dealtCards) {
                                Console.WriteLine(card.ToString()); // Print the Dealt Cards
                            }

                            if (Pack.GetPackSize() == 0) { // Check if the pack is empty after dealing
                                Console.WriteLine("The pack is now empty");
                                repeat = false;
                                return;
                            }

                        } else { Console.WriteLine("Invalid Input"); }
                    } catch { Console.WriteLine("Invalid Input"); }
                }
            }
        }
    }
}