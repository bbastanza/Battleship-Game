using System;

namespace BattleShipGame
{
    public static class Rules
    {
        private const int GridWidth = 10;
        private const int GridHeight = 10;
        public static void DisplayRules()
        {
            Console.WriteLine("Rules:");
            Console.WriteLine($"Grid you will play on is {GridWidth} X {GridHeight}");
            Console.WriteLine("The grid is represented by vertical LETTERS (a-i) and horizontal NUMBERS (0-9)");
            Console.WriteLine("For example... a valid guess would be d5 or f7\n");
        }
    }
}