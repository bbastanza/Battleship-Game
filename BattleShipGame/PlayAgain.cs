using System;

namespace BattleShipGame
{
    public static class PlayAgain
    {
        public static bool Restart()
        {
            Console.WriteLine("Play Again? (Y or N)");
            var playAgain = "";
            while (playAgain != "y" && playAgain != "n")
                playAgain = Console.ReadLine()?.ToLower();
            return playAgain != "n";
        }
    }
}