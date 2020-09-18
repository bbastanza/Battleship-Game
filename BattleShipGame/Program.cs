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
                
                var hitCoordinates = new List<string>();
                var missCoordinates = new List<string>();
                
                ship.CreateShip();
                var shipPositions = new List<string>(ship.ShipPositions);
                
                player.Welcome();
                
                Rules.DisplayRules();
            
                player.GuessesLeft = difficulty.ChooseDifficulty();
                
                while (!player.GameOver)
                {
                    Player.DisplayGuesses(hitCoordinates, missCoordinates);
                    
                    Console.WriteLine("\nWhere would you like to move? ");
                    var positionChoice = Console.ReadLine()?.ToLower();

                    if (positionChoice != null && (!ship.PossibleYCoordinates.Contains(positionChoice[0])
                                                   || !ship.PossibleXCoordinates.Contains(positionChoice[1])
                                                   || positionChoice.Length > 2
                                                   || positionChoice.Length < 1))
                        Console.WriteLine("\nInvalid Guess...");
                    
                    else if (hitCoordinates.Contains(positionChoice) || missCoordinates.Contains(positionChoice))
                        Console.WriteLine("\nYou already guessed that...");
                    
                    else if (shipPositions.Contains(positionChoice))
                    {
                        player.HitShip();
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