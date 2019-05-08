using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public struct Card
        //don't want the value of card to change - and nothing is inheriting from card
        //no longer a reference type - so card card2 = card 1 would return value of card1, not card2
    {
        
        //constructor = values assigned to object upon creation 
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        //public makes it accessible to other parts of the program
        //enum = 1 choice among limited choices (suits, days of the week)
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit); 
        }
    }
    //enums have an underlying data type = underlying value is assigned in order starting 
    //with zero (int) can cast to int, can set values if you'd like 
    public enum Suit
    {
        Clubs, 
        Diamonds, 
        Hearts, 
        Spades
    }
    public enum Face
    {
        Two, 
        Three, 
        Four, 
        Five, 
        Six, 
        Seven, 
        Eight, 
        Nine, 
        Ten, 
        Jack, 
        Queen, 
        King, 
        Ace
    }
}
