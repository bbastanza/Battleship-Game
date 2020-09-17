using System;

namespace BattleShipGame
{
    public class Player
    {
        private string _name;
        private int _hits = 0;
        private int _misses = 0;
        public int GuessesLeft;
        public bool GameOver = false;
 
        public void Welcome()
        {
            Console.WriteLine("\n\t\tWelcome to Battleship!\n");
            Console.Write("What is your name? ");
            _name = Console.ReadLine();
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
            _misses++;
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
        

    }
}