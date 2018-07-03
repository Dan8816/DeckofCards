using System;

namespace deck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Card aceSpade = new Card("Ace", "Spades", 1);
            //System.Console.WriteLine("{0} of {1} w/val of {2}", aceSpade.NameVal, aceSpade.Soot, aceSpade.IntVal);
            Deck testDeck = new Deck();
            foreach (var item in testDeck.cards)
            {
                System.Console.WriteLine("{0},{1},{2}", item.NameVal, item.Soot, item.IntVal);//verifies 52 unique cards with vals and suits
            }
            //testDeck.topMost();
            testDeck.shuffle();
            foreach (var item in testDeck.cards)
            {
                System.Console.WriteLine("{0},{1},{2}", item.NameVal, item.Soot, item.IntVal);//verifies topMost card was removed, EG Ace of Spades//
                //of the new random order of desk after deck is created
            }
            Player firstPlayer = new Player("Dan");//instanciates a player called Dan
            System.Console.WriteLine(firstPlayer.name);//verifies the player was created
            firstPlayer.drawCard(testDeck);//draws 1 card
            firstPlayer.drawCard(testDeck);//draws another card
            firstPlayer.drawCard(testDeck);//draws yet another card
            foreach (var item in firstPlayer.hand)
            {
                System.Console.WriteLine("{0},{1},{2}", item.NameVal, item.Soot, item.IntVal);//verifies 3 cards drawn
            }
            firstPlayer.discard(firstPlayer.hand[0]);//discards the 0 idx card from firstplayer hand
            foreach (var item in firstPlayer.hand)
            {
                System.Console.WriteLine("{0},{1},{2}", item.NameVal, item.Soot, item.IntVal);//verifies only 2 cards exist in hand
            }
        }
    }
}
