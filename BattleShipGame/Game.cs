using System;
using System.Collections.Generic;

namespace BattleShipGame
{
    public class Game 
    {
        private const int GridWidth = 10;
        private const int GridHeight = 10;
        
        private string _name = "";
        private int _hits = 0;
        private List<string> _hitCoordinates = new List<string>();
        private List<string> _missCoordinates = new List<string>();
        public int GuessesLeft;
        public bool GameOver = false;
 
        public void Welcome()
        {
            Console.WriteLine("\n\t\tWelcome to Battleship!\n");
            Console.Write("What is your name? ");
            while (_name == "")
            {
                _name = Console.ReadLine()?.Trim();
            }
            Console.WriteLine($"Let's play some Battleship, {_name}!\n");
        }
        
        public void DisplayRules()
        {
            Console.WriteLine("Rules:");
            Console.WriteLine($"Grid you will play on is {GridWidth} X {GridHeight}");
            Console.WriteLine("The grid is represented by vertical LETTERS (a-i) and horizontal NUMBERS (0-9)");
            Console.WriteLine("For example... a valid guess would be d5 or f7\n");
        }

        public bool IsPreviousGuess(string positionChoice)
        {
            return _hitCoordinates.Contains(positionChoice) || _missCoordinates.Contains(positionChoice);
        }

        public void HitShip(string positionChoice)
        {
            _hits++;
            _hitCoordinates.Add(positionChoice);
            if (_hits == 5)
            {
                GameOver = true;
                Console.WriteLine($"\nYou've sunk the Battleship, {_name}!!! (｡^‿^｡)");
            }
            else
            {
                Console.WriteLine($"\nDirect hit! You have hit the ship {_hits} times!");
            }
        }
        public void MissShip(string positionChoice)
        {
            GuessesLeft--;
            _missCoordinates.Add(positionChoice);
            switch (GuessesLeft)
            {
                case 0:
                    GameOver = true;
                    Console.WriteLine("\nMiss! You lose and the pirates took over you're ship! ╭∩╮(｡^_^｡)");
                    break;
                case 1:
                    Console.WriteLine("\nMiss! This is your last chance!");
                    break;
                default:
                    Console.WriteLine($"\nMiss! You have {GuessesLeft} guesses left!");
                    break;
            }
        }
        public void DisplayGuesses()
        {
            Console.Write("\nHits: ");
            foreach (var guess in _hitCoordinates)
            {
                Console.Write($"{guess} ");
            }
            Console.Write("\nMisses: ");
            foreach (var guess in _missCoordinates)
            {
                Console.Write($"{guess} ");
            }
        }

        public string AskForPosition()
        {
            bool guessIsInvalid = true;
            string positionChoice;
 
            do
            {
                Console.WriteLine("\nWhere would you like to move? ");
                positionChoice = Console.ReadLine()?.ToLower().Trim();

                guessIsInvalid = String.IsNullOrWhiteSpace(positionChoice) || positionChoice.Length != 2;
                if (guessIsInvalid)
                {
                    Console.WriteLine("\nInvalid Coordinates...");
                }
            } while (guessIsInvalid);

            return positionChoice;
        }
        
    }
}