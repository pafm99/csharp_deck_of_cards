using System;
using System.Collections.Generic;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck mydeck = new Deck(); //instance of Deck called mydeck
            Card myCard = mydeck.Deal();
            Console.WriteLine(myCard.stringVal + " " + myCard.suit);
            mydeck.Shuffle();
            myCard = mydeck.Deal();
            Console.WriteLine(myCard.stringVal + " " + myCard.suit);
            Player bob = new Player("bob");
            bob.Draw(mydeck);
            bob.Draw(mydeck);
            bob.Draw(mydeck);
            bob.Draw(mydeck);
            bob.Draw(mydeck);
            bob.Draw(mydeck);
            bob.Discard(1).Print();
            bob.Discard(1).Print();
            bob.Discard(1).Print();
            bob.Discard(1).Print();
            bob.Discard(1).Print();
            
        }
    }
}
