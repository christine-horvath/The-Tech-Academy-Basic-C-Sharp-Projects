using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Dealer
    {   //inheritence is a "is a" relationship not a "has a" - cannot inherit deck because the dealer has a deck, not IS a deck
        //air on the side of adding a class as a property of another class over inheriting from it
        //objects mimic real world 
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        //takes as an input parameter (hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }
    }
}
