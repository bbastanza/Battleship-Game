using System;

namespace BattleShipGame
{
    public class Player
    {
        public string Name;


        public void Welcome()
        {
            Console.WriteLine($"Let's play some Battleship {Name}");
        }
        
    }
}