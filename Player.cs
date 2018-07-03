using System;
using System.Collections.Generic;
namespace deck
{
    public class Player
    {
        public string name;
        public List<Card> hand = new List<Card>();
        public Player(string val)
        {
            name = val;
        }
        public Object drawCard(Deck deck)//reference to deck object
        {
            Random rand = new Random();
            var randomPosition = rand.Next(1,deck.cards.Count);
            var cardDrawn = deck.cards[randomPosition];
            hand.Add(cardDrawn);
            deck.cards.Remove(cardDrawn);
            return(cardDrawn);
        }
        public Card discard(Card card)
        {
            var cardDrawn = card;
            hand.Remove(cardDrawn);
            return(cardDrawn);
        }
    }
}