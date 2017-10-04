using System;
using System.Collections.Generic;

namespace cards 
{
    public enum Suit
    {
        Diamonds,
        Clubs,
        Hearts,
        Spades,
    };
    public class Card 
    {
        public string stringVal { get; set; }
        public Suit suit { get; set; }
        public int val { get; set; }

        public Card(Suit suit, int val)
        {
            this.suit = suit;
            this.val = val;

            switch (val)
            {
                case 1:
                    this.stringVal = "Ace";
                    break;
                case 2:
                    this.stringVal = "2";
                    break;
                case 3:
                    this.stringVal = "3";
                    break;
                case 4:
                    this.stringVal = "4";
                    break;
                case 5:
                    this.stringVal = "5";
                    break;
                case 6:
                    this.stringVal = "6";
                    break;
                case 7:
                    this.stringVal = "7";
                    break;
                case 8:
                    this.stringVal = "8";
                    break;
                case 9:
                    this.stringVal = "9";
                    break;
                case 10:
                    this.stringVal = "10";
                    break;
                case 11:
                    this.stringVal = "Jack";
                    break;
                case 12:
                    this.stringVal = "Queen";
                    break;
                case 13:
                    this.stringVal = "King";
                    break;
                default:
                    this.stringVal = null;
                    break;
            }

        }

        public void Print()
        {
            Console.WriteLine(this.stringVal + " " + this.suit);
        }
    }






















}