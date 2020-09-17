using System;
using System.Collections.Generic;
using System.Linq;

namespace BattleShipGame
{
    static class Program
    {
        static void Main()
        {

            var gameGoing = true;
            while (gameGoing)
            {
                var player = new Player();
                var difficulty = new Difficulty();
                var ship = new Ship();
                var possibleCoordinates = ship.PossibleCoordinates;
                var hitCoordinates = new List<string>();
                var missCoordinates = new List<string>();
                ship.CreateShip();
                var shipPositions = new List<string>(ship.ShipPositions);
                
            
                player.Welcome();
                
                Rules.DisplayRules();
            
                player.GuessesLeft = difficulty.ChooseDifficulty();
                
                while (!player.GameOver)
                {
                    Console.Write("\nHits: ");
                    foreach (var guess in hitCoordinates)
                    {
                        Console.Write($"{guess} ");
                    }
                    Console.Write("\nMisses: ");
                    foreach (var guess in missCoordinates)
                    {
                        Console.Write($"{guess} ");
                    }
                    
                    Console.WriteLine("\nWhere would you like to move? ");
                    var positionChoice = Console.ReadLine()?.ToLower();
                    foreach(var guess in missCoordinates){}
                    
                    if (!possibleCoordinates.Contains(positionChoice))
                    {
                        Console.WriteLine("\nInvalid Guess...");
                    }
                    else if (hitCoordinates.Contains(positionChoice) || missCoordinates.Contains(positionChoice))
                    {
                        Console.WriteLine("\nYou already guessed that...");
                    }
                    else if (shipPositions.Contains(positionChoice))
                    {
                        player.HitShip();
                        shipPositions.Remove(positionChoice);
                        hitCoordinates.Add(positionChoice);
                    }
                    else
                    {
                        player.MissShip();
                        missCoordinates.Add(positionChoice);
                    }
                }
                ship.ShowShipCoordinates();
                gameGoing = PlayAgain.Restart();
            }
        }
    }
}