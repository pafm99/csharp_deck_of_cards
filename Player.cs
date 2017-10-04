using System;
using System.Collections.Generic;
namespace cards
{
    public class Player
    {
        public List<Card> hand = new List<Card>();
        public string name;

        public Player(string name) //Player takes in a string we are calling name
        {
            this.name = name; 
        }

        public Card Draw(Deck deck) 
        {
            Card temp = deck.Deal(); 
            hand.Add(temp);
            return temp;
        }

        public Card Discard(int idx)
        {
            if (idx < 0 || idx >= hand.Count)
            {
                return null;
            }
            Card temp = hand[idx];
            hand.RemoveAt(idx);
            return temp;
        }
    }







}