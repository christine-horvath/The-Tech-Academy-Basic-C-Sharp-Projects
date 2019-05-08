using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            //insert player name inside curly braces
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            //instantiate with player constructor 
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            //don't need an else statment - if they answer no, they'll skip right to this line
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
            //reference and value types - reference types = get value by reference (lists, classes, strings)
            // value is something you create brand new - bool, int (struct) - the same as a class but it's a value type. can't be inherited
            //value types can't have value of null - value types are NOT nullable - bool, int
            //Card card = new Card() { Face = "King", Suit = "Spades"} - can create a card this way, it's easier - as opposed to below. 
            //card.Face = "King";
            // card.Suit = "Spades";
            //TwentyOneGame game = new TwentyOneGame();
            //instantiate the list for the object - otherwise object will return null
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            // below is specific to twentyonegame, and wouldn't be accessible if we were calling Game game = new Twentyonegame
            //game.Play();
            //Console.ReadLine();
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Bill", "Julie" };
            //game.ListPlayers();

            
            //    Game game = new TwentyOneGame();
            //    //thumbs up that above will compile - this is classic polymorphism - one object can morph into a higher order (inherits from) object
            //    //we do this because twentyoneame game = new twentyone game would be specific to twentyone game, but the above way gives us access
            //    //to new games to add to the list - which can only take ONE data type - PokerGame, SolitaireGame = list><Game> games = new List<game>(); games.Add(game);
            //    //call the method - ",3" - is the number of times it will be shuffled
            //    //polymorphism = ability of a class to morph into an inheriting class, which gives it special abilities. 
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game = game + player;
            ////game += player  is the same as above, -= is same as below
            //game = game - player;

           // Deck deck = new Deck();
            //lambda expression is "Count" - deck.Cards.(brings up all lambda functions)
            //=> = where, unique to lambda function
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //List<int> numberList = new List<int>() { 5, 56, 77, 844, 3 };
           // int sum = numberList.Sum(x => x + 5);
           // //for each item, add five 
           // int sum = numberList.Min();
            //where creates a new list
            //combine expressions, functions below is instead of a for loop - makes programming more fun!
            //int sum = numberList.Where(x => x > 20).Sum();
            //lambda expressions are hard to debug, can be hard to read if they're long

            //Console.WriteLine(sum);
            //Console.ReadLine();

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}
            //deck.Shuffle(3);
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }



        //create overload code 
        //{
        //  for (int i = 0; i < times>; i++)
        //  {
        //    deck = Shuffle(deck);
        //   }
        //return deck;
        //}
    }
}

