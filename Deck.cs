using System;
using System.Collections.Generic;

namespace Cards
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();

        // how do I write the constructor?
        public Deck() 
        {
            this.Reset();
        }

        // Shuffle
        public void Shuffle() 
        {
            Random r = new Random();
            for(int i=0; i<cards.Count; i++)
            {
                int randomIndex = r.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }

        // Deal
        public Card Deal()
        {
            if(cards.Count == 0) 
            {
                throw new Exception("Deck is empty");
            }
            Card cardToReturn = cards[0];
            cards.RemoveAt(0);
            return cardToReturn;
        }

        // Reset
        public void Reset() 
        {
            cards = new List<Card>();
            List<string> values = new List<string>() {
                "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen","King"
            };
            List<string> suits = new List<string>() {
                "Clubs", "Spades", "Hearts", "Diamonds"
            };
            foreach(string value in values)
            {
                foreach(string suit in suits) 
                {
                    cards.Add( new Card(suit, value) );
                }
            }
        }

    }
}