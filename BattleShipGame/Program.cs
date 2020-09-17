using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleShipGame
{
    static class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            var grid = new Grid();
            var difficulty = new Difficult();
            var ship = new Ship();
            
            ship.CreateShip();
            var shipPositions = new List<string>(ship.ShipPositions);
            // Console.WriteLine($"{ship.ShipPositions[0]}, {ship.ShipPositions[1]}, {ship.ShipPositions[2]}, {ship.ShipPositions[3]}, {ship.ShipPositions[4]}");
            
            player.Welcome();
            
            grid.LogGrid();
            difficulty.ChooseDifficulty();
            player.GuessesLeft = difficulty.Chances;
            
            while (player.GameOver == false)
            {
                Console.WriteLine("Where would you like to move?");
                var positionChoice = Console.ReadLine();
            
                if (shipPositions.Contains(positionChoice))
                {
                    player.HitShip();
                    shipPositions.Remove(positionChoice);
                }
                else
                {
                    player.MissShip();
                }
            }
        }
    }
}