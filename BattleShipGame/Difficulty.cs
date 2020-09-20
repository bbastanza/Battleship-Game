using System;

namespace BattleShipGame
{
    public class Difficulty
    {
        private string _difficulty;
        private int _chances;
        
        public int ChooseDifficulty()
        {
            Console.WriteLine("1=HARD 2=MEDIUM 3=EASY");
            Console.Write("Please Choose a Difficulty: ");
            _difficulty = Console.ReadLine()?.Trim();
            while (_difficulty != "1" && _difficulty != "2" && _difficulty != "3")
            {
                Console.Write("Invalid Response: Please Choose a Difficulty: ");
                _difficulty = Console.ReadLine()?.Trim();
            }

            switch (_difficulty)
            {
                case "1":
                    _chances = 8;
                    break;
                case "2":
                    _chances = 10;
                    break;
                case "3":
                    _chances = 12;
                    break;
            }
            Console.WriteLine($"\nYou have {_chances} chances!");
            return _chances;
        }
    }
}