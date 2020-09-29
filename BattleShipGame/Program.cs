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
                var game = new Game();
                var difficulty = new Difficulty();
                var ship = new Ship();
                
                game.Welcome();
                
                game.DisplayRules();
            
                game.GuessesLeft = difficulty.ChooseDifficulty();

                while (!game.GameOver)
                {
                    game.DisplayGuesses();
                    
                    var positionChoice = game.AskForPosition();

                    if (ship.isValidCoordinates(positionChoice))
                        Console.WriteLine("\nInvalid Coordinates...");
                    
                    else if (game.IsPreviousGuess(positionChoice))
                        Console.WriteLine("\nYou already guessed that...");
                    
                    else if (ship.IsHit(positionChoice))
                        game.HitShip(positionChoice);
                    
                    else
                        game.MissShip(positionChoice);
                    
                }
                ship.ShowShipCoordinates();
                gameGoing = PlayAgain.Restart();
            }
        }
    }
}