using System;

namespace BattleShipGame
{
    public class Difficult
    {
        public string Difficulty;
        public int Chances;
        
        public void ChooseDifficulty()
        {
            Console.WriteLine("1=HARD 2=MEDIUM 3=EASY");
            Console.WriteLine("Please Choose a Difficulty: ");
            Difficulty = Console.ReadLine();
            if (Difficulty == "1")
            {
                Chances = 8;
            } else if (Difficulty == "2")
            {
                Chances = 10;
            }else if (Difficulty == "3")
            {
                Chances = 12;
            }
            Console.WriteLine($"You have {Chances} chances!");
        }
    }
}