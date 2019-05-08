using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public abstract class Game
    {
        //abstract class means it will never be an object - is only meant to be inherited from. cannot be instantiated
        //make it impossible to make an object - helpful for team work 
        //must instantiate an empty list 
        private List<Player> _players = new List<Player>();
        //below makes it so that you ALWAYS have an empty list, not null 
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public Dictionary<Player, int> Bets { get {return _bets; } set {_bets = value; } }


        //abstract method - can only exist inside of an abstract class, contains NO implementation. any class inheriting this class must inherit this method
        public abstract void Play();
        
        //virtual method inside of an abstract class - method gets inherited by class, but it has the ability to override it
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
