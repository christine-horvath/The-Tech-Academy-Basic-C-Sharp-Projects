using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Deck
    {
        public Deck()
        {
            // nested foreach loop 
            //create a list of all the possible suits 
            Cards = new List<Card>();

            //access particular integers assigned to enums 
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    //casting to face j -- just put datatype youre casting to inside ()
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        //    List<string> suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
        //    List<string> faces = new List<string>()

        //    {
        //        "Two", "Three", "Four", "Five","Six", "Seven","Eight",
        //        "Nine","Ten", "Jack","Queen", "King", "Ace"
        //    };

        //    foreach (string face in faces)
        //    {
        //        foreach (string suit in suits)
        //        {
        //            Card card = new Card();
        //            card.Suit = suit;
        //            card.Face = face;
        //            Cards.Add(card);
        //        }
        //    }

        //}
        public List<Card> Cards { get; set; }

        // create optional parameter 
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    //take out of random and put into temp list
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
