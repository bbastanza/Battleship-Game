using System;

namespace BattleShipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine("What is your name?");
            var player = new Player();
            var grid = new Grid();
            var difficulty = new Difficult();
            
            player.Name = Console.ReadLine();
            player.Welcome();
            
            grid.LogGrid();
            difficulty.ChooseDifficulty();
        }
    }
}