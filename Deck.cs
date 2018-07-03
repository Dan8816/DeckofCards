using System;
using System.Collections.Generic;
namespace deck
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public List<string> cardValue = new List<string>
        {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
        public List<string> cardSuit = new List<string>
        {"Spades", "Hearts", "Diamonds", "Clubs"};
        public Deck()
        {
            for (var i = 0; i < cardSuit.Count; i++)
            {
                for (var j = 0; j < cardValue.Count; j++)
                {
                    var StrVal = cardValue[j];
                    var Suit = cardSuit[i];
                    var FaceVal = j+1;
                    Card cardName = new Card(StrVal, Suit, FaceVal);
                    cards.Add(cardName);
                }
            }
        }
        public Card topMost()
        {
            var topCard = cards[0];//defines top card as idx 0
            cards.RemoveAt(0);
            return (topCard);
        }
        public void shuffle()
        {
            Random rand = new Random();
            for (var i = 0; i < cards.Count; i++)
            {
                var randomPosition = rand.Next(0, cards.Count);
                var temp = cards[i];
                cards[i] = cards[randomPosition];
                cards[randomPosition] = temp;
            }

        }
    }
}