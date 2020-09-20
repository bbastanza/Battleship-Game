using System;
using System.Collections.Generic;

namespace BattleShipGame
{
    public class Player
    {
        private string _name = "";
        private int _hits = 0;
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

        public void HitShip()
        {
            _hits++;
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
        public void MissShip()
        {
            GuessesLeft--;
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
        public static void DisplayGuesses(List<string> hits, List<string> misses)
        {
            Console.Write("\nHits: ");
            foreach (var guess in hits)
            {
                Console.Write($"{guess} ");
            }
            Console.Write("\nMisses: ");
            foreach (var guess in misses)
            {
                Console.Write($"{guess} ");
            }
        }
    }
}