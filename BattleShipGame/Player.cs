using System;

namespace BattleShipGame
{
    public class Player
    {
        public string Name;
        public byte Hits = 0;
        public byte GuessesLeft;
        public bool GameOver = false;


        public void Welcome()
        {
            Console.WriteLine("\n\t\tWelcome to Battleship!\n");
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Console.WriteLine($"Let's play some Battleship, {Name}!");
        }

        public void HitShip()
        {
            Hits++;
            if (Hits == 5)
            {
                GameOver = true;
                Console.WriteLine($"You've sunk the Battleship {Name}!!!");
            }
            else
            {
                Console.WriteLine($"Direct hit! You have hit the ship {Hits} times!");
            }
        }

        public void MissShip()
        {
            GuessesLeft--;
            if (GuessesLeft == 0)
            {
                GameOver = true;
                Console.WriteLine("Miss! You lose and the pirates took over you're ship!");
            }
            else if (GuessesLeft == 1)
            {
                Console.WriteLine("Miss! This is your last chance!");
            }
            else
            {
                Console.WriteLine($"Miss! You have {GuessesLeft} left!");
            }
        }

    }
}