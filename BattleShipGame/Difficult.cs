using System;

namespace BattleShipGame
{
    public class Difficult
    {
        public string Difficulty;
        public byte Chances;
        
        public void ChooseDifficulty()
        {
            Console.WriteLine("1=HARD 2=MEDIUM 3=EASY");
            Console.WriteLine("Please Choose a Difficulty: ");
            Difficulty = Console.ReadLine();
            while (Difficulty != "1" && Difficulty != "2" && Difficulty != "3")
            {
                Console.WriteLine("Invalid Response: Please Choose a Difficulty: ");
                Difficulty = Console.ReadLine();
            }

            if (Difficulty == "1")
            {
                Chances = 6;
            } else if (Difficulty == "2")
            {
                Chances = 8;
            }else if (Difficulty == "3")
            {
                Chances = 10;
            }
            Console.WriteLine($"\nYou have {Chances} chances!");
        }
    }
}