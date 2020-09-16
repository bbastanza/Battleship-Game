using System;

namespace BattleShipGame
{
    public class Player
    {
        public string Name;
        public byte Hits = 0;
        public byte GuessesLeft;


        public void Welcome()
        {
            Console.WriteLine($"Let's play some Battleship, {Name}!");
        }

        public void HitShip()
        {
            Hits++;
            if (Hits == 5)
            {
                Console.WriteLine("You've sunk the Battleship!!!");
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